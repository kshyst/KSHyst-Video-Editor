namespace ffmpeg_client
{
    public partial class Form1 : Form
    {
        private String fileLocation;
        private String outputLocation;
        private String outputFormat;
        private String outputFPS;
        private String outputResolution;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            fileLocation = openFileDialog1.FileName;
        }
    }
}