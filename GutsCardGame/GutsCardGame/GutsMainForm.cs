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
        // TODO: URGENT Look at Comeau's project, Look at Sam's project, Hunters Project
        // TODO: URGENT Program is freezing alot, Infinate loop occurs in the while loops with more players and variables

        /* BEGIN Variables declared at class level */

        public string[] PlayerNames = new string[20];
        public int[] PlayerCards = new int[2];
        // TODO: URGENT is this used? PlayerCardValues is an extra array I added, to attempt to store card values
        public string[] PlayerCardValues = new string[2];
        // TODO: OpponentCards should be set up to hold card values, since I am going to display the back of cards on screen
        public string[] OpponentCardValues = new string[6];
        public int aI;
        public int gameCounter = 0;     // to count what round youre on
        public string player1Score;
        public string player1, player2, player3, player4, player5, player6, player7, player8, player9, player10;

        // USED IN THE LOAD EVENT TO DRAW FIRST CARDS, AND CARRY VARIABLES THROUGHOUT THE FORM
        int Cardpick;
        int Cardpick2;
        int Cardpick3;
        int Cardpick4;
        int Cardpick5;
        int Cardpick6;
        int Cardpick7;

        

        int Cardpick8;
        /* End Variables declared at class level */

        

        public GutsMainForm()
        {
            InitializeComponent();
        }

        // For testing purposes
        private void btnCardPick_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 26);
            MessageBox.Show(imageList1.Images.Keys[Cardpick].ToString());
        }

        private void areYouSureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // TODO: AntePrice_SelectedItemChanged Get this do display with dollar sign
        private void AntePrice_SelectedItemChanged(object sender, EventArgs e)
        {
            // Neither of these work
            
            /* string selectedItem;

            selectedItem = AntePrice.Text;
            AntePrice.Text = selectedItem.ToString("c"); */

            //AntePrice.SelectedItem = AntePrice.Text.ToString("c");
            //AntePrice.Text = AntePrice.ToString("c");
        }

        private void playerSelectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create access to the new player form
            PlayerPicker thisForm = new PlayerPicker();
            this.Hide();                    // Hide this form
            thisForm.ShowDialog();          // Show form
            this.Close();                   // Dispose of current form
        }

        private void GutsMainForm_Load(object sender, EventArgs e)
        {

            // Sets playerone to the player name from the array
            player1 = PlayerNames[0];
            
            // Declaration of the Player Class
            Player thePlayer = new Player(player1);

            // Set Playername Instance of the Player class to store the player name
            thePlayer.PlayerName = player1;

            // Starting money for AI
            double startMoney = 5000;
 
            // Use the array to display the players name from the Playerclass, along with money
            lblPlayer1.Text = thePlayer.PlayerName + " : " + "$ " + player1Score.ToString();

            // Initially set all AI labels to false, for the IF STATEMENT to decide which label display
            lblPlayer3.Visible = false;
            lblPlayer4.Visible = false;

            // TODO: AI If statement, idk if i want to keep this

            if (aI == 1)  // IF a 2 player game
            {
                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Display Opponenct cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Hide Preview image boxes containing starting cards
                pbPreviewPlayer3Card1.Visible = false;
                pbPreviewPlayer3Card2.Visible = false;
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide the GroupBoxes for more players
                gbPlayer3.Visible = false;
                gbPlayer4.Visible = false;
            }
            else if (aI == 2)  /*  IF 3 Player Game */
            {
                lblPlayer3.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Hide 4th Player PictureBox 
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide Player 4 GroupBox
                gbPlayer4.Visible = false;
            }
            else if (aI == 3)
            {
                lblPlayer3.Visible = true;
                lblPlayer4.Visible = true;

                lblPlayer2.Text = "AI 1 " + startMoney.ToString("c");
                lblPlayer3.Text = "AI 2 " + startMoney.ToString("c");
                lblPlayer4.Text = "AI 3 " + startMoney.ToString("c");

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 1
                Random rand7 = new Random(DateTime.Now.Millisecond);
                Cardpick7 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick7 == 40 || Cardpick7 == 41 || Cardpick7 == 56 || Cardpick7 == Cardpick6 || Cardpick7 == Cardpick5 || Cardpick7 == Cardpick4 || Cardpick7 == Cardpick3 || Cardpick7 == Cardpick2 || Cardpick7 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 2
                Random rand8 = new Random(DateTime.Now.Millisecond);
                Cardpick8 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick8 == 40 || Cardpick8 == 41 || Cardpick8 == 56 || Cardpick8 == Cardpick7 || Cardpick8 == Cardpick6 || Cardpick8 == Cardpick5 || Cardpick8 == Cardpick4 || Cardpick8 == Cardpick3 || Cardpick8 == Cardpick2 || Cardpick8 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Player 4 : Opponent 3 Cards * FACE UP *
                pbPreviewPlayer4Card1.Image = imageList1.Images[Cardpick7];
                pbPreviewPlayer4Card2.Image = imageList1.Images[Cardpick8];

                // Player 4 : Opponent 3 Cards * IN HUD *, * FACE DOWN *
                pbOpponent3Card1.Image = imageList1.Images[41];
                pbOpponent3Card2.Image = imageList1.Images[41];
            }
        }

        private void btnGetValuesTest_Click(object sender, EventArgs e)
        {
            if (aI == 1)
            {
                // SET PLAYER 1 CARD 1
                PlayerCardValues[0] = imageList1.Images.Keys[Cardpick].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick].Substring(0, 2) == "10") { PlayerCardValues[0] = "10"; }
                if (PlayerCardValues[0] == "A") { PlayerCardValues[0] = "14"; }
                if (PlayerCardValues[0] == "J") { PlayerCardValues[0] = "11"; }
                if (PlayerCardValues[0] == "K") { PlayerCardValues[0] = "12"; }
                if (PlayerCardValues[0] == "Q") { PlayerCardValues[0] = "13"; }

                // SET PLAYER 1 CARD 2
                PlayerCardValues[1] = imageList1.Images.Keys[Cardpick2].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick2].Substring(0, 2) == "10") { PlayerCardValues[1] = "10"; }
                if (PlayerCardValues[1] == "A") { PlayerCardValues[1] = "14"; }
                if (PlayerCardValues[1] == "J") { PlayerCardValues[1] = "11"; }
                if (PlayerCardValues[1] == "K") { PlayerCardValues[1] = "12"; }
                if (PlayerCardValues[1] == "Q") { PlayerCardValues[1] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 1
                OpponentCardValues[0] = imageList1.Images.Keys[Cardpick3].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick3].Substring(0, 2) == "10") { OpponentCardValues[0] = "10"; }
                if (OpponentCardValues[0] == "A") { OpponentCardValues[0] = "14"; }
                if (OpponentCardValues[0] == "J") { OpponentCardValues[0] = "11"; }
                if (OpponentCardValues[0] == "K") { OpponentCardValues[0] = "12"; }
                if (OpponentCardValues[0] == "Q") { OpponentCardValues[0] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 2
                OpponentCardValues[1] = imageList1.Images.Keys[Cardpick4].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[1] = "10"; }
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
            }
            if (aI == 2)
            {
                // SET PLAYER 1 CARD 1
                PlayerCardValues[0] = imageList1.Images.Keys[Cardpick].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick].Substring(0, 2) == "10") { PlayerCardValues[0] = "10"; }
                if (PlayerCardValues[0] == "A") { PlayerCardValues[0] = "14"; }
                if (PlayerCardValues[0] == "J") { PlayerCardValues[0] = "11"; }
                if (PlayerCardValues[0] == "K") { PlayerCardValues[0] = "12"; }
                if (PlayerCardValues[0] == "Q") { PlayerCardValues[0] = "13"; }

                // SET PLAYER 1 CARD 2
                PlayerCardValues[1] = imageList1.Images.Keys[Cardpick2].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick2].Substring(0, 2) == "10") { PlayerCardValues[1] = "10"; }
                if (PlayerCardValues[1] == "A") { PlayerCardValues[1] = "14"; }
                if (PlayerCardValues[1] == "J") { PlayerCardValues[1] = "11"; }
                if (PlayerCardValues[1] == "K") { PlayerCardValues[1] = "12"; }
                if (PlayerCardValues[1] == "Q") { PlayerCardValues[1] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 1
                OpponentCardValues[0] = imageList1.Images.Keys[Cardpick3].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick3].Substring(0, 2) == "10") { OpponentCardValues[0] = "10"; }
                if (OpponentCardValues[0] == "A") { OpponentCardValues[0] = "14"; }
                if (OpponentCardValues[0] == "J") { OpponentCardValues[0] = "11"; }
                if (OpponentCardValues[0] == "K") { OpponentCardValues[0] = "12"; }
                if (OpponentCardValues[0] == "Q") { OpponentCardValues[0] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 2
                OpponentCardValues[1] = imageList1.Images.Keys[Cardpick4].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[1] = "10"; }
                if (OpponentCardValues[1] == "A") { OpponentCardValues[1] = "14"; }
                if (OpponentCardValues[1] == "J") { OpponentCardValues[1] = "11"; }
                if (OpponentCardValues[1] == "K") { OpponentCardValues[1] = "12"; }
                if (OpponentCardValues[1] == "Q") { OpponentCardValues[1] = "13"; }

                // SET PLAYER 3 : OPPONENT 2 CARD 1
                OpponentCardValues[2] = imageList1.Images.Keys[Cardpick5].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[2] = "10"; }
                if (OpponentCardValues[2] == "A") { OpponentCardValues[2] = "14"; }
                if (OpponentCardValues[2] == "J") { OpponentCardValues[2] = "11"; }
                if (OpponentCardValues[2] == "K") { OpponentCardValues[2] = "12"; }
                if (OpponentCardValues[2] == "Q") { OpponentCardValues[2] = "13"; }

                // SET PLAYER 3 : OPPONENT 2 CARD 2
                OpponentCardValues[3] = imageList1.Images.Keys[Cardpick6].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[3] = "10"; }
                if (OpponentCardValues[3] == "A") { OpponentCardValues[3] = "14"; }
                if (OpponentCardValues[3] == "J") { OpponentCardValues[3] = "11"; }
                if (OpponentCardValues[3] == "K") { OpponentCardValues[3] = "12"; }
                if (OpponentCardValues[3] == "Q") { OpponentCardValues[3] = "13"; }

                // DISPLAY PLAYER CARDS
                lblPlayerCardPick1.Text = PlayerCardValues[0].ToString();
                lblPlayerCardPick2.Text = PlayerCardValues[1].ToString();

                // DISPLAY PLAYER 2 : OPPONENT 1 CARDS
                lblPlayer2Card1.Text = OpponentCardValues[0].ToString();
                lblPlayer2Card2.Text = OpponentCardValues[1].ToString();

                // DISPLAY PLAYER 3 : OPPONENT 2 CARDS
                lblPlayer3Card1.Text = OpponentCardValues[2].ToString();
                lblPlayer3Card2.Text = OpponentCardValues[3].ToString();
            }
            if (aI == 3)
            {
                // SET PLAYER 1 CARD 1
                PlayerCardValues[0] = imageList1.Images.Keys[Cardpick].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick].Substring(0, 2) == "10") { PlayerCardValues[0] = "10"; }
                if (PlayerCardValues[0] == "A") { PlayerCardValues[0] = "14"; }
                if (PlayerCardValues[0] == "J") { PlayerCardValues[0] = "11"; }
                if (PlayerCardValues[0] == "K") { PlayerCardValues[0] = "12"; }
                if (PlayerCardValues[0] == "Q") { PlayerCardValues[0] = "13"; }

                // SET PLAYER 1 CARD 2
                PlayerCardValues[1] = imageList1.Images.Keys[Cardpick2].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick2].Substring(0, 2) == "10") { PlayerCardValues[1] = "10"; }
                if (PlayerCardValues[1] == "A") { PlayerCardValues[1] = "14"; }
                if (PlayerCardValues[1] == "J") { PlayerCardValues[1] = "11"; }
                if (PlayerCardValues[1] == "K") { PlayerCardValues[1] = "12"; }
                if (PlayerCardValues[1] == "Q") { PlayerCardValues[1] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 1
                OpponentCardValues[0] = imageList1.Images.Keys[Cardpick3].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick3].Substring(0, 2) == "10") { OpponentCardValues[0] = "10"; }
                if (OpponentCardValues[0] == "A") { OpponentCardValues[0] = "14"; }
                if (OpponentCardValues[0] == "J") { OpponentCardValues[0] = "11"; }
                if (OpponentCardValues[0] == "K") { OpponentCardValues[0] = "12"; }
                if (OpponentCardValues[0] == "Q") { OpponentCardValues[0] = "13"; }

                // SET PLAYER 2 : OPPONENT 1 CARD 2
                OpponentCardValues[1] = imageList1.Images.Keys[Cardpick4].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[1] = "10"; }
                if (OpponentCardValues[1] == "A") { OpponentCardValues[1] = "14"; }
                if (OpponentCardValues[1] == "J") { OpponentCardValues[1] = "11"; }
                if (OpponentCardValues[1] == "K") { OpponentCardValues[1] = "12"; }
                if (OpponentCardValues[1] == "Q") { OpponentCardValues[1] = "13"; }

                // SET PLAYER 3 : OPPONENT 2 CARD 1
                OpponentCardValues[2] = imageList1.Images.Keys[Cardpick5].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[2] = "10"; }
                if (OpponentCardValues[2] == "A") { OpponentCardValues[2] = "14"; }
                if (OpponentCardValues[2] == "J") { OpponentCardValues[2] = "11"; }
                if (OpponentCardValues[2] == "K") { OpponentCardValues[2] = "12"; }
                if (OpponentCardValues[2] == "Q") { OpponentCardValues[2] = "13"; }

                // SET PLAYER 3 : OPPONENT 2 CARD 2
                OpponentCardValues[3] = imageList1.Images.Keys[Cardpick6].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick4].Substring(0, 2) == "10") { OpponentCardValues[3] = "10"; }
                if (OpponentCardValues[3] == "A") { OpponentCardValues[3] = "14"; }
                if (OpponentCardValues[3] == "J") { OpponentCardValues[3] = "11"; }
                if (OpponentCardValues[3] == "K") { OpponentCardValues[3] = "12"; }
                if (OpponentCardValues[3] == "Q") { OpponentCardValues[3] = "13"; }

                // SET PLAYER 4 : OPPONENT 3 CARD 1
                OpponentCardValues[4] = imageList1.Images.Keys[Cardpick7].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick7].Substring(0, 2) == "10") { OpponentCardValues[4] = "10"; }
                if (OpponentCardValues[4] == "A") { OpponentCardValues[4] = "14"; }
                if (OpponentCardValues[4] == "J") { OpponentCardValues[4] = "11"; }
                if (OpponentCardValues[4] == "K") { OpponentCardValues[4] = "12"; }
                if (OpponentCardValues[4] == "Q") { OpponentCardValues[4] = "13"; }

                // SET PLAYER 4 : OPPONENT 3 CARD 2
                OpponentCardValues[5] = imageList1.Images.Keys[Cardpick8].Substring(0, 1);
                if (imageList1.Images.Keys[Cardpick8].Substring(0, 2) == "10") { OpponentCardValues[5] = "10"; }
                if (OpponentCardValues[5] == "A") { OpponentCardValues[5] = "14"; }
                if (OpponentCardValues[5] == "J") { OpponentCardValues[5] = "11"; }
                if (OpponentCardValues[5] == "K") { OpponentCardValues[5] = "12"; }
                if (OpponentCardValues[5] == "Q") { OpponentCardValues[5] = "13"; }

                // DISPLAY PLAYER 1 CARDS
                lblPlayerCardPick1.Text = PlayerCardValues[0].ToString();
                lblPlayerCardPick2.Text = PlayerCardValues[1].ToString();

                // DISPLAY PLAYER 2 : OPPONENT 1 CARDS
                lblPlayer2Card1.Text = OpponentCardValues[0].ToString();
                lblPlayer2Card2.Text = OpponentCardValues[1].ToString();

                // DISPLAY PLAYER 3 : OPPONENT 2 CARDS
                lblPlayer3Card1.Text = OpponentCardValues[2].ToString();
                lblPlayer3Card2.Text = OpponentCardValues[3].ToString();

                // DISPLAY PLAYER 4 : OPPONENT 3 CARDS
                lblPlayer4Card1.Text = OpponentCardValues[4].ToString();
                lblPlayer4Card2.Text = OpponentCardValues[5].ToString();
            }

        }

        // TODO: Force Crashes at times, gets stuck in infinate loop
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (aI == 1)  // IF a 2 player game
            {

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Display Opponenct cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Hide Preview image boxes containing starting cards
                pbPreviewPlayer3Card1.Visible = false;
                pbPreviewPlayer3Card2.Visible = false;
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide the GroupBoxes for more players
                gbPlayer3.Visible = false;
                gbPlayer4.Visible = false;
            }
            else if (aI == 2)  /*  IF 3 Player Game */
            {


                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Hide 4th Player PictureBox 
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide Player 4 GroupBox
                gbPlayer4.Visible = false;
            }
            else if (aI == 3)
            {

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 1
                Random rand7 = new Random(DateTime.Now.Millisecond);
                Cardpick7 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick7 == 40 || Cardpick7 == 41 || Cardpick7 == 56 || Cardpick7 == Cardpick6 || Cardpick7 == Cardpick5 || Cardpick7 == Cardpick4 || Cardpick7 == Cardpick3 || Cardpick7 == Cardpick2 || Cardpick7 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 2
                Random rand8 = new Random(DateTime.Now.Millisecond);
                Cardpick8 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick8 == 40 || Cardpick8 == 41 || Cardpick8 == 56 || Cardpick8 == Cardpick7 || Cardpick8 == Cardpick6 || Cardpick8 == Cardpick5 || Cardpick8 == Cardpick4 || Cardpick8 == Cardpick3 || Cardpick8 == Cardpick2 || Cardpick8 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Player 4 : Opponent 3 Cards * FACE UP *
                pbPreviewPlayer4Card1.Image = imageList1.Images[Cardpick7];
                pbPreviewPlayer4Card2.Image = imageList1.Images[Cardpick8];

                // Player 4 : Opponent 3 Cards * IN HUD *, * FACE DOWN *
                pbOpponent3Card1.Image = imageList1.Images[41];
                pbOpponent3Card2.Image = imageList1.Images[41];
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
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }

                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Display Opponenct cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Hide Preview image boxes containing starting cards
                pbPreviewPlayer3Card1.Visible = false;
                pbPreviewPlayer3Card2.Visible = false;
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide the GroupBoxes for more players
                gbPlayer3.Visible = false;
                gbPlayer4.Visible = false;
            }
            else if (aI == 2)  /*  IF 3 Player Game */
            {


                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Hide 4th Player PictureBox 
                pbPreviewPlayer4Card1.Visible = false;
                pbPreviewPlayer4Card2.Visible = false;

                // Hide Player 4 GroupBox
                gbPlayer4.Visible = false;
            }
            else if (aI == 3)
            {

                // PLAYER 1 CARD 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand = new Random(DateTime.Now.Millisecond);
                Cardpick = rand.Next(0, imageList1.Images.Count);

                // Rules out the potential of a backwards card, or displaying the card stack image
                while (Cardpick == 40 || Cardpick == 41 || Cardpick == 56)
                {
                    Cardpick = rand.Next(0, imageList1.Images.Count);
                }

                // PLAYER 1 CARD 2
                Random rand2 = new Random(DateTime.Now.Millisecond);
                Cardpick2 = rand.Next(0, imageList1.Images.Count);

                // Makes sure a valid card is being played, and makes sure previous CardPicks DO NOT MATCH
                while (Cardpick2 == 40 || Cardpick2 == 41 || Cardpick2 == 56 || Cardpick2 == Cardpick)
                {
                    // Pick a new random
                    Cardpick2 = rand.Next(0, imageList1.Images.Count);
                }


                // CARD PICK 1 FOR OPPONENT 1
                //Create a random number between 0 and the number of cards in the deck
                Random rand3 = new Random(DateTime.Now.Millisecond);
                Cardpick3 = rand.Next(0, imageList1.Images.Count);

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
                Cardpick4 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick4 == 40 || Cardpick4 == 41 || Cardpick4 == 56 || Cardpick4 == Cardpick3 || Cardpick4 == Cardpick2 || Cardpick4 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 1
                Random rand5 = new Random(DateTime.Now.Millisecond);
                Cardpick5 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick5 == 40 || Cardpick5 == 41 || Cardpick5 == 56 || Cardpick5 == Cardpick4 || Cardpick5 == Cardpick3 || Cardpick5 == Cardpick2 || Cardpick5 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 3 : Opponent 2 CARD PICK 2
                Random rand6 = new Random(DateTime.Now.Millisecond);
                Cardpick6 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick6 == 40 || Cardpick6 == 41 || Cardpick6 == 56 || Cardpick6 == Cardpick5 || Cardpick6 == Cardpick4 || Cardpick6 == Cardpick3 || Cardpick6 == Cardpick2 || Cardpick6 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 1
                Random rand7 = new Random(DateTime.Now.Millisecond);
                Cardpick7 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick7 == 40 || Cardpick7 == 41 || Cardpick7 == 56 || Cardpick7 == Cardpick6 || Cardpick7 == Cardpick5 || Cardpick7 == Cardpick4 || Cardpick7 == Cardpick3 || Cardpick7 == Cardpick2 || Cardpick7 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Player 4 : Opponent 3 CARD PICK 2
                Random rand8 = new Random(DateTime.Now.Millisecond);
                Cardpick8 = rand.Next(0, imageList1.Images.Count);

                // Check to see if the card is playable, and not already taken
                while (Cardpick8 == 40 || Cardpick8 == 41 || Cardpick8 == 56 || Cardpick8 == Cardpick7 || Cardpick8 == Cardpick6 || Cardpick8 == Cardpick5 || Cardpick8 == Cardpick4 || Cardpick8 == Cardpick3 || Cardpick8 == Cardpick2 || Cardpick8 == Cardpick)
                {
                    // Pick a new random
                    Cardpick4 = rand.Next(0, imageList1.Images.Count);
                }

                // Display Player 1 cards * FACE UP *
                pbPlayer1Card1.Image = imageList1.Images[Cardpick];
                pbPlayer1Card2.Image = imageList1.Images[Cardpick2];

                // Player 2 : Opponenct 1 cards * FACE UP *
                pbPreviewOppCard1.Image = imageList1.Images[Cardpick3];
                pbPreviewOppCard2.Image = imageList1.Images[Cardpick4];

                // Player 2 : Opponent 1 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent1Card1.Image = imageList1.Images[41];
                pbOpponent1Card2.Image = imageList1.Images[41];

                // Player 3 : Opponent 2 Cards * FACE UP *
                pbPreviewPlayer3Card1.Image = imageList1.Images[Cardpick5];
                pbPreviewPlayer3Card2.Image = imageList1.Images[Cardpick6];

                // Player 3 : Opponent 2 Displays in * GroupBox HUD *, * FACE DOWN *
                pbOpponent2Card1.Image = imageList1.Images[41];
                pbOpponent2Card2.Image = imageList1.Images[41];

                // Player 4 : Opponent 3 Cards * FACE UP *
                pbPreviewPlayer4Card1.Image = imageList1.Images[Cardpick7];
                pbPreviewPlayer4Card2.Image = imageList1.Images[Cardpick8];

                // Player 4 : Opponent 3 Cards * IN HUD *, * FACE DOWN *
                pbOpponent3Card1.Image = imageList1.Images[41];
                pbOpponent3Card2.Image = imageList1.Images[41];
            }
        }
    }
}
