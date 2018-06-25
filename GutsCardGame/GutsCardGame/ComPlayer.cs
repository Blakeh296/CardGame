using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutsCardGame
{
    class ComPlayer
    {
        private string _ComPlayerName; // Holds Computer name

        private double comBank;


        public string ComPlayerName
        {
            get { return _ComPlayerName; }
            set { _ComPlayerName = value; }
        }
        public double ComBankAmount
        {
            get { return comBank; }
            set { comBank = value; }
        }

        public ComPlayer(string ComPlayerName, double ComBankAmount)
        {
            _ComPlayerName = ComPlayerName;
            comBank = ComBankAmount;
        }
        
    }
}
