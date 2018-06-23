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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUnderline4 = new System.Windows.Forms.Label();
            this.lblLabel4 = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnReturningPlayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // PlayerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GutsCardGame.Properties.Resources.cards_on_red_felt_poker_table_background;
            this.ClientSize = new System.Drawing.Size(405, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturningPlayer);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.lblLabel4);
            this.Controls.Add(this.lblUnderline4);
            this.Controls.Add(this.comboBox1);
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
            this.Text = "Pick a player";
            this.Load += new System.EventHandler(this.NewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUnderline4;
        private System.Windows.Forms.Label lblLabel4;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnReturningPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}