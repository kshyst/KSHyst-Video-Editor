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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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
        }
    }
}