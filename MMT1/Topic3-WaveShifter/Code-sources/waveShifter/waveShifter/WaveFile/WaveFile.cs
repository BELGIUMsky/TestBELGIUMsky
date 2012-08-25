using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using waveShifter.WaveFile.Chunks;

namespace waveShifter.WaveFile {
    class WaveFile {
        public RiffChunk maindata;
        public FmtChunk format;
        public DataChunk data;
    }
}
