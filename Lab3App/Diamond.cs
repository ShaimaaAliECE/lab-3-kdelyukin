using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string description, int score)
        {
            Description = description;
            Score = score;
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond {Description} is displayed");
        }

        public override void AddMe(List<Collectable> collectedItems)
        {
            collectedItems.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            UpdateTotalScore();
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}