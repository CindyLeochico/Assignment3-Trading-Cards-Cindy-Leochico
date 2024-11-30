using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendingCards
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Team { get; set; }
        public string? Position { get; set; } // Nullable string
        public int Points { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Steals { get; set; }
        public string? PhotoPath { get; set; } // Nullable string
    }

}
