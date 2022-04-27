using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlUzduotis.Models
{
    public class Robot
    {
        public ObjectId Id { get; set; }

        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
        public List<Torso> Torsos { get; set; }
        public Head Heads { get; set; }

    }
}
