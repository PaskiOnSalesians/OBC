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
        private static IMongoCollection<Planets> PlanetsCollections = ConnectMongoDB.db.GetCollection<Planets>("planets");
        public static List<Planets> SelectAll()
        {
            List<Planets> planetas = PlanetsCollections.Find(c => true).ToList();
            return planetas;
        }

        public static Planets SelectById(ObjectId id)
        {
            Planets planetas = (Planets)PlanetsCollections.Find(c => c.Id == id);
            return planetas;
        }

        public static void Insert(Planets planeta)
        {
            PlanetsCollections.InsertOne(planeta);
        }

        public static void Update(Planets planeta)
        {
            PlanetsCollections.ReplaceOne(c => c.Id == planeta.Id, planeta);
        }

        public static void Delete(Planets planeta)
        {
            PlanetsCollections.DeleteOne(c => c.Id == planeta.Id);
        }
    }
}
