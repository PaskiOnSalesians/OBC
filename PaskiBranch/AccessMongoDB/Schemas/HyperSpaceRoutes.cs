using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB.Schemas
{
    public class HyperSpaceRoutes
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("type")]

        public string Type { get; set; }

        [BsonElement("nameRoute")]

        public string NameRoute { get; set; }

        [BsonElement("start")]

        public string Start { get; set; }

        [BsonElement("end")]

        public string End { get; set; }

    }
}
