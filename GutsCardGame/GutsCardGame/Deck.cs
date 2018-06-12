using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutsCardGame
{
    class Deck
    {

        private int cardPick;
        private int cardPick1;
        private int cardPick2;
        private int cardPick3;
        private int cardPick4;

        public int CardPick
        {
            get { return cardPick; }
            set { cardPick = value; }
        }

        public int CardPick2
        {
            get { return cardPick2; }
            set { cardPick2 = value; }
        }

        public int CardPick3
        {
            get { return cardPick3; }
            set { cardPick3 = value; }
        }

        public int CardPick4
        {
            get { return cardPick4; }
            set { cardPick4 = value; }
        }

        public CardPicks (int Cardpick)
    }
}
