using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using spamfilter.DataLayer;

namespace spamfilter.Overkoepelend {
    class TrainingsSet : Set {
        private List<String>[] termen;
        private double[][] IdfModel;

        public TrainingsSet(string[] termen) : base() {
            this.termen = new List<String>[2];
            this.termen[0] = IO.ReadWordsFile(termen[0]);
            this.termen[1] = IO.ReadWordsFile(termen[1]);
        }

        public void MakeVectorSpaceModels(List<Email> emails = null) {
            if (emails == null) {
                emails = this.Emails;
            }
            CalculateVectorSpaceModels(emails, 0);
            CalculateTfModel(emails, 0);
            if (IdfModel == null) {
                IdfModel = new double[2][];
                CalculateIDFModel(emails, 0);
            }
            CalculateTfIdfModel(emails, 0);

            CalculateVectorSpaceModels(emails, 1);
            CalculateTfModel(emails, 1);
            if (IdfModel[1] == null) {
                CalculateIDFModel(emails, 1);
            }
            CalculateTfIdfModel(emails, 1);
        }

        private void CalculateVectorSpaceModels(List<Email> emails, int forHam) {
            for (int i = 0; i < emails.Count; i++) {
                double[] vectorSpaceModel = new double[termen[forHam].Count];
                for (int k = 0; k < this.termen[forHam].Count; k++) {
                    double aantal = 0;
                    foreach (string word in emails[i].Words) {
                        if (word.Equals(termen[forHam][k])) {
                            aantal++;
                        }
                    }
                    vectorSpaceModel[k] = aantal;
                }
                emails[i].VectorSpaceModel[forHam] = vectorSpaceModel;
            }
        }

        private void CalculateTfModel(List<Email> emails, int forHam) {
            for (int i = 0; i < emails.Count; i++) {
                double max = emails[i].VectorSpaceModel[forHam].Max();
                if (max != 0) {
                    for (int k = 0; k < termen[forHam].Count; k++) {
                        emails[i].VectorSpaceModel[forHam][k] /= max;
                    }
                }
            }
        }

        private void CalculateIDFModel(List<Email> emails, int forHam) {
            IdfModel[forHam] = new double[termen[forHam].Count];
            for (int k = 0; k < termen[forHam].Count; k++) {
                double aantal = 0;
                for (int i = 0; i < emails.Count; i++) {
                    if (emails[i].VectorSpaceModel[forHam][k] != 0) {
                        aantal++;
                    }
                }
                IdfModel[forHam][k] = (aantal == 0 ? 0 : Math.Log10(emails.Count / aantal));
            }
        }

        private void CalculateTfIdfModel(List<Email> emails, int forHam) {
            for (int i = 0; i < emails.Count; i++) {
                for (int k = 0; k < termen[forHam].Count; k++) {
                    emails[i].VectorSpaceModel[forHam][k] *= IdfModel[forHam][k];
                }
            }
        }
    }
}
