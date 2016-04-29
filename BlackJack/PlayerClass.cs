using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class PlayerClass
    {

        public Player()
        {
            Score = 0;
            TurnEnd = false;
            Busted = false;
            SixCardWin = false;
        }

        public int Score { get; set; }
        public bool TurnEnd { get; set; }
        public bool Busted { get; set; }
        public bool SixCardWin { get; set; }
        public int NumberOfAces { get; set; }

        public List<int> PosibleScores = new List<int>();

        public void ShowHand()
        {
            foreach (Card c in Hand)
            {
                c.Show();
            }
        }

        public void SetScore()
        {
            Score = 0;
            foreach (Card c in Hand)
            {
                Score += c.Value();
            }
        }


        public List<Card> Hand = new List<Card>();

    }
}

