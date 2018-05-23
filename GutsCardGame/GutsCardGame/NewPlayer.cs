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
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
        }

        GutsMainForm frmOne = new GutsMainForm();

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            try
            {
                // Declare a Streamwriter variable
                StreamWriter outputFile;

                outputFile = File.AppendText("GutsPlayers.txt");

                string var = textBox1.Text;

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

        private void NewPlayer_Load(object sender, EventArgs e)
        {
            string players;

            try
            {
                // Declare a Stream Reader
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("GutsPlayers.txt");

                // Read the files contents
                while (!inputFile.EndOfStream)
                {
                    // Get player name
                    players = inputFile.ReadLine();

                    // Add the player name to the combobox
                    comboBox1.Items.Add(players);
                }

                // Close the file
                inputFile.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmOne.player1 = comboBox1.SelectedItem.ToString();

            frmOne.aI = int.Parse(lblAICount.Text);

            frmOne.ShowDialog();

            this.Close();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 2)
            {
                lblAICount.Text = "2";
            }
            else if (trackBar1.Value == 3)
            {
                lblAICount.Text = "3";
            }
            else if (trackBar1.Value == 4)
            {
                lblAICount.Text = "4";
            }
            else if (trackBar1.Value == 5)
            {
                lblAICount.Text = "5";
            }
            else if (trackBar1.Value == 6)
            {
                lblAICount.Text = "6";
            }
            else if (trackBar1.Value == 7)
            {
                lblAICount.Text = "7";
            }
            else if (trackBar1.Value == 8)
            {
                lblAICount.Text = "8";
            }
            else if (trackBar1.Value == 9)
            {
                lblAICount.Text = "9";
            }
            else if (trackBar1.Value == 10)
            {
                lblAICount.Text = "10";
            }
        }
    }
}
