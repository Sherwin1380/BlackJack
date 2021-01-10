using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJGU
{

    class CARD
    {
        public string Face;
        public string Suit;
        public int Score;

        public CARD(string face, string suit, int score)
        {
            this.Face = face;
            this.Suit = suit;
            this.Score = score;
        }

    }
}