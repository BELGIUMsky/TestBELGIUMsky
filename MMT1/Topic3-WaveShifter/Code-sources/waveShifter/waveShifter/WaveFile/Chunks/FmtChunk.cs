using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace waveShifter.WaveFile.Chunks {
    public class FmtChunk {
        public string sChunkID;    	//Four bytes: "fmt "
        public uint dwChunkSize;     //Length of header
        public ushort wFormatTag;  	//1 if uncompressed
        public ushort wChannels;       //Number of channels: 1-5
        public uint dwSamplesPerSec; //In Hz
        public uint dwAvgBytesPerSec;//For estimating RAM allocation
        public ushort wBlockAlign;     //Sample frame size in bytes
        public ushort dwBitsPerSample; //Bits per sample
    }
}
