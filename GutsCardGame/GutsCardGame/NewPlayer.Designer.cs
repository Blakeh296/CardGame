namespace GutsCardGame
{
    partial class PlayerPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPicker));
            this.tbNewPlayer = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUnderline3 = new System.Windows.Forms.Label();
            this.lblAICount = new System.Windows.Forms.Label();
            this.lblUnderline2 = new System.Windows.Forms.Label();
            this.lblLabel3 = new System.Windows.Forms.Label();
            this.lblUnderline4 = new System.Windows.Forms.Label();
            this.lblLabel4 = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnReturningPlayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNewPlayer
            // 
            this.tbNewPlayer.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPlayer.ForeColor = System.Drawing.SystemColors.Window;
            this.tbNewPlayer.Location = new System.Drawing.Point(53, 21);
            this.tbNewPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPlayer.Name = "tbNewPlayer";
            this.tbNewPlayer.Size = new System.Drawing.Size(132, 26);
            this.tbNewPlayer.TabIndex = 0;
            this.tbNewPlayer.Visible = false;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPlayer.Location = new System.Drawing.Point(171, 21);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(112, 30);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = false;
            this.btnAddPlayer.Visible = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlay.Location = new System.Drawing.Point(138, 255);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(112, 30);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSlogan.Location = new System.Drawing.Point(47, 208);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(203, 34);
            this.lblSlogan.TabIndex = 6;
            this.lblSlogan.Text = "No guts, no glory.";
            this.lblSlogan.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(25, 148);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(225, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 2;
            this.trackBar1.Visible = false;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 39);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUnderline3
            // 
            this.lblUnderline3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnderline3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnderline3.Location = new System.Drawing.Point(221, 110);
            this.lblUnderline3.Name = "lblUnderline3";
            this.lblUnderline3.Size = new System.Drawing.Size(29, 31);
            this.lblUnderline3.TabIndex = 13;
            this.lblUnderline3.Visible = false;
            // 
            // lblAICount
            // 
            this.lblAICount.AutoSize = true;
            this.lblAICount.BackColor = System.Drawing.Color.Transparent;
            this.lblAICount.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAICount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAICount.Location = new System.Drawing.Point(220, 99);
            this.lblAICount.Name = "lblAICount";
            this.lblAICount.Size = new System.Drawing.Size(30, 36);
            this.lblAICount.TabIndex = 14;
            this.lblAICount.Text = "2";
            this.lblAICount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAICount.Visible = false;
            // 
            // lblUnderline2
            // 
            this.lblUnderline2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnderline2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnderline2.Location = new System.Drawing.Point(64, 110);
            this.lblUnderline2.Name = "lblUnderline2";
            this.lblUnderline2.Size = new System.Drawing.Size(146, 25);
            this.lblUnderline2.TabIndex = 15;
            this.lblUnderline2.Visible = false;
            // 
            // lblLabel3
            // 
            this.lblLabel3.AutoSize = true;
            this.lblLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLabel3.Location = new System.Drawing.Point(64, 98);
            this.lblLabel3.Name = "lblLabel3";
            this.lblLabel3.Size = new System.Drawing.Size(146, 29);
            this.lblLabel3.TabIndex = 16;
            this.lblLabel3.Text = "Number of AI :";
            this.lblLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLabel3.Visible = false;
            // 
            // lblUnderline4
            // 
            this.lblUnderline4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnderline4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnderline4.Location = new System.Drawing.Point(54, 24);
            this.lblUnderline4.Name = "lblUnderline4";
            this.lblUnderline4.Size = new System.Drawing.Size(172, 23);
            this.lblUnderline4.TabIndex = 17;
            this.lblUnderline4.Visible = false;
            // 
            // lblLabel4
            // 
            this.lblLabel4.AutoSize = true;
            this.lblLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLabel4.Location = new System.Drawing.Point(54, 9);
            this.lblLabel4.Name = "lblLabel4";
            this.lblLabel4.Size = new System.Drawing.Size(177, 29);
            this.lblLabel4.TabIndex = 18;
            this.lblLabel4.Text = "Choose A Player :";
            this.lblLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLabel4.Visible = false;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewPlayer.Location = new System.Drawing.Point(12, 26);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(112, 30);
            this.btnNewPlayer.TabIndex = 25;
            this.btnNewPlayer.Text = "New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnReturningPlayer
            // 
            this.btnReturningPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturningPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturningPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturningPlayer.Location = new System.Drawing.Point(141, 26);
            this.btnReturningPlayer.Name = "btnReturningPlayer";
            this.btnReturningPlayer.Size = new System.Drawing.Size(163, 30);
            this.btnReturningPlayer.TabIndex = 26;
            this.btnReturningPlayer.Text = "Returning Player";
            this.btnReturningPlayer.UseVisualStyleBackColor = false;
            this.btnReturningPlayer.Click += new System.EventHandler(this.btnReturningPlayer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // PlayerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(405, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturningPlayer);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.lblLabel4);
            this.Controls.Add(this.lblUnderline4);
            this.Controls.Add(this.lblLabel3);
            this.Controls.Add(this.lblUnderline2);
            this.Controls.Add(this.lblAICount);
            this.Controls.Add(this.lblUnderline3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.tbNewPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPlayer";
            this.Load += new System.EventHandler(this.NewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUnderline3;
        private System.Windows.Forms.Label lblAICount;
        private System.Windows.Forms.Label lblUnderline2;
        private System.Windows.Forms.Label lblLabel3;
        private System.Windows.Forms.Label lblUnderline4;
        private System.Windows.Forms.Label lblLabel4;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnReturningPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}