using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB.Schemas
{
    public class Filiation
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("description")]

        public string Description { get; set; }
    }
}
