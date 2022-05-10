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
        private static IMongoCollection<Region> RegionsCollections = ConnectMongoDB.db.GetCollection<Region>("regions");

        public static List<Region> SelectAll()
        {
            List<Region> regiones = RegionsCollections.Find(c => true).ToList();
            return regiones;
        }

        public static Region SelectById(ObjectId id)
        {
            Region regiones = (Region)RegionsCollections.Find(c => c.Id == id);
            return regiones;
        }

        public static void Insert(Region regiones)
        {
            RegionsCollections.InsertOne(regiones);
        }

        public static void Update(Region regiones)
        {
            RegionsCollections.ReplaceOne(c => c.Id == regiones.Id, regiones);
        }

        public static void Delete(Region regiones)
        {
            RegionsCollections.DeleteOne(c => c.Id == regiones.Id);
        }
    }
}
