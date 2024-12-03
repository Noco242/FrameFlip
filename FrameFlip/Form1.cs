using System;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Tiff;
using Image = SixLabors.ImageSharp.Image;

namespace FrameFlip
{
    public partial class Form_FrameFlip : Form
    {
        public Form_FrameFlip()
        {
            InitializeComponent();
        }

        private void Form_FrameFlip_Load(object sender, EventArgs e)
        {
            // Initialisiere die ComboBox-Elemente beim Laden des Formulars
            comboBox1.Items.AddRange(new string[] { "PNG", "JPEG", "BMP", "GIF", "TIFF" });
            comboBox1.SelectedIndex = 0;  // Setze eine Standardauswahl
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff",
                Title = "Bild auswählen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputPath.Text = openFileDialog.FileName;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string inputPath = textBoxInputPath.Text;

            if (string.IsNullOrEmpty(inputPath))
            {
                MessageBox.Show("Bitte wählen Sie einen Eingangspfad.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Zielformat.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filter = "";
            string extension = "";
            switch (comboBox1.SelectedItem.ToString())
            {
                case "PNG":
                    filter = "PNG|*.png";
                    extension = ".png";
                    break;
                case "JPEG":
                    filter = "JPEG|*.jpg";
                    extension = ".jpg";
                    break;
                case "BMP":
                    filter = "BMP|*.bmp";
                    extension = ".bmp";
                    break;
                case "GIF":
                    filter = "GIF|*.gif";
                    extension = ".gif";
                    break;
                case "TIFF":
                    filter = "TIFF|*.tiff";
                    extension = ".tiff";
                    break;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                Title = "Bild speichern",
                DefaultExt = extension
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                try
                {
                    using (Image image = Image.Load(inputPath))
                    {
                        IImageEncoder encoder = null;
                        switch (comboBox1.SelectedItem.ToString())
                        {
                            case "PNG":
                                encoder = new PngEncoder();
                                break;
                            case "JPEG":
                                encoder = new JpegEncoder();
                                break;
                            case "BMP":
                                encoder = new BmpEncoder();
                                break;
                            case "GIF":
                                encoder = new GifEncoder();
                                break;
                            case "TIFF":
                                encoder = new TiffEncoder();
                                break;
                        }

                        image.Save(outputPath, encoder);
                        MessageBox.Show("Bild erfolgreich konvertiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Konvertieren des Bildes: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
