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
        public GutsMainForm()
        {
            InitializeComponent();
        }

        // TODO: URGENT Look at Comeau's project, Look at Sam's project, Hunters Project
        // TODO: URGENT Program is freezing alot, Infinate loop occurs in the while loops with more players and variables

        /* BEGIN Variables declared at class level */

        public string[] PlayerNames = new string[20];
        public int[] PlayerCards = new int[2];
        // TODO: URGENT is this used? PlayerCardValues is an extra array I added, to attempt to store card values
        public string[] PlayerCardValues = new string[2];
        // TODO: OpponentCards should be set up to hold card values, since I am going to display the back of cards on screen
        public string[] OpponentCardValues = new string[6];
        public int aI = 1;
        public int gameCounter = 0;     // to count what round youre on
        public string player1Score;
        public string player1 = "", player2, player3, player4, player5, player6, player7, player8, player9, player10;

        // Create a new instance of the deck class to use throughout this form, declared at class level
        Deck deckClass = new Deck();

        // Declaration of the Player Class
        Player thePlayer = new Player("Guest",1000);



        /* End Variables declared at class level */

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create access to the new player form
            PlayerPicker thisForm = new PlayerPicker();
            this.Hide();                    // Hide this form
            thisForm.ShowDialog();          // Show form
            this.Close();                   // Dispose of current form
        }

        private void btnAnteUp_Click(object sender, EventArgs e)
        {
            double bet;
            double losses;
            double gains;

            bet = double.Parse(AntePrice.Text);

            if (aI == 1)
            {
                // SET PLAYER 1 CARD 1
                PlayerCardValues[0] = imageList1.Images.Keys[deckClass.CardPick].Substring(0, 1);
                if (imageList1.Images.Keys[deckClass.CardPick].Substring(0, 2) == "10") { PlayerCardValues[0] = "10"; }
                if (PlayerCardValues[0] == "A") { PlayerCardValues[0] = "14"; }
                if (PlayerCardValues[0] == "J") { PlayerCardValues[0] = "11"; }
                if (PlayerCardValues[0] == "K") { PlayerCardValues[0] = "12"; }
                if (PlayerCardValues[0] == "Q") { PlayerCardValues[0] = "13"; }

                // SET PLAYER 1 CARD 2
                PlayerCardValues[1] = imageList1.Images.Keys[deckClass.CardPick2].Substring(0, 1);
                if (imageList1.Images.Keys[deckClass.CardPick2].Substring(0, 2) == "10") { PlayerCardValues[1] = "10"; }
                if (PlayerCardValues[1] == "A") { PlayerCardValues[1] = "14"; }
                if (PlayerCardValues[1] == "J") { PlayerCardValues[1] = "11"; }
                if (PlayerCardValues[1] == "K") { PlayerCardValues[1] = "12"; }
                if (PlayerCardValues[1] == "Q") { PlayerCardValues[1] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 1
                OpponentCardValues[0] = imageList1.Images.Keys[deckClass.CardPick3].Substring(0, 1);
                if (imageList1.Images.Keys[deckClass.CardPick3].Substring(0, 2) == "10") { OpponentCardValues[0] = "10"; }
                if (OpponentCardValues[0] == "A") { OpponentCardValues[0] = "14"; }
                if (OpponentCardValues[0] == "J") { OpponentCardValues[0] = "11"; }
                if (OpponentCardValues[0] == "K") { OpponentCardValues[0] = "12"; }
                if (OpponentCardValues[0] == "Q") { OpponentCardValues[0] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 2
                OpponentCardValues[1] = imageList1.Images.Keys[deckClass.CardPick4].Substring(0, 1);
                if (imageList1.Images.Keys[deckClass.CardPick4].Substring(0, 2) == "10") { OpponentCardValues[1] = "10"; }
                if (OpponentCardValues[1] == "A") { OpponentCardValues[1] = "14"; }
                if (OpponentCardValues[1] == "J") { OpponentCardValues[1] = "11"; }
                if (OpponentCardValues[1] == "K") { OpponentCardValues[1] = "12"; }
                if (OpponentCardValues[1] == "Q") { OpponentCardValues[1] = "13"; }

                // DISPLAY PLAYER CARDS
                lblPlayerCardPick1.Text = PlayerCardValues[0].ToString();
                lblPlayerCardPick2.Text = PlayerCardValues[1].ToString();
                

                // DISPLAY PLAYER 2 : OPPONENT 1 CARDS
                lblPlayer2Card1.Text = OpponentCardValues[0].ToString();
                lblPlayer2Card2.Text = OpponentCardValues[1].ToString();
                pbOpponent1Card1.Image = imageList1.Images[deckClass.CardPick3];
                pbOpponent1Card2.Image = imageList1.Images[deckClass.CardPick4];
            }
            btnShuffle.Visible = true;
            btnAnteUp.Visible = false;

            if (deckClass.CardPick + deckClass.CardPick2 > deckClass.CardPick3 + deckClass.CardPick4)
            {
                gains = bet * 2;

                thePlayer.BankAmount = thePlayer.BankAmount + gains;

                lblWinLabel.Text = "You won $" + gains + " that round!";
            }
        }

   




        private void areYouSureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void GutsMainForm_Load(object sender, EventArgs e)
        {
            btnAnteUp.Visible = false;

            // Sets playerone to the player name from the array
            player1 = PlayerNames[0];
            


            // Set Playername Instance of the Player class to store the player name
            if (player1 != null)
            { thePlayer.PlayerName = player1; }
            // Player name is set to guest if no player is picked
            else { thePlayer.PlayerName = "Guest"; } 

            // Start money set in the player class
            thePlayer.BankAmount = 1000;

            // Use the array to display the players name from the Playerclass, along with money
            lblPlayer1.Text = thePlayer.PlayerName + " : " + thePlayer.BankAmount.ToString("c");

            if (aI == 1)  // IF a 2 player game
                lblPlayer2.Text = "Computer 1" + thePlayer.BankAmount.ToString("c");
        }



        // TODO: Force Crashes at times, gets stuck in infinate loop
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (aI == 1)  // IF a 2 player game
            {

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (deckClass.CardPick == 40 || deckClass.CardPick == 41 || deckClass.CardPick == 56)
                {
                    deckClass.CardPick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (deckClass.CardPick2 == 40 || deckClass.CardPick2 == 41 || deckClass.CardPick2 == 56
                    || deckClass.CardPick2 == deckClass.CardPick)
                {
                    // Pick a new random
                    deckClass.CardPick2 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick3 = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                // Also ensures the opponent card doesnt match player cards
                while (deckClass.CardPick3 == 40 || deckClass.CardPick3 == 41 || deckClass.CardPick3 == 56 
                    || deckClass.CardPick3 == deckClass.CardPick || deckClass.CardPick3 == deckClass.CardPick2)
                {
                    // Pick a new random
                    deckClass.CardPick3 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 2 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand4 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick4 = rand.Next(0, imageList1.Images.Count);

                while (deckClass.CardPick4 == 40 || deckClass.CardPick4 == 41 || deckClass.CardPick4 == 56 
                    || deckClass.CardPick4 == deckClass.CardPick3 || deckClass.CardPick4 == deckClass.CardPick2 
                    || deckClass.CardPick4 == deckClass.CardPick)
                {
                    // Pick a new random
                    deckClass.CardPick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[deckClass.CardPick];
                pbPlayer1Card2.Image = imageList1.Images[deckClass.CardPick2];


                // Player 2 Opponent, Show 1 card face up, 1 card face down
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[deckClass.CardPick4];

                btnAnteUp.Visible = true;
                btnShuffle.Visible = false;
            }
           
        }

        // TODO: yesRestartToolStripMenuItem_Click Restarts the game, but doesnt pull player info with it or repopulate cards
        // TODO: ENCAPSOLATE THE IF STATEMENT IN A CLASS, TAKING WAY TO MUCH SPACE
        private void yesRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GutsMainForm NewGame = new GutsMainForm();
            NewGame.PlayerNames[0] = lblPlayer1.Text;
            NewGame.aI = aI;
            this.Hide();
            NewGame.ShowDialog();
            this.Close();

            if (aI == 1)  // IF a 2 player game
            {

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (deckClass.CardPick == 40 || deckClass.CardPick == 41 || deckClass.CardPick == 56)
                {
                    deckClass.CardPick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (deckClass.CardPick2 == 40 || deckClass.CardPick2 == 41 || deckClass.CardPick2 == 56
                    || deckClass.CardPick2 == deckClass.CardPick)
                {
                    // Pick a new random
                    deckClass.CardPick2 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick3 = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                // Also ensures the opponent card doesnt match player cards
                while (deckClass.CardPick3 == 40 || deckClass.CardPick3 == 41 || deckClass.CardPick3 == 56
                    || deckClass.CardPick3 == deckClass.CardPick || deckClass.CardPick3 == deckClass.CardPick2)
                {
                    // Pick a new random
                    deckClass.CardPick3 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 2 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand4 = new Random(DateTime.Now.Millisecond);
                deckClass.CardPick4 = rand.Next(0, imageList1.Images.Count);

                while (deckClass.CardPick4 == 40 || deckClass.CardPick4 == 41 || deckClass.CardPick4 == 56
                    || deckClass.CardPick4 == deckClass.CardPick3 || deckClass.CardPick4 == deckClass.CardPick2
                    || deckClass.CardPick4 == deckClass.CardPick)
                {
                    // Pick a new random
                    deckClass.CardPick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[deckClass.CardPick];
                pbPlayer1Card2.Image = imageList1.Images[deckClass.CardPick2];

                // Display Opponenct cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[deckClass.CardPick3];
                pbPreviewOppCard2.Image = imageList1.Images[deckClass.CardPick4];

                // Player 2 Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];
            }
            
        }
    }
}
