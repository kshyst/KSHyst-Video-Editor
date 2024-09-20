namespace ffmpeg_client
{
    public partial class Form1 : Form
    {
        private String fileLocation;
        private String outputLocation;
        private String outputFormat = "mp4";
        private String outputFPS = "15";
        private String outputResolution = "480";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath != null)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
                outputLocation = folderBrowserDialog1.SelectedPath;
            }
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            fileLocation = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please select a file to convert");
                return;
            }

            if (outputLocation == null)
            {
                MessageBox.Show("Please select an output location");
                return;
            }

            string command = CommandLineCreator.CreateCommand(fileLocation, outputLocation, outputFormat, outputFPS, outputResolution);
            CommandLineCreator.RunCommand(command);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            outputFPS = "15";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            outputFPS = "24";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            outputFPS = "30";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            outputFPS = "60";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            outputResolution = "480";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            outputResolution = "720";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            outputResolution = "1080";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            outputResolution = "2160";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat = "mp4";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat = "mkv";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat = "avi";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            outputFormat = "gif";
        }
    }
}