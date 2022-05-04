using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;
using MongoDB.Bson;

namespace AccessMongoDB
{
    public class RegionsCollection
    {
        private static IMongoCollection<Regions> RegionsCollections = ConnectMongoDB.db.GetCollection<Regions>("regions");

        public static List<Regions> SelectAll()
        {
            List<Regions> regiones = RegionsCollections.Find(c => true).ToList();
            return regiones;
        }

        public static Regions SelectById(ObjectId id)
        {
            Regions regiones = (Regions)RegionsCollections.Find(c => c.Id == id);
            return regiones;
        }

        public static void Insert(Regions regiones)
        {
            RegionsCollections.InsertOne(regiones);
        }

        public static void Update(Regions regiones)
        {
            RegionsCollections.ReplaceOne(c => c.Id == regiones.Id, regiones);
        }

        public static void Delete(Regions regiones)
        {
            RegionsCollections.DeleteOne(c => c.Id == regiones.Id);
        }
    }
}
