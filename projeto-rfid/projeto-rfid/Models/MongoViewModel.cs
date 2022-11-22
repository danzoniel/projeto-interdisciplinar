using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projeto_rfid.Models
{
    public class MongoViewModel
    {
        public ObjectId _id;
        public string attrValue { get; set; }
    }

}
