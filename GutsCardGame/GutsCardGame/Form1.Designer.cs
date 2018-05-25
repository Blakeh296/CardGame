namespace GutsCardGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChoosePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoosePlayer
            // 
            this.btnChoosePlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChoosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoosePlayer.Location = new System.Drawing.Point(106, 117);
            this.btnChoosePlayer.Name = "btnChoosePlayer";
            this.btnChoosePlayer.Size = new System.Drawing.Size(142, 32);
            this.btnChoosePlayer.TabIndex = 0;
            this.btnChoosePlayer.Text = "Choose Player";
            this.btnChoosePlayer.UseVisualStyleBackColor = false;
            this.btnChoosePlayer.Click += new System.EventHandler(this.btnChoosePlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 156);
            this.Controls.Add(this.btnChoosePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePlayer;
    }
}

