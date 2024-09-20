namespace ffmpeg_client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            errorLabel = new Label();
            logs = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(549, 46);
            button1.Name = "button1";
            button1.Size = new Size(106, 38);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 4;
            label2.Text = "File";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "15";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(55, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "24";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(98, 32);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 19);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "30";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(141, 32);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(37, 19);
            radioButton4.TabIndex = 8;
            radioButton4.Text = "60";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(7, 38);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(43, 19);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "480";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(56, 38);
            radioButton6.Name = "radioButton6";
            radioButton6.RightToLeft = RightToLeft.No;
            radioButton6.Size = new Size(43, 19);
            radioButton6.TabIndex = 11;
            radioButton6.Text = "720";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(105, 38);
            radioButton7.Name = "radioButton7";
            radioButton7.RightToLeft = RightToLeft.No;
            radioButton7.Size = new Size(49, 19);
            radioButton7.TabIndex = 12;
            radioButton7.Text = "1080";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(160, 38);
            radioButton8.Name = "radioButton8";
            radioButton8.RightToLeft = RightToLeft.No;
            radioButton8.Size = new Size(38, 19);
            radioButton8.TabIndex = 13;
            radioButton8.Text = "4K";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(12, 412);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(514, 23);
            textBox2.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(549, 397);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 15;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(12, 445);
            button3.Name = "button3";
            button3.Size = new Size(106, 38);
            button3.TabIndex = 16;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 64);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "FPS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Location = new Point(218, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 64);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resolution";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 381);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 19;
            label1.Text = "Output Folder";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton10);
            groupBox3.Controls.Add(radioButton11);
            groupBox3.Location = new Point(424, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 64);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Format";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(62, 38);
            radioButton9.Name = "radioButton9";
            radioButton9.RightToLeft = RightToLeft.No;
            radioButton9.Size = new Size(48, 19);
            radioButton9.TabIndex = 11;
            radioButton9.Text = "mkv";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Checked = true;
            radioButton10.Location = new Point(7, 38);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(49, 19);
            radioButton10.TabIndex = 10;
            radioButton10.TabStop = true;
            radioButton10.Text = "mp4";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(116, 38);
            radioButton11.Name = "radioButton11";
            radioButton11.RightToLeft = RightToLeft.No;
            radioButton11.Size = new Size(40, 19);
            radioButton11.TabIndex = 12;
            radioButton11.Text = "avi";
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += radioButton11_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "MP4 (*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(140, 457);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 20;
            // 
            // logs
            // 
            logs.AutoSize = true;
            logs.Location = new Point(24, 211);
            logs.Name = "logs";
            logs.Size = new Size(41, 15);
            logs.TabIndex = 21;
            logs.Text = "Logs : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(834, 495);
            Controls.Add(logs);
            Controls.Add(errorLabel);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FFmpeg Client v1.0.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label errorLabel;
        private Label logs;
    }
}