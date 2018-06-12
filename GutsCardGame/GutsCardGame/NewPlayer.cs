using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GutsCardGame
{

    /*  Current code issues
     *  // 1. The score is now displaying on the main screen, however its only displaying a specific score, not the score
     *  // Assosiated to the player picked -- Probably a tokenizing issue idk. 
     *  // 2. dont know how to get the picture box values and store them
     */

    public partial class PlayerPicker : Form
    {

        // Declare a array to hold the player names from the CSV file
        public string[] Tokenss = new string[40];
        public string[] PlayerNames = new string[20];
        public int[] Highscores = new int[40];
        

        public PlayerPicker()
        {
            InitializeComponent();
        }

        GutsMainForm frmOne = new GutsMainForm();

        // Name now displays on game form, a highscore displays but not the right one 
        // still dont understand classes
        private void NewPlayer_Load(object sender, EventArgs e)
        {
            //497, 338
            //335, 112

            this.Size = new Size(335, 112);
            string players;
            int count = 0;

            try
            {
                // Declare a Stream Reader
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("GutsPlayers.txt");

                //create a delimiter array
                char[] delim = { ',' };

                // Read the files contents
                while (!inputFile.EndOfStream)
                {
                    players = inputFile.ReadLine();

                    Tokenss = players.Split(delim);

                    // Get player name
                    // PlayerNames[count] = Tokens[0];
                    // TODO: URGANT In Load Event : Highscores[count] = int.Parse(Tokenss[1]);

                    comboBox1.Items.Add(Tokenss[0]);

                    // increment the counter
                    count++;
                }

                // Close the file
                inputFile.Close();

                // Set a default name if no name is picked (Ensure code runs) lol
                comboBox1.Text = "Newbie";
            }
            catch
            {
                MessageBox.Show("Select 'New Player' to begin");

                btnReturningPlayer.Visible = false;

                btnNewPlayer.Location = new Point(98, 24);
            }
            
        }

        // When you pick a different name from avaliable characters
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the text box equal to the players score
            label1.Text = Tokenss[1];
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                

                //create a delimiter array
                char[] delim = { ',' };

                // Get rid of the button and textbox
                tbNewPlayer.Visible = false;
                btnAddPlayer.Visible = false;
                pictureBox1.Visible = false;

                // Set the form size
                this.Size = new Size(290, 330);

                // Make Graphic labels visable
                lblLabel4.Visible = true;
                lblUnderline4.Visible = true;
                comboBox1.Visible = true;
                comboBox1.Location = new Point(25, 56);
                lblLabel3.Visible = true;
                lblUnderline2.Visible = true;
                lblAICount.Visible = true;
                lblUnderline3.Visible = true;
                trackBar1.Visible = true;
                lblSlogan.Visible = true;
                btnPlay.Visible = true;

                // Declare a Streamwriter variable
                StreamWriter outputFile;

                outputFile = File.AppendText("GutsPlayers.txt");

                string var = tbNewPlayer.Text;

                comboBox1.Items.Add(var);

                outputFile.WriteLine(var);

                // close file
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Last button on the page before the game starts
        private void btnPlay_Click(object sender, EventArgs e)
        {
            string Score = "0";

            try
            {
                // Set the variable on the main form 
                frmOne.PlayerNames[0] = comboBox1.Text;
                // gets the number of AI for game
                frmOne.aI = int.Parse(lblAICount.Text);

                // TODO: Score = Tokenss[1].ToString(); is pulling the last known score, not the selected player score
                Score = Tokenss[1].ToString();

                frmOne.player1Score = Score;

                this.Hide();        // Hide this form

                frmOne.ShowDialog();    // Show next form

                this.Close();       // Dispose of this form
            }
            catch
            {
                MessageBox.Show(" A player might need assosiated with a score");
            }
            
        }

        // Displays text box so the user can type in a name they want to play as,
        // or a returning player can start fresh 
        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // Make first pair of buttons invisible
                btnNewPlayer.Visible = false;
                btnReturningPlayer.Visible = false;

                // Make textbox and BtnAddPlayer visable
                tbNewPlayer.Visible = true;
                btnAddPlayer.Visible = true;
                pictureBox1.Visible = true;

                // Move the two items to the appropriate location on form
                tbNewPlayer.Location = new Point(53, 30);
                btnAddPlayer.Location = new Point(195, 28);
                pictureBox1.Location = new Point(12, 28);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        // Changes form size, and positions controls to allow player to pick a player
        private void btnReturningPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // Make first pair of buttons invisible
                btnNewPlayer.Visible = false;
                btnReturningPlayer.Visible = false;

                // Set the form size
                this.Size = new Size(290, 330);

                // Make Graphic labels visable
                pictureBox1.Visible = true;
                lblLabel4.Visible = true;
                lblUnderline4.Visible = true;
                comboBox1.Visible = true;
                comboBox1.Location = new Point(25, 56);
                lblLabel3.Visible = true;
                lblUnderline2.Visible = true;
                lblAICount.Visible = true;
                lblUnderline3.Visible = true;
                trackBar1.Visible = true;
                lblSlogan.Visible = true;
                btnPlay.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        



        // TODO: Work on track bar, Limited game to 4 players
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (trackBar1.Value == 1)
                {
                    lblAICount.Text = "1";
                }
                else if (trackBar1.Value == 2)
                {
                    lblAICount.Text = "2";
                }
                else if (trackBar1.Value == 3)
                {
                    lblAICount.Text = "3";
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Picture box is functioning back button on this form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Shrink form
                this.Size = new Size(335, 112);

                // Make sure button is positioned correctly
                btnNewPlayer.Location = new Point(12, 26);

                // Get rid of un needed buttons
                btnAddPlayer.Visible = false;
                tbNewPlayer.Visible = false;
                pictureBox1.Visible = false;

                // Get rid of everything not needed to add a player to the game
                lblLabel4.Visible = false;
                lblUnderline4.Visible = false;
                comboBox1.Visible = false;
                lblLabel3.Visible = false;
                lblUnderline2.Visible = false;
                lblAICount.Visible = false;
                lblUnderline3.Visible = false;
                trackBar1.Visible = false;
                lblSlogan.Visible = false;
                btnPlay.Visible = false;

                // Display only whats needed to the player
                btnNewPlayer.Visible = true;
                btnReturningPlayer.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}
