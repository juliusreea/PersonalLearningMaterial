using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSqlPaskaita
{
    internal class Page
    {
        public ObjectId Id { get; set; }
        public string Content { get; set; }

        public Page()
        {
        }
    }
}
