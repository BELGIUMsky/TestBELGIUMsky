using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace waveShifter.WaveFile.Chunks {
    public class RiffChunk {
        //These three fields constitute the riff header
        public string sGroupID;         //RIFF
        public uint dwFileLength;		//In bytes, measured from offset 8
        public string sRiffType;        //WAVE, usually
    }
}
