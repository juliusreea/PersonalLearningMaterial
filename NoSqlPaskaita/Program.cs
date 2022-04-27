using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace NoSqlPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb+srv://juliusreea:Menulius16+@cluster0.p177r.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var booklist = client.GetDatabase("Booklist").GetCollection<Book>("Book");

            Book book = new Book("grybai");
            booklist.InsertOne(book);

            //var playlistCollection = client.GetDatabase("Playlist").GetCollection<Playlist>("Playlist");

            //var playlist = new Playlist("user1");
            //var songs = new List<string>
            //{
            //    "highway to hell"
            //};
            //playlist.Items = songs;
            //playlist.CreatedTime = DateTime.Now;

            //playlistCollection.InsertOne(playlist);

            //var filter = Builders<Playlist>.Filter.Eq("Username", "user1");
            //var results = playlistCollection.Find(filter).ToList();

            //var filter2 = Builders<Playlist>.Filter.Eq("_id", "6241e25c8e13ee6ab99bfffd");
            //var results2 = playlistCollection.DeleteOne(filter);

            //var filter3 = Builders<Playlist>.Filter.Eq("_id", "6241e25c8e13ee6ab99bfffd");
            //var update = Builders<Playlist>.Update.AddToSet("Items", "Song1");
            //playlistCollection.UpdateOne(filter3, update);





        }
    }
}
