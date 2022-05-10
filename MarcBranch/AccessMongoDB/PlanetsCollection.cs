using AccessMongoDB.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB
{
    public class PlanetsCollection
    {
        private static IMongoCollection<Planet> PlanetsCollections = ConnectMongoDB.db.GetCollection<Planet>("planets");
        public static List<Planet> SelectAll()
        {
            List<Planet> planetas = PlanetsCollections.Find(c => true).ToList();
            return planetas;
        }

        public static Planet SelectById(ObjectId id)
        {
            Planet planetas = (Planet)PlanetsCollections.Find(c => c.Id == id);
            return planetas;
        }

        public static void Insert(Planet planeta)
        {
            PlanetsCollections.InsertOne(planeta);
        }

        public static void Update(Planet planeta)
        {
            PlanetsCollections.ReplaceOne(c => c.Id == planeta.Id, planeta);
        }

        public static void Delete(Planet planeta)
        {
            PlanetsCollections.DeleteOne(c => c.Id == planeta.Id);
        }
    }
}
