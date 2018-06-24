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
                comboBox1.Text = "Noob";

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {


                //create a delimiter array
                char[] delim = { ',' };

                // Declare a Streamwriter variable
                StreamWriter outputFile;

                outputFile = File.AppendText("GutsPlayers.txt");

                string var = tbNewPlayer.Text;

                comboBox2.Items.Add(var);

                outputFile.WriteLine(var);

                // close file
                outputFile.Close();

                MessageBox.Show("Player Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Last button on the page before the game starts
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the variable on the main form 
                frmOne.PlayerNames[0] = comboBox1.Text;

                this.Hide();        // Hide this form

                frmOne.ShowDialog();    // Show next form

                this.Close();       // Dispose of this form
            }
            catch
            {
                MessageBox.Show(" A player might need assosiated with a score");
            }
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Stream reader variable
                string text = "";

                // Declare a Stream Reader
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("");

                //create a delimiter array
                char[] delim = { ',' };

                // Read the files contents
                while (!inputFile.EndOfStream)
                {
                    text =  inputFile.ReadLine();
                }

                // Close the file
                inputFile.Close();

                // Display help information for the user 
                MessageBox.Show(text.ToString());
            }
            catch
            {

            }
            }
    }
}
