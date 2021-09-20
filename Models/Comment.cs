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
    public class Comment
    {

        [BsonElement("EmailOrPhoneContact")]
        [Required]
        public string EmailOrPhoneContact { get; set; }

        [BsonElement("Subject")]
        [Required]
        public string Subject { get; set; }

        [BsonElement("commentary")]
        [Required]
        public string commentary { get; set; }


        public Comment Create(Comment submission)
        {
            var dbClient = new MongoClient("mongodb://127.0.0.1:27017");

            IMongoDatabase db = dbClient.GetDatabase("ArtGalleryDb");

            var cars = db.GetCollection<Comment>("CommentsCollection");
           

            cars.InsertOne(submission);
            return submission;
        }

    }
}
