using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Diagnostics;
using waveShifter.WaveFile.Chunks;

namespace waveShifter.WaveFile {
    class WaveFileShifter : IDisposable {
        BinaryReader reader;
        BinaryWriter writer;

        string filenameOriginal;
        string filenameChanged;
        SolutionDelegate solutionDeleg;
        IntDelegate setMaxDeleg;
        IntDelegate updateDeleg;

        int shiftedMilieSeconds;
        int needToAddSamples;

        WaveFile waveFile;

        #region General Utilities
        /*
		 * WaveFileReader(string) - 2004 July 28
		 * A fairly standard constructor that opens a file using the filename supplied to it.
		 */
        public WaveFileShifter(string filenameOriginal, string filenameChanged, int shiftedMilieSeconds, SolutionDelegate solutionDeleg, IntDelegate setMaxDeleg, IntDelegate updateDeleg) {
            reader = new BinaryReader(new FileStream(filenameOriginal, FileMode.Open, FileAccess.Read, FileShare.Read));
            writer = new BinaryWriter(new FileStream(filenameChanged, FileMode.Create, FileAccess.Write));
            this.filenameOriginal = filenameOriginal;
            this.filenameChanged = filenameChanged;
            this.shiftedMilieSeconds = shiftedMilieSeconds;
            this.solutionDeleg = solutionDeleg;
            this.setMaxDeleg = setMaxDeleg;
            this.updateDeleg = updateDeleg;
        }
 
        public void ReadWaveFile(){
            ReadMainFileHeader();
            while (GetPosition() < (long)waveFile.maindata.dwFileLength) {
                uint chunkSize = 0;
                switch (GetChunkName()) {
                    case "fmt ":
                        ReadFormatHeader();
                        WriteMainFileHeader();
                        WriteFormatHeader();
                        chunkSize = waveFile.format.dwChunkSize;
                        break;
                    case "data":
                        ReadWriteDataHeader();
                        chunkSize = waveFile.data.dwChunkSize;
                        break;
                    default:
                        AdvanceToNext();
                        break;
                }
                if (GetPosition() + chunkSize == waveFile.maindata.dwFileLength) {
                    break;
                }
            }

            
        }

        /*
         * long GetPosition() - 2004 July 28
         * Returns the current position of the reader's BaseStream.
         */
        public long GetPosition() {
            return reader.BaseStream.Position;
        }

        /*
         * string GetChunkName() - 2004 July 29
         * Reads the next four bytes from the file, converts the 
         * char array into a string, and returns it.
         */
        public string GetChunkName() {
            return new string(reader.ReadChars(4));
        }

        /*
         * void AdvanceToNext() - 2004 August 2
         * Advances to the next chunk in the file.  This is fine, 
         * since we only really care about the fmt and data 
         * streams for now.
         */
        public void AdvanceToNext() {
            long NextOffset = (long)reader.ReadUInt32(); //Get next chunk offset
            //Seek to the next offset from current position
            reader.BaseStream.Seek(NextOffset, SeekOrigin.Current);
        }
        #endregion
        #region Header Extraction Methods
        public void ReadMainFileHeader() {
            waveFile = new WaveFile();
            waveFile.maindata = new RiffChunk();

            Debug.WriteLine("position reader: " + reader.BaseStream.Position);
            waveFile.maindata.sGroupID = new string(reader.ReadChars(4));
            Debug.WriteLine("position reader: " + reader.BaseStream.Position);
            waveFile.maindata.dwFileLength = reader.ReadUInt32() + 8;
            Debug.WriteLine("position reader: " + reader.BaseStream.Position);
            waveFile.maindata.sRiffType = new string(reader.ReadChars(4));
            Debug.WriteLine("position reader: " + reader.BaseStream.Position);

            Debug.WriteLine(waveFile.maindata.dwFileLength);
            Debug.WriteLine(reader.BaseStream.Length);
        }

        public void WriteMainFileHeader() {
            Debug.WriteLine("position writer: " + writer.BaseStream.Position);
            writer.Write(waveFile.maindata.sGroupID.ToArray());
            Debug.WriteLine("position writer: " + writer.BaseStream.Position);
            writer.Write((UInt32)(waveFile.maindata.dwFileLength - 8 + needToAddSamples));
            Debug.WriteLine("position writer: " + writer.BaseStream.Position);
            writer.Write(waveFile.maindata.sRiffType.ToArray());
            Debug.WriteLine("position writer: " + writer.BaseStream.Position);
        }

        public void ReadFormatHeader() {
            waveFile.format = new FmtChunk();

            waveFile.format.sChunkID = "fmt ";
            waveFile.format.dwChunkSize = reader.ReadUInt32();
            waveFile.format.wFormatTag = reader.ReadUInt16();
            waveFile.format.wChannels = reader.ReadUInt16();
            waveFile.format.dwSamplesPerSec = reader.ReadUInt32();
            Debug.WriteLine("samplesPerSec: " + waveFile.format.dwSamplesPerSec);
            needToAddSamples = ((int)waveFile.format.dwSamplesPerSec * shiftedMilieSeconds) / 1000;
            if (needToAddSamples < 0) {
                needToAddSamples *= -1;
            }

            waveFile.format.dwAvgBytesPerSec = reader.ReadUInt32();
            waveFile.format.wBlockAlign = reader.ReadUInt16();
            waveFile.format.dwBitsPerSample = reader.ReadUInt16();
            Debug.WriteLine("position reader: " + reader.BaseStream.Position);
        }

        public void WriteFormatHeader() {
            writer.Write(waveFile.format.sChunkID.ToArray());
            writer.Write(waveFile.format.dwChunkSize);
            writer.Write(waveFile.format.wFormatTag);
            Debug.WriteLine("formaat: " + waveFile.format.wFormatTag);
            writer.Write(waveFile.format.wChannels);
            writer.Write(waveFile.format.dwSamplesPerSec);
            writer.Write(waveFile.format.dwAvgBytesPerSec);
            writer.Write(waveFile.format.wBlockAlign);
            writer.Write(waveFile.format.dwBitsPerSample);
            Debug.WriteLine("bits per sample: " + waveFile.format.dwBitsPerSample);
            Debug.WriteLine("position writer: " + writer.BaseStream.Position);
        }

        public void ReadWriteDataHeader() {
            waveFile.data = new DataChunk();

            waveFile.data.sChunkID = "data";
            writer.Write(waveFile.data.sChunkID.ToArray());

            waveFile.data.dwChunkSize = reader.ReadUInt32();
            writer.Write((UInt32)(waveFile.data.dwChunkSize + needToAddSamples));

            waveFile.data.lFilePosition = reader.BaseStream.Position;

            waveFile.data.dwNumSamples = waveFile.data.dwChunkSize / ((uint)waveFile.format.dwBitsPerSample / 8 * waveFile.format.wChannels);

            waveFile.data.arrayList = new ArrayList();
            Debug.WriteLine("aantal : " + waveFile.data.dwNumSamples);
            setMaxDeleg((int)waveFile.data.dwNumSamples + needToAddSamples);

            if(waveFile.format.dwBitsPerSample==16){
                ReadData16bitInt();
            }
            else{
                if (waveFile.format.dwBitsPerSample==32) {
                    ReadData32bitFloat();
                }
            }

            Debug.WriteLine(writer.BaseStream.Length);
            solutionDeleg();
            //The above could be written as data.dwChunkSize / format.wBlockAlign, but I want to emphasize what the frames look like.
            //data.dwMinLength = (data.dwChunkSize / format.dwAvgBytesPerSec) / 60;
            //data.dSecLength = ((double)data.dwChunkSize / (double)format.dwAvgBytesPerSec) - (double)data.dwMinLength * 60;
        }
        /*
        public void ReadData() {
        }
        */

        public void ReadData16bitInt() {
            ArrayList temp = new ArrayList();
            for (int i = 0; i < needToAddSamples; i++) {
                if (shiftedMilieSeconds < 0) {
                    temp.Add(reader.ReadInt16());
                    writer.Write((Int16)0);
                    writer.Write(reader.ReadInt16());
                }
                else {
                    writer.Write(reader.ReadInt16());
                    temp.Add(reader.ReadInt16());
                    writer.Write((Int16)0);
                }
                updateDeleg(i);
            }

            for (int i = 0; i < waveFile.data.dwNumSamples - needToAddSamples; i++) {
                //Debug.WriteLine("Right " + i + ": " + reader.ReadUInt16());
                //Debug.WriteLine("Left " + i + ": " + reader.ReadUInt16());
                if (shiftedMilieSeconds < 0) {
                    temp.Add(reader.ReadInt16());
                    writer.Write((Int16)temp[0]);
                    writer.Write(reader.ReadInt16());
                }
                else {
                    writer.Write(reader.ReadInt16());
                    temp.Add(reader.ReadInt16());
                    writer.Write((Int16)temp[0]);
                }
                temp.RemoveAt(0);
                updateDeleg((int)(i + needToAddSamples));
            }
            Debug.WriteLine("position: " + Environment.NewLine + "   reader: " + reader.BaseStream.Position + Environment.NewLine + "   writer: " + writer.BaseStream.Position + Environment.NewLine);


            for (int i = 0; i < needToAddSamples; i++) {
                if (shiftedMilieSeconds < 0) {
                    writer.Write((Int16)temp[0]);
                    writer.Write((Int16)0);
                }
                else {
                    writer.Write((Int16)0);
                    writer.Write((Int16)temp[0]);
                }
                temp.RemoveAt(0);
                updateDeleg((int)(i + waveFile.data.dwNumSamples));
            }
        }

        public void ReadData32bitFloat() {
            ArrayList temp = new ArrayList();
            for (int i = 0; i < needToAddSamples; i++) {
                if (shiftedMilieSeconds < 0) {
                    temp.Add(reader.ReadSingle());
                    writer.Write((float)0);
                    writer.Write(reader.ReadSingle());
                }
                else {
                    writer.Write(reader.ReadSingle());
                    temp.Add(reader.ReadSingle());
                    writer.Write((float)0);
                }
                updateDeleg(i);
            }

            for (int i = 0; i < waveFile.data.dwNumSamples - needToAddSamples; i++) {
                //Debug.WriteLine("Right " + i + ": " + reader.ReadUInt16());
                //Debug.WriteLine("Left " + i + ": " + reader.ReadUInt16());
                if (shiftedMilieSeconds < 0) {
                    temp.Add(reader.ReadSingle());
                    writer.Write((float)temp[0]);
                    writer.Write(reader.ReadSingle());
                }
                else {
                    writer.Write(reader.ReadSingle());
                    temp.Add(reader.ReadSingle());
                    writer.Write((float)temp[0]);
                }
                temp.RemoveAt(0);
                updateDeleg((int)(i + needToAddSamples));
            }
            Debug.WriteLine("position: " + Environment.NewLine + "   reader: " + reader.BaseStream.Position + Environment.NewLine + "   writer: " + writer.BaseStream.Position + Environment.NewLine);


            for (int i = 0; i < needToAddSamples; i++) {
                if (shiftedMilieSeconds < 0) {
                    writer.Write((float)temp[0]);
                    writer.Write((float)0);
                }
                else {
                    writer.Write((float)0);
                    writer.Write((float)temp[0]);
                }
                temp.RemoveAt(0);
                updateDeleg((int)(i + waveFile.data.dwNumSamples));
            }
        }
        #endregion
        #region IDisposable Members

        public void Dispose() {
            if (reader != null)
                reader.Close();
        }

        #endregion


    }
}
