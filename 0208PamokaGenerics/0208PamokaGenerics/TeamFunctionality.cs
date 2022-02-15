using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class TeamFunctionality
    {
        public void TeamPrinter(TeamRepository teams)
        {
            var sortedTeams = teams.Teams.OrderByDescending(o => o.Wins).ToList();
            foreach (var team in sortedTeams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
