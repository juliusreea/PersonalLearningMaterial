using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlPaskaita
{
    internal class Playlist
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public List<string> Items { get; set; }
        public DateTime CreatedTime { get; set; }

        public Playlist(string username)
        {
            Username = username;
            Items = new List<string>();
        }
    }
}
