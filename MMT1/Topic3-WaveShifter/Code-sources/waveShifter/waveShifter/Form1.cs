using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;
using waveShifter.WaveFile;
using System.Threading;

namespace waveShifter {
    public partial class Form1 : Form {
        private string pathData;
        private string FILEORIGINAL = "original.wav";
        private string FILECHANGED = "changed.wav";

        SoundPlayer player1;
        SoundPlayer player2;

        public Form1() {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            pathData = Path.GetFullPath("../../Data");
            //Debug.WriteLine("folder: " + Path.GetFullPath("../../Data"));
            //Debug.WriteLine("the folder: " + Directory.GetCurrentDirectory());
            //Debug.WriteLine("the folder: " + Environment.CurrentDirectory);
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            OpenFileDialog dialoog = new OpenFileDialog();

            dialoog.Multiselect = false;
            dialoog.Filter = "wav files (.wav)|*.wav";
            if (dialoog.ShowDialog() == DialogResult.OK) {
                //Debug.WriteLine("SafeFilename: " + dialoog.SafeFileName);
                //Debug.WriteLine("Filename: " + dialoog.FileName);
                File.Copy(dialoog.FileName, Path.Combine(pathData, FILEORIGINAL), true);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e) {
            SaveFileDialog dialoog = new SaveFileDialog();

            dialoog.Filter = "wav files (.wav)|*.wav";

            if (dialoog.ShowDialog() == DialogResult.OK) {
                string changedfile = Path.Combine(pathData, FILECHANGED);
                if (File.Exists(changedfile)) {
                    File.Copy(changedfile, dialoog.FileName);
                }
            }
        }

        private void btnStartPlayer1_Click(object sender, EventArgs e) {
            string originalFile = Path.Combine(pathData, FILEORIGINAL);
            if (File.Exists(originalFile)) {
                player1 = new SoundPlayer();
                player1.SoundLocation = originalFile;
                player1.PlayLooping();
            }
        }

        private void btnStopPlayer1_Click(object sender, EventArgs e) {
            if (player1 != null) {
                player1.Stop();
            }
        }

        private void btnStartPlayer2_Click(object sender, EventArgs e) {

            string changedFile = Path.Combine(pathData, FILECHANGED);
            if (File.Exists(changedFile)) {
                player2 = new SoundPlayer();
                player2.SoundLocation = changedFile;
                player2.PlayLooping();
            }
        }

        private void btnStopPlayer2_Click(object sender, EventArgs e) {
            if (player2 != null) {
                player2.Stop();
            }
        }

        private void btnMakeChanged_Click(object sender, EventArgs e) {
            string originalFile = Path.Combine(pathData, FILEORIGINAL);
            string changedFile = Path.Combine(pathData, FILECHANGED);
            WaveFileShifter shifter = new WaveFileShifter(originalFile, changedFile, (int)(numericUpDownShiftedSeconds.Value*1000), new SolutionDelegate(Done), new IntDelegate(SetMaxProgressBar), new IntDelegate(UpdateProgressBar));
            Thread t = new Thread(new ThreadStart(shifter.ReadWaveFile));
            t.Start();
        }

        public void Done() {

        }

        public void SetMaxProgressBar(int max) {
            progressBar.Maximum = max;
        }

        public void UpdateProgressBar(int value) {
            progressBar.Value = value;
        }
    }
}
