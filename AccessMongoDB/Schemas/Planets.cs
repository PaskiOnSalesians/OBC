using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;



namespace AccessMongoDB.Schemas
{
    public class Planets
    {
        [BsonId]
        public static ObjectId Id { get; set; }

        [BsonElement("name")]

        public string Nombre { get; set; }

        [BsonElement("sector")]

        public string Sector { get; set; }

        [BsonElement("filiation")]

        public string Filiation { get; set; }

        [BsonElement("situation")]

        public List<PlanetSituation> Situation { get; set; }

        [BsonElement("hyperspaceRoute")]

        public List<PlanetRoute> HyperSpaceRoute { get; set; }

        [BsonElement("natives")]

        public string Natives { get; set; }




    }
}
