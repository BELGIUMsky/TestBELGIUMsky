using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace spamfilter.DataLayer {
    public static class IO {
        public static List<String> ReadWordsFile(string fileName) {
            List<String> list = new List<string>();

            char[] seperator = { ' ', ',', '.', '!', '?', ':', ';', '"', '\n', '\r', '-' };

            using (StreamReader reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read))) {
                list = reader.ReadToEnd().ToLower().Split(seperator, StringSplitOptions.RemoveEmptyEntries).ToList<String>();
            }

            return list;
        }

        public static List<String> GetFilesDirectory(string directoryPath) {
            return Directory.GetFiles(directoryPath).ToList<String>();
        }
    }
}
