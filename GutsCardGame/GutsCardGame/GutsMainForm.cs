using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GutsCardGame
{
    public partial class GutsMainForm : Form
    {
        public int aI;
        public string player1, player2, player3, player4, player5, player6, player7, player8, player9, player10;

        public GutsMainForm()
        {
            InitializeComponent();
        }

        public int opponentleftpos = 175;
        public int opponenttoppos = 275;
        public int leftpos = 50;
        public int toppos = 450;
        public int CardLocation = 0;
        public int i = 0;
        public int x = 0;

        private void GutsMainForm_Load(object sender, EventArgs e)
        {

            while (i < 26)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, 51);
                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(50, 70);

                newCard.Location = new Point(opponentleftpos, opponenttoppos);
                newCard.Image = imageList1.Images[Cardpick];
                this.Controls.Add(newCard);
                newCard.BringToFront();
                opponentleftpos = (opponentleftpos + 10);
                i++;
            }



            while (x < 26)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, 51);
                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(50, 70);
                newCard.BackgroundImage = imageList1.Images[Cardpick];
                newCard.BackgroundImageLayout = ImageLayout.Stretch;
                newCard.Location = new Point(leftpos, toppos);


                this.Controls.Add(newCard);
                newCard.BringToFront();
                leftpos = (leftpos + 20);
                x++;
            }

            // forms first size 504, 392

            this.Size = new Size(504, 392);

            double startMoney = 5000;

            lblPlayer3.Visible = false;
            lblPlayer4.Visible = false;
            lblPlayer5.Visible = false;
            lblPlayer6.Visible = false;
            lblPlayer7.Visible = false;
            lblPlayer8.Visible = false;
            lblPlayer9.Visible = false;
            lblPlayer10.Visible = false;

            lblPlayer1.Text = player1 + " : " + startMoney.ToString("c");
            //lblPlayer2.Text = aI.ToString();

            if (aI == 2)
            {
                lblPlayer3.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");
            }
            else if (aI == 3)
            {
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");
                lblPlayer4.Text = "AI 3 " + startMoney.ToString("c");
            }
            else if (aI == 4)
            {
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");
                lblPlayer4.Text = "AI 3 " + startMoney.ToString("c");
                lblPlayer5.Text = "AI 4 " + startMoney.ToString("c");
            }
            else if (aI == 5)
            {
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;
                lblPlayer5.Visible = true;
                lblPlayer6.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");
                lblPlayer4.Text = "AI 3 " + startMoney.ToString("c");
                lblPlayer5.Text = "AI 4 " + startMoney.ToString("c");
                lblPlayer6.Text = "AI 5 " + startMoney.ToString("c");
            }

        }
    }
}
