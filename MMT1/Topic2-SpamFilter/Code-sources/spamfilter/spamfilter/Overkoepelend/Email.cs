using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using spamfilter.DataLayer;

namespace spamfilter.Overkoepelend {
    class Email {
        private List<String> words;
        private bool isSpam;
        private double[][] vectorSpaceModel;

        public bool IsSpam {
            get{
                return this.isSpam;
            }
        }

        public List<String> Words {
            get {
                return this.words;
            }
        }

        public double[][] VectorSpaceModel {
            get {
                return this.vectorSpaceModel;
            }
            set {
                this.vectorSpaceModel = value;
            }
        }

        public Email(string fileName) {
            this.words = IO.ReadWordsFile(fileName);
            this.vectorSpaceModel = new double[2][];
        }

        public Email(string fileName, bool isSpam) : this(fileName) {
            this.isSpam = isSpam;
        }

        public double GetSum(int forHam) {
            return vectorSpaceModel[forHam].Sum();
        }
    }
}
