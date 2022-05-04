using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AccessMongoDB
{
    public class HyperSpaceRoutesCollection
    {
        private static IMongoCollection<HyperSpaceRoutes> HyperSpaceRoutesCollections = ConnectMongoDB.db.GetCollection<HyperSpaceRoutes>("hyperspaceRoutes");

        public static List<HyperSpaceRoutes> SelectAll()
        {
            List<HyperSpaceRoutes> hyperSpaceRoutes = HyperSpaceRoutesCollections.Find(c => true).ToList();
            return hyperSpaceRoutes;
        }

        public static HyperSpaceRoutes SelectById(ObjectId id)
        {
            HyperSpaceRoutes hyperSpaceRoutes = (HyperSpaceRoutes)HyperSpaceRoutesCollections.Find(c => c.Id == id);
            return hyperSpaceRoutes;
        }

        public static void Insert(HyperSpaceRoutes hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.InsertOne(hyperSpaceRoutes);
        }

        public static void Update(HyperSpaceRoutes hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.ReplaceOne(c => c.Id == hyperSpaceRoutes.Id, hyperSpaceRoutes);
        }

        public static void Delete(HyperSpaceRoutes hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.DeleteOne(c => c.Id == hyperSpaceRoutes.Id);
        }
    }
}
