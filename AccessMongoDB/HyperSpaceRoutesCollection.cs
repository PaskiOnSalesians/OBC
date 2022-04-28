using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;
using MongoDB.Driver;

namespace AccessMongoDB
{
    public class HyperSpaceRoutesCollection
    {
        private static IMongoCollection<HyperSpaceRoutes> HyperSpaceRoutesCollections = ConnectMongoDB.db.GetCollection<HyperSpaceRoutes>("hyperspaceRoutes");
    }
}
