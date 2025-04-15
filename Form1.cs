using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Speech.Recognition;
using System.Text;
using System.Windows.Forms;

namespace VoiceToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectMp3BT_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string mp3Path = openFileDialog.FileName;
                    string outputDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output");
                    if (!Directory.Exists(outputDir))
                        Directory.CreateDirectory(outputDir);

                    string wavPath = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(mp3Path) + ".wav");

                    try
                    {
                        ConvertMp3ToWav(mp3Path, wavPath);
                        string recognizedText = RecognizeSpeechFromWav(wavPath);
                        richTextBox1.Text = recognizedText;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void ConvertMp3ToWav(string mp3Path, string wavPath)
        {
             var reader = new Mp3FileReader(mp3Path);
             var pcm = WaveFormatConversionStream.CreatePcmStream(reader);
            WaveFileWriter.CreateWaveFile(wavPath, pcm);
        }

        private string RecognizeSpeechFromWav(string wavPath)
        {
            StringBuilder sb = new StringBuilder();

            var recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            recognizer.SetInputToWaveFile(wavPath);
            recognizer.LoadGrammar(new DictationGrammar());

            RecognitionResult result = recognizer.Recognize();
            if (result != null)
                sb.AppendLine(result.Text);
            else
                sb.AppendLine("[Hiçbir şey algılanamadı]");

            return sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Ses dosyası";
            label1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label1.Location = new Point(20, 20);
            label1.Size = new Size(300, 30);

            selectMp3BT.Text = "Select MP3 File";
            selectMp3BT.Location = new Point(20, 60);
            selectMp3BT.Size = new Size(150, 35);

            label2.Text = "Text:";
            label2.Location = new Point(20, 110);
            label2.Size = new Size(200, 20);

            richTextBox1.Location = new Point(20, 140);
            richTextBox1.Size = new Size(500, 250);
            richTextBox1.Font = new Font("Segoe UI", 10);
        }
        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
