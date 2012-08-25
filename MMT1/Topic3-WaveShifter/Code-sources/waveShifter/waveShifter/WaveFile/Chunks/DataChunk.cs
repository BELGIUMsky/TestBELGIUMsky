using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace waveShifter.WaveFile.Chunks {
    public class DataChunk {
        public string sChunkID;    		//Four bytes: "data"
        public uint dwChunkSize;    	//Length of header

        //The following non-standard fields were created to simplify
        //editing.  We need to know, for filestream seeking purposes,
        //the beginning file position of the data chunk.  It's useful to
        //hold the number of samples in the data chunk itself.  Finally,
        //the minute and second length of the file are useful to output
        //to XML.
        public long lFilePosition;	//Position of data chunk in file
        public uint dwMinLength;		//Length of audio in minutes
        public double dSecLength;		//Length of audio in seconds
        public uint dwNumSamples;		//Number of audio frames
        //Different arrays for the different frame sizes
        //public byte  [] byteArray; 	//8 bit - unsigned
        public ArrayList arrayList;    //16 bit - signed
    }
}
