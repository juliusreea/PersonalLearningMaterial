using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class Team
    {
        public string Name { get; set; }
        public int Wins;
        public int Losses;

        public Team(string name, int wins, int losses)
        {
            Name = name;
            Wins = wins;
            Losses = losses;
        }
        public override string ToString()
        {
            return $"{Name} wins: {Wins}, Losses {Losses}";
        }
    }

}
