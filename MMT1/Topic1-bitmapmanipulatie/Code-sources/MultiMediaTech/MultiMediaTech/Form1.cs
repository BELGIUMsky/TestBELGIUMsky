using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MultiMediaTech {
    public partial class Form1 : Form {
        Bitmap bitmap;
        string fileName = "";

        int factorRood = 0, factorGroen = 0, factorBlauw = 0;
        
        public Form1() {
            InitializeComponent();

            // in het begin deze dingen disabelen
            splitContainer1.Panel1.Enabled = false;
            opslaanToolStripMenuItem.Enabled = false;
            invertToolStripMenuItem.Enabled = false;
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e) {
            // openfiledialoog
            OpenFileDialog openFileDialoog = new OpenFileDialog();

            // instellingen filedialoog met de 3 keuzes
            openFileDialoog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp;*.jpg";
            openFileDialoog.FilterIndex = 2; // de meestgebruikte aangeduid
            openFileDialoog.RestoreDirectory = true;

            // als de dialoog in orde is kan er voort gedaan worden
            if (DialogResult.OK == openFileDialoog.ShowDialog()) {
                fileName = openFileDialoog.FileName;
                bitmap = (Bitmap)Bitmap.FromFile(fileName, false);      // bitmap inladen
                picBoxBitmap.Image = bitmap;                // de foto inladen in de picturebox

                // nu dat er een foto ingesteld is mogen deze dingen enabeled worden
                splitContainer1.Panel1.Enabled = true;
                opslaanToolStripMenuItem.Enabled = true;
                invertToolStripMenuItem.Enabled = true;

                progressBar.Value = progressBar.Maximum;
            }
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e) {
            //savefiledialog
            SaveFileDialog saveFileDialoog = new SaveFileDialog();

            // instellingen saveFileDialoog
            saveFileDialoog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp;*.jpg";
            saveFileDialoog.FilterIndex = 2;
            saveFileDialoog.RestoreDirectory = true;

            // als het dialoog in orde is kan je de bitmap opslaan
            if (DialogResult.OK == saveFileDialoog.ShowDialog()) {
                bitmap.Save(saveFileDialoog.FileName);
            }
        }

        // ik heb lbl om de waarde van de trackbar op te slaan dus laat ik als de waarde veranderd dit uitvoeren
        private void trackBarRood_ValueChanged(object sender, EventArgs e) {
            factorRood = trackBarRood.Value;
            lblRoodWaarde.Text = factorRood.ToString();
        }

        private void trackBarGroen_ValueChanged(object sender, EventArgs e) {
            factorGroen = trackBarGroen.Value;
            lblGroenWaarde.Text = factorGroen.ToString();
        }

        private void trackBarBlauw_ValueChanged(object sender, EventArgs e) {
            factorBlauw = trackBarBlauw.Value;
            lblBlauwWaarde.Text = factorBlauw.ToString();
        }

        // ik laat de kleurfilter methode opgeroepen worden als er op toepassen gedrukt wordt
        private void btnToepassen_Click(object sender, EventArgs e) {
            ColorFilter();
        }

        // deze methode is voor het veranderen van de kleur ballans
        public void ColorFilter() {

            // ik heb een vooruitgangs bar gebruikt om de vooruitgang van het filteren weer te geven
            progressBar.Maximum = bitmap.Width;
            progressBar.Value = 0;

            // ik begin van een nieuwe bitmap
            bitmap = (Bitmap)Bitmap.FromFile(fileName, false);

            // als alle trackbars op 0 staan dan kunnen we het veranderen van de bitmap overslaan
            if (!(factorRood == 0 && factorGroen == 0 && factorBlauw == 0)) {

                // we moeten alle pixels kunnen veranderen dus 2 for lussen:
                    // een voor de breedte
                    // en een voor de lengte
                for (int x = 0; x < bitmap.Width; x++) {
                    for (int y = 0; y < bitmap.Height; y++) {

                        // haal de kleur van de pixel
                        Color colorPixel = bitmap.GetPixel(x, y);

                        // hier maak ik 3 variabelen 1 voor elke kleur uit rgb
                            // met elk direct de waarde van hun kleur in de pixel
                        int kleurR = colorPixel.R, kleurG = colorPixel.G, kleurB = colorPixel.B;

                        // ik check eerst of de waarde 0 is dan kan dit overgeslagen worden         deze uitleg is voor elk van de kleuren
                        if (factorRood != 0) {

                            // als kleinder dan 0 dan deel ik
                            // als groter dan 0 dan vermeenigvuldig ik
                            kleurR = (factorRood < 0 ? (kleurR / (factorRood * (-1)) + 1) : kleurR * (factorRood + 1));

                            // als groter dan 255 dan maak ik de waarde kleur 255 anders behoud ik de waarde
                            kleurR = (kleurR > 255 ? 255 : kleurR);
                        }
                        if (factorGroen != 0) {
                            kleurG = (factorGroen < 0 ? (kleurG / (factorGroen * (-1) + 1)) : kleurG * (factorGroen + 1));
                            kleurG = (kleurG > 255 ? 255 : kleurG);
                        }
                        if (factorBlauw != 0) {
                            kleurB = (factorBlauw < 0 ? (kleurB / (factorBlauw * (-1) + 1)) : kleurB * (factorBlauw + 1));
                            kleurB = (kleurB > 255 ? 255 : kleurB);
                        }

                        // hier maak ik de kleur terug aan
                        colorPixel = Color.FromArgb(kleurR, kleurG, kleurB);
                        // en hier word de pixel terug gezet
                        bitmap.SetPixel(x, y, colorPixel);
                    }
                    // de progressbar verhogen
                    progressBar.Value++;
                }
            }
            progressBar.Value = progressBar.Maximum;
            // de bitmap in de picturebox laden
            picBoxBitmap.Image = bitmap;
        }

        private void btnInvert_Click(object sender, EventArgs e) {

            // terug de vooruitgangs bar instellen
            progressBar.Maximum = bitmap.Width;
            progressBar.Value = 0;

            // met nieuwe bitmap beginnen
            bitmap = (Bitmap)Bitmap.FromFile(fileName, false);

            // en terug zelfde uitleg als bij de kleurfilter
            for (int x = 0; x < bitmap.Width; x++) {
                for (int y = 0; y < bitmap.Height; y++) {
                    Color colorPixel = bitmap.GetPixel(x, y);
                    colorPixel = Color.FromArgb(255 - colorPixel.R, 255 - colorPixel.G, 255 - colorPixel.B);
                    bitmap.SetPixel(x, y, colorPixel);
                }
                progressBar.Value++;
            }
            picBoxBitmap.Image = bitmap;
        }
    }
}
