using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using spamfilter.DataLayer;

namespace spamfilter.Overkoepelend {
    class Set {
        private List<Email> emails;
        double[][] inputs;
        int[] outputs;

        public List<Email> Emails {
            get{
                return new List<Email>(this.emails);
            }
            set {
                this.emails = value;
            }
        }

        public double[][] Inputs {
            get {
                return inputs;
            }
        }

        public int[] Outputs {
            get {
                return outputs;
            }
        }

        public Set() {
            emails = new List<Email>();
        }

        public void AddData(string directoryPath, bool isSpam) {
            foreach (string file in IO.GetFilesDirectory(directoryPath)) {
                emails.Add(new Email(file, isSpam));
            }
        }

        public void MakeInputsOutputs() {
            int aantal = emails.Count;
            inputs = new double[aantal][];
            outputs = new int[aantal];
            for (int i = 0; i < aantal; i++) {
                double[] temp = new double[2];
                temp[0] = emails[i].GetSum(0);
                temp[1] = emails[i].GetSum(1);

                outputs[i] = (emails[i].IsSpam ? 1 : 0);
                inputs[i] = temp;
            }
        }
    }
}
