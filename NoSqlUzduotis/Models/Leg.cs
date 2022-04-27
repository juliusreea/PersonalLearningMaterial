using MongoDB.Bson;

namespace NoSqlUzduotis.Models
{
    public class Leg
    {
        public string Material { get; set; }
        public int NumbersOfJoints { get; set; }
        public int SizeOfFoot { get; set; }
    }
}
