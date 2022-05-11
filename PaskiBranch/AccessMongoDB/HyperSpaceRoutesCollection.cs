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
        private static IMongoCollection<HyperSpaceRoute> HyperSpaceRoutesCollections = ConnectMongoDB.db.GetCollection<HyperSpaceRoute>("hyperspaceRoutes");

        public static List<HyperSpaceRoute> SelectAll()
        {
            List<HyperSpaceRoute> hyperSpaceRoutes = HyperSpaceRoutesCollections.Find(c => true).ToList();
            return hyperSpaceRoutes;
        }

        public static HyperSpaceRoute SelectById(ObjectId id)
        {
            HyperSpaceRoute hyperSpaceRoutes = (HyperSpaceRoute)HyperSpaceRoutesCollections.Find(c => c.Id == id);
            return hyperSpaceRoutes;
        }

        public static void Insert(HyperSpaceRoute hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.InsertOne(hyperSpaceRoutes);
        }

        public static void Update(HyperSpaceRoute hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.ReplaceOne(c => c.Id == hyperSpaceRoutes.Id, hyperSpaceRoutes);
        }

        public static void Delete(HyperSpaceRoute hyperSpaceRoutes)
        {
            HyperSpaceRoutesCollections.DeleteOne(c => c.Id == hyperSpaceRoutes.Id);
        }
    }
}
