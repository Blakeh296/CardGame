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
        // TODO: Look at Comeau's project, Look at Sam's project, Hunters Project
        // TODO: Get card values for game, took picture of Sam's code

        public string[] PlayerNames = new string[20];
        public int[] PlayerCards = new int[2];
        // TODO: PlayerCardValues is an extra array I added, to attempt to store card values
        public int[] PlayerCardValues = new int[2];
        // TODO: OpponentCards should be set up to hold card values, since I am going to display the back of cards on screen
        public int[] OpponentCards = new int[2];
        public int aI;
        public int gameCounter = 0;     // to count what round youre on
        public string player1Score;
        public string player1, player2, player3, player4, player5, player6, player7, player8, player9, player10;

        // TODO: Set my player class  but is never used
        Player var = new Player("bill");

        // variables for the cards, and the while loop
        public int opponentleftpos = 175;
        public int opponenttoppos = 275;

        // For testing purposes
        private void btnCardPick_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 26);
            MessageBox.Show(imageList1.Images.Keys[Cardpick].ToString());
        }
        // TODO: yesRestartToolStripMenuItem_Click Restarts the game, but doesnt pull player info with it
        private void yesRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GutsMainForm NewGame = new GutsMainForm();
            NewGame.PlayerNames[0] = lblPlayer1.Text;
            this.Hide();
            NewGame.ShowDialog();
            this.Close();
        }

        // TODO: AntePrice_SelectedItemChanged Get this do display with dollar sign
        private void AntePrice_SelectedItemChanged(object sender, EventArgs e)
        {
            // Neither of these work

            //AntePrice.SelectedItem = AntePrice.Text.ToString("c");
            //AntePrice.Text = AntePrice.ToString("c");
        }

        public int leftpos = 50;
        public int toppos = 450;
        public int CardLocation = 0;
        public int i = 0;
        public int x = 0;

        public GutsMainForm()
        {
            InitializeComponent();
        }

        private void playerSelectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create access to the new player form
            PlayerPicker thisForm = new PlayerPicker();
            this.Hide();                    // Hide this form
            thisForm.ShowDialog();          // Show form
            this.Close();                   // Dispose of current form
        }

        private void yESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GutsMainForm_Load(object sender, EventArgs e)
        {
            // PLAYER CARD ONE
            //Create a random number between 0 and the number of cards in the deck
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, imageList1.Images.Count);

            // Rules out the potential of a backwards card, or displaying the card stack image
            while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
            {
                Cardpick = rand.Next(0, imageList1.Images.Count);
            }

            // PLAYER CARD 2
            Random rand2 = new Random(DateTime.Now.Millisecond);
            int Cardpick2 = rand.Next(0, imageList1.Images.Count);

            // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
            while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
            {
                // Pick a new random
                Cardpick2 = rand.Next(0, imageList1.Images.Count);
            }

            // Dispplay the player cards together
            pbPlayer1Card1.Image = imageList1.Images[Cardpick];
            pbPlayer1Card2.Image = imageList1.Images[Cardpick2];


            // CARD PICK ONE FOR OPPONENT ONE
            //Create a random number between 0 and the number of cards in the deck
            Random rand3 = new Random(DateTime.Now.Millisecond);
            int Cardpick3 = rand.Next(0, imageList1.Images.Count);

            // Rules out the potential of a backwards card, or displaying the card stack image
            // Also ensures the opponent card doesnt match player cards
            while (Cardpick3 == 40 || Cardpick3 == 41 || Cardpick3 == 56 || Cardpick3 == Cardpick || Cardpick3 == Cardpick2)
            {
                // Pick a new random
                Cardpick3 = rand.Next(0, imageList1.Images.Count);
            }

            // CARD PICK 2 FOR OPPONENT 1
            //Create a random number between 0 and the number of cards in the deck
            Random rand4 = new Random(DateTime.Now.Millisecond);
            int Cardpick4 = rand.Next(0, imageList1.Images.Count);

            while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
            {
                // Pick a new random
                Cardpick4 = rand.Next(0, imageList1.Images.Count);
            }

            // Display the cards together 
            pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
            pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

            /*
            while (x < 2)
            {
                Random rand3 = new Random(DateTime.Now.Millisecond);
                int Cardpick3 = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                if (Cardpick3 == 40 || Cardpick3 == 41 || Cardpick3 == 56)
                {
                    Cardpick3 = rand.Next(0, imageList1.Images.Count);
                }

                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(50, 70);
                newCard.BackgroundImage = imageList1.Images[Cardpick3];
                newCard.BackgroundImageLayout = ImageLayout.Stretch;
                newCard.Location = new Point(leftpos, toppos);

                PlayerCards[x] = Cardpick3;

                this.Controls.Add(newCard);
                newCard.BringToFront();
                leftpos = (leftpos + 20);

                OpponentCards[x] = Cardpick;

                x++;
            } */
            // Display clickable cards for the player
            //pbPlayer1Card1.Image = imageList1.Images[PlayerCards[0]];
            //pbPlayer1Card2.Image = imageList1.Images[PlayerCards[1]];

            // Player 2 Opponent 1
            // TODO: Displays back of cards, need a way to get and keep card value
            pbOpponent1Card1.Image = imageList1.Images[41];
            pbOpponent1Card2.Image = imageList1.Images[41];

            // Player 3 Opponent 2
            pbOpponent2Card1.Image = imageList1.Images[41];
            pbOpponent2Card2.Image = imageList1.Images[41];

            // TODO: First Attempt at getting card values
            //MessageBox.Show("Player Cards" + PlayerCards[0]);
            // TODO: Second attempt at getting card values
            //MessageBox.Show("Opposing cards" + OpponentCards[0].ToString());
            //MessageBox.Show("Opposing cards" + OpponentCards[1].ToString());

            // forms first size 504, 392
            this.Size = new Size(873, 512);

            double startMoney = 5000;

            // Initially set all AI labels to false visability
            lblPlayer3.Visible = false;
            lblPlayer4.Visible = false;
            lblPlayer5.Visible = false;
            lblPlayer6.Visible = false;
            lblPlayer7.Visible = false;
            lblPlayer8.Visible = false;
            lblPlayer9.Visible = false;
            lblPlayer10.Visible = false;

            // Use the array to display the players name, along with money
            lblPlayer1.Text = PlayerNames[0] + " : " + "$ " + player1Score.ToString();

            // TODO: AI If statement, idk if i want to keep this
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



        // TODO: IDK what this is, multiple commented methods here
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
