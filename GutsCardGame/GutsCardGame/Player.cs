using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutsCardGame
{
    class Player
    {
        private string _playerName; // Holds player name
        
        private double pbank;
        private double cbank;



        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }
        
        public double BankAmount
        {
            get { return cbank; }
            set { cbank = value; }
        }

        

        public Player(string PlayerName, double BankAmount)
        {
            _playerName = PlayerName;
            pbank = BankAmount;
        }

    }
}
