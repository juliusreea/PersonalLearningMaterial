using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208PamokaGenerics
{
    internal class TeamRepository
    {
        public List<Team>Teams { get; set; }

        public TeamRepository()
        {
            Teams = new List <Team>();
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }
    }
}
