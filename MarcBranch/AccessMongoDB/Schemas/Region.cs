using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB.Schemas
{
    public class Region
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nameRegion")]

        public string NameRegion { get; set; }

        [BsonElement("descriptionRegion")]

        public string DescriptionRegion { get; set; }

        [BsonElement("mapRegion")]

        public string MapRegion { get; set; }


    }
}
