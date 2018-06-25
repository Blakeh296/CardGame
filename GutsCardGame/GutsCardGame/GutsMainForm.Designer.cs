namespace GutsCardGame
{
    partial class GutsMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GutsMainForm));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.pictureBoxCardStack = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerPickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepPlayingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areYouSureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbPlayer1Card1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer1Card2 = new System.Windows.Forms.PictureBox();
            this.pbOpponent1Card1 = new System.Windows.Forms.PictureBox();
            this.pbOpponent1Card2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AntePrice = new System.Windows.Forms.DomainUpDown();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lblWinLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnAnteUp = new System.Windows.Forms.Button();
            this.lblRoundCounter = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardStack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1Card2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer1.Location = new System.Drawing.Point(30, 27);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(92, 25);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player1";
            // 
            // pictureBoxCardStack
            // 
            this.pictureBoxCardStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCardStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCardStack.Image = global::GutsCardGame.Properties.Resources.RedCard_stack;
            this.pictureBoxCardStack.Location = new System.Drawing.Point(383, 351);
            this.pictureBoxCardStack.Name = "pictureBoxCardStack";
            this.pictureBoxCardStack.Size = new System.Drawing.Size(72, 70);
            this.pictureBoxCardStack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCardStack.TabIndex = 10;
            this.pictureBoxCardStack.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2_Clubs.bmp");
            this.imageList1.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(2, "2_Hearts.bmp");
            this.imageList1.Images.SetKeyName(3, "2_Spades.bmp");
            this.imageList1.Images.SetKeyName(4, "3_Clubs.bmp");
            this.imageList1.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(6, "3_Hearts.bmp");
            this.imageList1.Images.SetKeyName(7, "3_Spades.bmp");
            this.imageList1.Images.SetKeyName(8, "4_Clubs.bmp");
            this.imageList1.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(10, "4_Hearts.bmp");
            this.imageList1.Images.SetKeyName(11, "4_Spades.bmp");
            this.imageList1.Images.SetKeyName(12, "5_Clubs.bmp");
            this.imageList1.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(14, "5_Hearts.bmp");
            this.imageList1.Images.SetKeyName(15, "5_Spades.bmp");
            this.imageList1.Images.SetKeyName(16, "6_Clubs.bmp");
            this.imageList1.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(18, "6_Hearts.bmp");
            this.imageList1.Images.SetKeyName(19, "6_Spades.bmp");
            this.imageList1.Images.SetKeyName(20, "7_Clubs.bmp");
            this.imageList1.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(22, "7_Hearts.bmp");
            this.imageList1.Images.SetKeyName(23, "7_Spades.bmp");
            this.imageList1.Images.SetKeyName(24, "8_Clubs.bmp");
            this.imageList1.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(26, "8_Hearts.bmp");
            this.imageList1.Images.SetKeyName(27, "8_Spades.bmp");
            this.imageList1.Images.SetKeyName(28, "9_Clubs.bmp");
            this.imageList1.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(30, "9_Hearts.bmp");
            this.imageList1.Images.SetKeyName(31, "9_Spades.bmp");
            this.imageList1.Images.SetKeyName(32, "10_Clubs.bmp");
            this.imageList1.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(34, "10_Hearts.bmp");
            this.imageList1.Images.SetKeyName(35, "10_Spades.bmp");
            this.imageList1.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.imageList1.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.imageList1.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.imageList1.Images.SetKeyName(40, "Backface_Blue.bmp");
            this.imageList1.Images.SetKeyName(41, "Backface_Red.bmp");
            this.imageList1.Images.SetKeyName(42, "Jack_Clubs.bmp");
            this.imageList1.Images.SetKeyName(43, "Jack_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(44, "Jack_Hearts.bmp");
            this.imageList1.Images.SetKeyName(45, "Jack_Spades.bmp");
            this.imageList1.Images.SetKeyName(46, "Joker_Black.bmp");
            this.imageList1.Images.SetKeyName(47, "Joker_Red.bmp");
            this.imageList1.Images.SetKeyName(48, "King_Clubs.bmp");
            this.imageList1.Images.SetKeyName(49, "King_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(50, "King_Hearts.bmp");
            this.imageList1.Images.SetKeyName(51, "King_Spades.bmp");
            this.imageList1.Images.SetKeyName(52, "Queen_Clubs.bmp");
            this.imageList1.Images.SetKeyName(53, "Queen_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(54, "Queen_Hearts.bmp");
            this.imageList1.Images.SetKeyName(55, "Queen_Spades.bmp");
            this.imageList1.Images.SetKeyName(56, "RedCard_stack.bmp");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerPickerToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerPickerToolStripMenuItem
            // 
            this.playerPickerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem});
            this.playerPickerToolStripMenuItem.Name = "playerPickerToolStripMenuItem";
            this.playerPickerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.playerPickerToolStripMenuItem.Text = "Player &Picker";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.goToolStripMenuItem.Text = "&Go";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.exitToolStripMenuItem.Text = "&Game Options";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesRestartToolStripMenuItem,
            this.keepPlayingToolStripMenuItem});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            // 
            // yesRestartToolStripMenuItem
            // 
            this.yesRestartToolStripMenuItem.Name = "yesRestartToolStripMenuItem";
            this.yesRestartToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.yesRestartToolStripMenuItem.Text = "&Confirm";
            this.yesRestartToolStripMenuItem.Click += new System.EventHandler(this.yesRestartToolStripMenuItem_Click);
            // 
            // keepPlayingToolStripMenuItem
            // 
            this.keepPlayingToolStripMenuItem.Name = "keepPlayingToolStripMenuItem";
            this.keepPlayingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.keepPlayingToolStripMenuItem.Text = "&Keep Playing";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAllToolStripMenuItem});
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "&Exit";
            // 
            // exitAllToolStripMenuItem
            // 
            this.exitAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areYouSureToolStripMenuItem});
            this.exitAllToolStripMenuItem.Name = "exitAllToolStripMenuItem";
            this.exitAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitAllToolStripMenuItem.Text = "&Close All";
            // 
            // areYouSureToolStripMenuItem
            // 
            this.areYouSureToolStripMenuItem.Name = "areYouSureToolStripMenuItem";
            this.areYouSureToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.areYouSureToolStripMenuItem.Text = "&Yes";
            this.areYouSureToolStripMenuItem.Click += new System.EventHandler(this.areYouSureToolStripMenuItem_Click);
            // 
            // pbPlayer1Card1
            // 
            this.pbPlayer1Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer1Card1.Location = new System.Drawing.Point(109, 66);
            this.pbPlayer1Card1.Name = "pbPlayer1Card1";
            this.pbPlayer1Card1.Size = new System.Drawing.Size(75, 91);
            this.pbPlayer1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1Card1.TabIndex = 16;
            this.pbPlayer1Card1.TabStop = false;
            // 
            // pbPlayer1Card2
            // 
            this.pbPlayer1Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer1Card2.Location = new System.Drawing.Point(190, 66);
            this.pbPlayer1Card2.Name = "pbPlayer1Card2";
            this.pbPlayer1Card2.Size = new System.Drawing.Size(72, 91);
            this.pbPlayer1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1Card2.TabIndex = 17;
            this.pbPlayer1Card2.TabStop = false;
            // 
            // pbOpponent1Card1
            // 
            this.pbOpponent1Card1.Location = new System.Drawing.Point(121, 76);
            this.pbOpponent1Card1.Name = "pbOpponent1Card1";
            this.pbOpponent1Card1.Size = new System.Drawing.Size(64, 94);
            this.pbOpponent1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpponent1Card1.TabIndex = 18;
            this.pbOpponent1Card1.TabStop = false;
            // 
            // pbOpponent1Card2
            // 
            this.pbOpponent1Card2.Location = new System.Drawing.Point(205, 76);
            this.pbOpponent1Card2.Name = "pbOpponent1Card2";
            this.pbOpponent1Card2.Size = new System.Drawing.Size(64, 94);
            this.pbOpponent1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpponent1Card2.TabIndex = 19;
            this.pbOpponent1Card2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(139, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ante :";
            // 
            // AntePrice
            // 
            this.AntePrice.BackColor = System.Drawing.SystemColors.MenuText;
            this.AntePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntePrice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.AntePrice.Items.Add("500");
            this.AntePrice.Items.Add("450");
            this.AntePrice.Items.Add("400");
            this.AntePrice.Items.Add("350");
            this.AntePrice.Items.Add("300");
            this.AntePrice.Items.Add("250");
            this.AntePrice.Items.Add("225");
            this.AntePrice.Items.Add("200");
            this.AntePrice.Items.Add("190");
            this.AntePrice.Items.Add("180");
            this.AntePrice.Items.Add("170");
            this.AntePrice.Items.Add("160");
            this.AntePrice.Items.Add("150");
            this.AntePrice.Items.Add("140");
            this.AntePrice.Items.Add("130");
            this.AntePrice.Items.Add("120");
            this.AntePrice.Items.Add("110");
            this.AntePrice.Items.Add("100");
            this.AntePrice.Items.Add("90");
            this.AntePrice.Items.Add("80");
            this.AntePrice.Items.Add("70");
            this.AntePrice.Items.Add("60");
            this.AntePrice.Items.Add("50");
            this.AntePrice.Items.Add("40");
            this.AntePrice.Items.Add("30");
            this.AntePrice.Items.Add("20");
            this.AntePrice.Items.Add("10");
            this.AntePrice.Items.Add("5");
            this.AntePrice.Location = new System.Drawing.Point(214, 301);
            this.AntePrice.Name = "AntePrice";
            this.AntePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AntePrice.Size = new System.Drawing.Size(120, 29);
            this.AntePrice.TabIndex = 23;
            this.AntePrice.Text = "100";
            // 
            // btnShuffle
            // 
            this.btnShuffle.AutoSize = true;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(489, 367);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(137, 36);
            this.btnShuffle.TabIndex = 35;
            this.btnShuffle.Text = "Deal Cards";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lblWinLabel
            // 
            this.lblWinLabel.AutoSize = true;
            this.lblWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLabel.ForeColor = System.Drawing.Color.Gold;
            this.lblWinLabel.Location = new System.Drawing.Point(271, 42);
            this.lblWinLabel.Name = "lblWinLabel";
            this.lblWinLabel.Size = new System.Drawing.Size(0, 25);
            this.lblWinLabel.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPlayer1Card1);
            this.groupBox1.Controls.Add(this.pbPlayer1Card2);
            this.groupBox1.Controls.Add(this.lblPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(24, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 205);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPlayer2);
            this.groupBox3.Controls.Add(this.pbOpponent1Card1);
            this.groupBox3.Controls.Add(this.pbOpponent1Card2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(441, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 205);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opponent";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer2.Location = new System.Drawing.Point(48, 39);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(76, 25);
            this.lblPlayer2.TabIndex = 39;
            this.lblPlayer2.Text = "label2";
            // 
            // btnAnteUp
            // 
            this.btnAnteUp.AutoSize = true;
            this.btnAnteUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteUp.Location = new System.Drawing.Point(349, 298);
            this.btnAnteUp.Name = "btnAnteUp";
            this.btnAnteUp.Size = new System.Drawing.Size(137, 36);
            this.btnAnteUp.TabIndex = 39;
            this.btnAnteUp.Text = "Ante Up";
            this.btnAnteUp.UseVisualStyleBackColor = true;
            this.btnAnteUp.Click += new System.EventHandler(this.btnAnteUp_Click);
            // 
            // lblRoundCounter
            // 
            this.lblRoundCounter.AutoSize = true;
            this.lblRoundCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCounter.ForeColor = System.Drawing.Color.Gold;
            this.lblRoundCounter.Location = new System.Drawing.Point(24, 42);
            this.lblRoundCounter.Name = "lblRoundCounter";
            this.lblRoundCounter.Size = new System.Drawing.Size(0, 25);
            this.lblRoundCounter.TabIndex = 40;
            // 
            // btnPass
            // 
            this.btnPass.AutoSize = true;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(494, 298);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(137, 36);
            this.btnPass.TabIndex = 41;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // GutsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 436);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblRoundCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnteUp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblWinLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AntePrice);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.pictureBoxCardStack);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GutsMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Guts";
            this.Load += new System.EventHandler(this.GutsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardStack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1Card2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxCardStack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbPlayer1Card1;
        private System.Windows.Forms.PictureBox pbPlayer1Card2;
        private System.Windows.Forms.PictureBox pbOpponent1Card1;
        private System.Windows.Forms.PictureBox pbOpponent1Card2;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepPlayingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.DomainUpDown AntePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ToolStripMenuItem playerPickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.Label lblWinLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnAnteUp;
        private System.Windows.Forms.Label lblRoundCounter;
        private System.Windows.Forms.Button btnPass;
    }
}