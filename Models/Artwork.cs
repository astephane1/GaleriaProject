using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;
using GaleriaProject.Models;
using System.ComponentModel.DataAnnotations;
using GaleriaProject.CustomAttributes;
using Microsoft.Extensions.Configuration;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace GaleriaProject.Models
{
    public class Artwork
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Id_Category")]
        [Required]
        public int Id_Category { get; set; }

        [BsonElement("Name_Artwork")]
        [Required]
        public string Name_Artwork { get; set; }

        [BsonElement("Description_Artwork")]
        [Required]
        public string Description_Artwork { get; set; }

        [BsonElement("Url_Image")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public string Url_Image { get; set; }

        [BsonElement("Date")]
        [Required]
        [YearRange]
        public string Date { get; set; }

        [BsonElement("Author_Name")]
        [Required]
        public String Author_Name { get; set; }

        [BsonElement("Likes")]
        public int Likes { get; set; }

        [BsonElement("TotalLikes")]
        public int TotalLikes { get; set; }



        private readonly IMongoCollection<Artwork> artwork;

        public Artwork(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("ArtGalleryDb"));
            IMongoDatabase database = client.GetDatabase("ArtGalleryDb");
            artwork = database.GetCollection<Artwork>("CollectionArtwork");
        }

        public List<Artwork> Get()
        {
            return artwork.Find(artwork => true).ToList();
        }

        public Artwork Get(string id)
        {
            return artwork.Find(artwork => artwork.Id == id).FirstOrDefault();
        }
        public List<Artwork> GetArt(int id)
        {
            return artwork.Find(artwork => artwork.Id_Category == id).ToList();
            //return artwork.Find(id);
        }

        public Artwork GetArtwork(string id)
        {
            return artwork.Find(artwork => artwork.Id == id).FirstOrDefault();
        }


        public void LikeArtwork(string id, int like)
        {
            int LastTotal = GetTotal(id);
            int LastLikes = GetLikes(id);
            // Create an equality filter
            var filter = Builders<Artwork>.Filter
                .Eq(artwork => artwork.Id, id);

            // Create an update definition using the Set operator    
            var updateLikes = Builders<Artwork>.Update
                .Set(artwork => artwork.Likes, LastLikes+like);
            //Total
            var updateTotal = Builders<Artwork>.Update
                .Set(artwork => artwork.TotalLikes, LastTotal+1);

            // Update the document
            var LikesUpdateResult = artwork.UpdateOneAsync(filter, updateLikes);
            var TotalUpdateResult = artwork.UpdateOneAsync(filter, updateTotal);

        }

        public int GetLikes(string id)
        {
            Artwork findArt = artwork.Find(artwork => artwork.Id == id).FirstOrDefault();
            return findArt.Likes;
        }

        public int GetTotal(string id)
        {
            Artwork findArt = artwork.Find(artwork => artwork.Id == id).FirstOrDefault();
            return findArt.TotalLikes;
        }

    }
}