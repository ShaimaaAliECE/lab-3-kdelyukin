using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
        }

        // AddMe method is inherited from Collectable
    }
}
