using MongoDB.Bson;

namespace NoSqlUzduotis.Models
{
    public class Arm
    {
        public ObjectId Id { get; set; }
        public string Material { get; set; }
        public int NumberOfJoints { get; set; }
        public int NumberOfFingers { get; set; }

    }
}
