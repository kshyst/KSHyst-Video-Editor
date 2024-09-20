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
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label3 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
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
            textBox1.Location = new Point(12, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 3;
            label1.Text = "FPS";
            label1.Click += label1_Click;
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
            radioButton1.Location = new Point(19, 131);
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
            radioButton2.Location = new Point(62, 131);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(37, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "24";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(105, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "30";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(148, 131);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(37, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "60";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(273, 100);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 9;
            label3.Text = "Resolution";
            label3.Click += label3_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(273, 131);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(43, 19);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "480";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(322, 131);
            radioButton6.Name = "radioButton6";
            radioButton6.RightToLeft = RightToLeft.No;
            radioButton6.Size = new Size(43, 19);
            radioButton6.TabIndex = 11;
            radioButton6.TabStop = true;
            radioButton6.Text = "720";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(371, 131);
            radioButton7.Name = "radioButton7";
            radioButton7.RightToLeft = RightToLeft.No;
            radioButton7.Size = new Size(49, 19);
            radioButton7.TabIndex = 12;
            radioButton7.TabStop = true;
            radioButton7.Text = "1080";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(426, 131);
            radioButton8.Name = "radioButton8";
            radioButton8.RightToLeft = RightToLeft.No;
            radioButton8.Size = new Size(38, 19);
            radioButton8.TabIndex = 13;
            radioButton8.TabStop = true;
            radioButton8.Text = "4K";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 460);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(514, 23);
            textBox2.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(549, 451);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 15;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(682, 451);
            button3.Name = "button3";
            button3.Size = new Size(106, 38);
            button3.TabIndex = 16;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(834, 495);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(label3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}