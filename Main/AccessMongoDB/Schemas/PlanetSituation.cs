using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB.Schemas
{
    public class PlanetSituation
    {
        [BsonElement("long")]

        public string Long { get; set; }

        [BsonElement("lat")]

        public string Lat { get; set; }

        [BsonElement("parsecs")]

        public string Parsecs { get; set; }
    }
}
