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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoosePlayer_Click(object sender, EventArgs e)
        {
            
            PlayerPicker var = new PlayerPicker();        // Get the next form ready to open

            this.Hide();                        // Hide this form

            var.ShowDialog();                       // Display next form

            this.Close();                       // Close this form
        }
    }
}
