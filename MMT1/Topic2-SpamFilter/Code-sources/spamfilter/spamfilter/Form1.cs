using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using spamfilter.LogicalLayer;
using ZedGraph;
using Accord.Math;
using Accord.MachineLearning.DecisionTrees;
using System.Diagnostics;
using Accord.Statistics.Analysis;

namespace spamfilter {
    public partial class Form1 : Form {
        DecisionTree tree;
        Manager manager;

        public Form1() {
            InitializeComponent();
            dgvPerformance.AutoGenerateColumns = false;
            groupBoxTestFile.Visible = false;

            manager = new Manager();
            tree = manager.MakeDecisionTree();
            decisionTreeViewDecisionTree.TreeSource = tree;

            FillDataGridView();
            CreateScatterplot(zedGraphControlData, manager.TrainingSet.Inputs);

            int[] output = new int[manager.TestSet.Inputs.Length];
            for (int i = 0; i < manager.TestSet.Inputs.Length; i++) {
                output[i] = tree.Compute(manager.TestSet.Inputs[i]);
            }

            ConfusionMatrix confusionMatrix = new ConfusionMatrix(output, manager.TestSet.Outputs, 1, 0);
            dgvPerformance.DataSource = new List<ConfusionMatrix> { confusionMatrix };

            foreach (DataGridViewColumn col in dgvPerformance.Columns)
                Debug.WriteLine(col.Name);
        }

        public void FillDataGridView() {
            dataGridViewTrainingData.ColumnCount = 3;
            dataGridViewTrainingData.Columns[0].Name = "Ham";
            dataGridViewTrainingData.Columns[0].Width = 75;
            dataGridViewTrainingData.Columns[1].Name = "Spam";
            dataGridViewTrainingData.Columns[1].Width = 75;
            dataGridViewTrainingData.Columns[2].Name = "Is Spam";
            dataGridViewTrainingData.Columns[2].Width = 55;
            for (int i = 0; i < manager.TrainingSet.Outputs.Length; i++) {
                string[] row = new string[] { "" + manager.TrainingSet.Inputs[i][0], "" + manager.TrainingSet.Inputs[i][1], "" + manager.TrainingSet.Outputs[i] };
                dataGridViewTrainingData.Rows.Add(row); 
            }
        }

        public void CreateScatterplot(ZedGraphControl zgc, double[][] data) {

            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = "ham";
            myPane.YAxis.Title.Text = "spam";


            // Classification problem
            PointPairList list1 = new PointPairList(); // Z = 0
            PointPairList list2 = new PointPairList(); // Z = 1
            for (int i = 0; i < manager.TrainingSet.Inputs.Length; i++) {
                if (manager.TrainingSet.Outputs[i] == 0)
                    list1.Add(data[i][0], data[i][1]);
                if (manager.TrainingSet.Outputs[i] == 1)
                    list2.Add(data[i][0], data[i][1]);
            }

            // Add the curve
            LineItem myCurve = myPane.AddCurve("ham", list1, Color.Blue, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Blue);

            myCurve = myPane.AddCurve("spam", list2, Color.Green, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);


            // Fill the background of the chart rect and pane
            //myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            //myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialoog = new OpenFileDialog();

            dialoog.InitialDirectory = System.IO.Path.GetFullPath(@"emails\");
            dialoog.Multiselect = false;
            dialoog.Filter = "text files (.txt)|*.txt";
            if (dialoog.ShowDialog() == DialogResult.OK) {
                groupBoxTestFile.Visible = true;
                lblPathTestedFile.Text = dialoog.FileName;
                bool isSpam = (tree.Compute(manager.GetVectorEmail(dialoog.FileName)) == 1 ? true : false);
                lblPredictionTestedEmail.Text = (isSpam ? "the file is Spam" : "the file is ham");
            }
        }
    }
}
