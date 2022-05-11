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
    public class Planet
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("name")]

        public string Nombre { get; set; }

        [BsonElement("sector")]

        public string Sector { get; set; }

        [BsonElement("filiation")]

        public string Filiation { get; set; }

        [BsonElement("situation")]

        public PlanetSituation Situation { get; set; }

        [BsonElement("hyperspaceRoute")]

        public PlanetRoute HyperSpaceRoute { get; set; }

        [BsonElement("natives")]

        public string Natives { get; set; }




    }
}
