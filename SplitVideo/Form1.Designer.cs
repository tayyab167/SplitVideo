namespace SplitVideo
{
    partial class Enter_Video
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_Video));
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.Patch_Split_Time = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.txtOutPutDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.btnChoseValue = new System.Windows.Forms.Button();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConvertAndJoin = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(318, 122);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.ReadOnly = true;
            this.txtVideoPath.Size = new System.Drawing.Size(276, 21);
            this.txtVideoPath.TabIndex = 0;
            this.txtVideoPath.Text = "\r\n";
            // 
            // Patch_Split_Time
            // 
            this.Patch_Split_Time.AutoSize = true;
            this.Patch_Split_Time.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patch_Split_Time.Location = new System.Drawing.Point(154, 237);
            this.Patch_Split_Time.Name = "Patch_Split_Time";
            this.Patch_Split_Time.Size = new System.Drawing.Size(142, 21);
            this.Patch_Split_Time.TabIndex = 11;
            this.Patch_Split_Time.Text = "Patch Split Time :";
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.LightYellow;
            this.Convert.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(158, 324);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(138, 35);
            this.Convert.TabIndex = 5;
            this.Convert.Text = "Split Video";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.ConvertAndJoin_Click);
            // 
            // txtOutPutDirectory
            // 
            this.txtOutPutDirectory.Location = new System.Drawing.Point(318, 178);
            this.txtOutPutDirectory.Name = "txtOutPutDirectory";
            this.txtOutPutDirectory.ReadOnly = true;
            this.txtOutPutDirectory.Size = new System.Drawing.Size(276, 21);
            this.txtOutPutDirectory.TabIndex = 1;
            this.txtOutPutDirectory.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seconds";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(318, 237);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(85, 21);
            this.Hours.TabIndex = 2;
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(420, 237);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(77, 21);
            this.Minutes.TabIndex = 3;
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(518, 237);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(76, 21);
            this.Seconds.TabIndex = 4;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // btnChoseValue
            // 
            this.btnChoseValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoseValue.Location = new System.Drawing.Point(158, 119);
            this.btnChoseValue.Name = "btnChoseValue";
            this.btnChoseValue.Size = new System.Drawing.Size(154, 26);
            this.btnChoseValue.TabIndex = 9;
            this.btnChoseValue.Text = "Select Video Path";
            this.btnChoseValue.UseVisualStyleBackColor = true;
            this.btnChoseValue.Click += new System.EventHandler(this.btnChoseValue_Click);
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputDirectory.Location = new System.Drawing.Point(158, 175);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(154, 27);
            this.btnOutputDirectory.TabIndex = 10;
            this.btnOutputDirectory.Text = "Select Output Directory";
            this.btnOutputDirectory.UseVisualStyleBackColor = true;
            this.btnOutputDirectory.Click += new System.EventHandler(this.btnOutputDirectory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Video Software";
            // 
            // ConvertAndJoin
            // 
            this.ConvertAndJoin.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ConvertAndJoin.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertAndJoin.Location = new System.Drawing.Point(319, 324);
            this.ConvertAndJoin.Name = "ConvertAndJoin";
            this.ConvertAndJoin.Size = new System.Drawing.Size(130, 35);
            this.ConvertAndJoin.TabIndex = 6;
            this.ConvertAndJoin.Text = "Split and Join";
            this.ConvertAndJoin.UseVisualStyleBackColor = false;
            this.ConvertAndJoin.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(467, 324);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(127, 35);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(155, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please provide the time at which you\'d like to split or divide your video, either" +
    " in seconds or minutes.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SplitVideo.Properties.Resources.free_video_icon_818_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(287, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(228, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Please Wait Processing . . . ";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Crimson;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(692, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(36, 30);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enter_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(730, 443);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ConvertAndJoin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOutputDirectory);
            this.Controls.Add(this.btnChoseValue);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutPutDirectory);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Patch_Split_Time);
            this.Controls.Add(this.txtVideoPath);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enter_Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter_Video";
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.Label Patch_Split_Time;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox txtOutPutDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.NumericUpDown Seconds;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoseValue;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ConvertAndJoin;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancelButton;
    }
}

