using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;

namespace AccessMongoDB
{
    public class RegionsCollection
    {
        private static IMongoCollection<Regions> RegionsCollections = ConnectMongoDB.db.GetCollection<Regions>("regions");
    }
}
