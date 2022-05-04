using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB.Schemas
{
    public class PlanetRoute
    {
        [BsonElement("route")]

        public string[] Route { get; set; }
    }
}
