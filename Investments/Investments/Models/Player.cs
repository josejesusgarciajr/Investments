using System;
namespace Investments.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public char C { get; set; }
        public string BoarderColor { get; set; }

        public string CelebrationGifPath { get; set; }

        public Player() {}

        public Player(string name)
        {
            Name = name;
        }
    }
}
