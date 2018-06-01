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
        public string[] PlayerNames = new string[20];
        public string[] PlayerCards = new string[2];
        public string[] OpponentCards = new string[2];
        public int aI;
        public int gameCounter = 0;     // to count what round youre on
        public string player1Score;
        public string player1, player2, player3, player4, player5, player6, player7, player8, player9, player10;

        Player var = new Player("bill");

        public GutsMainForm()
        {
            InitializeComponent();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playerSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create access to the new player form
            NewPlayer SelectPlayer = new NewPlayer();
            this.Hide();                    // Hide this form
            SelectPlayer.ShowDialog();          // Show form
            this.Close();                   // Dispose of current form
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
            var.PlayerName = "fill";

            while (i < 2)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, imageList1.Images.Count);
                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(50, 70);

                newCard.Location = new Point(opponentleftpos, opponenttoppos);
                newCard.Image = imageList1.Images[Cardpick];
                this.Controls.Add(newCard);
                newCard.BringToFront();
                opponentleftpos = (opponentleftpos + 10);

                i++;
            }

            while (x < 2)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, imageList1.Images.Count);
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

            // Work in progress, coudnt get CurrentPlayer to display instead of player 1
           // currentPlayer = new Player(player1);

            // Use the array to display the players name, along with money
            lblPlayer1.Text = PlayerNames[0] + " : " + player1Score;

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

        /*
        private int[] createNonRandomArray(int size, int startingNumber)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = startingNumber;
                startingNumber++;
            }
            return array;
        }

        private int[] fisherYatesShuffle(int[] array)
        {
            Random rnd = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int r = rnd.Next(0, i + 1);

                int tmp = array[i];
                array[i] = array[r];
                array[r] = tmp;
            }
            return array;

        }

        private bool isInOrder(int[] array)
        {
            int referance = 0;
            foreach (int i in array)
            {
                if (!(i > referance))
                {
                    return false;
                }
                referance = i;
            }
            return true;
        }
        private void backgroundWorkerAlgorithm_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] array = createNonRandomArray(5, 1);
            int y = 0;
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            array = fisherYatesShuffle(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int numberofruns = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                array = fisherYatesShuffle(array);

                //array = shuffleArray(array);
                if (isInOrder(array))
                {
                    break;
                }
                if (numberofruns % 10 == 0)
                {
                    Console.WriteLine(numberofruns);
                }
                numberofruns++;
            }
            sw.Stop();
            Console.WriteLine("Time it took: " + sw.ElapsedMilliseconds + " -- " + sw.Elapsed);
            Console.WriteLine("Number of runs: " + numberofruns);
        }
        */
    }
}
