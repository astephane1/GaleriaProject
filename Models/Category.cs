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

namespace GaleriaProject.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Id_Category")]
        [Required]
        public int Id_Category { get; set; }

        [BsonElement("Name_Category")]
        [Required]
        public string Name_Category{ get; set; }

        [BsonElement("Description_Category")]
        [Required]
        public string Description_Category { get; set; }

     
        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public string ImageUrl { get; set; }


        private readonly IMongoCollection<Category> category;
        
        public Category(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("ArtGalleryDb"));
            IMongoDatabase database = client.GetDatabase("ArtGalleryDb");
            category = database.GetCollection<Category>("CategoryCollection");
        }

        public List<Category> Get()
        {
            return category.Find(category => true).ToList();
        }

        public Category Get(string id)
        {
            return category.Find(category => category.Id == id).FirstOrDefault();
        }
        public Category GetCategory(int id)
        {
            return category.Find(category => category.Id_Category == id).FirstOrDefault();
        }

    }
}
