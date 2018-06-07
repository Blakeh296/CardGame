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
        private string pName; // Playername 
      

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public Player(string PlayerName)
        {
            _playerName = PlayerName;
        }

    }
}
