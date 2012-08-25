using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using spamfilter.Overkoepelend;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;

namespace spamfilter.LogicalLayer {
    class Manager {
        private string termenHam = @"emails\termen\ham.txt";
        private string termenSpam = @"emails\termen\spam.txt";
        private string trainingHam = @"emails\training\ham";
        private string trainingSpam = @"emails\training\spam";
        private string testingHam = @"emails\testing\ham";
        private string testingSpam = @"emails\testing\spam";

        private TrainingsSet trainingSet;
        private Set testSet;

        public Set TestSet{
            get{
                return testSet;
            }
        }

        public Set TrainingSet {
            get {
                return trainingSet;
            }
        }

        public Manager() {
            trainingSet = new TrainingsSet(new string[] {termenHam, termenSpam});
            trainingSet.AddData(trainingHam, false);
            trainingSet.AddData(trainingSpam, true);

            trainingSet.MakeVectorSpaceModels();
            trainingSet.MakeInputsOutputs();

            testSet = new Set();
            testSet.AddData(testingHam, false);
            testSet.AddData(testingSpam, true);

            trainingSet.MakeVectorSpaceModels(testSet.Emails);
            testSet.MakeInputsOutputs();
        }

        public DecisionTree MakeDecisionTree() {
            DecisionTree tree = new DecisionTree(MakeAttributes(), 2);
            C45Learning c45 = new C45Learning(tree);
            c45.Run(trainingSet.Inputs, trainingSet.Outputs);
            return tree;
        }

        public DecisionVariable[] MakeAttributes() {
            DecisionVariable[] attributes = 
            {
                new DecisionVariable("ham", DecisionAttributeKind.Continuous),
                new DecisionVariable("spam", DecisionAttributeKind.Continuous),
            };
            return attributes;
        }

        public double[] GetVectorEmail(string fileName) {
            List<Email> list = new List<Email>();
            list.Add(new Email(fileName));
            trainingSet.MakeVectorSpaceModels(list);
            double[] temp = new double[2];
            temp[0] = list[0].GetSum(0);
            temp[1] = list[0].GetSum(1);
            return temp;
        }
    }
}
