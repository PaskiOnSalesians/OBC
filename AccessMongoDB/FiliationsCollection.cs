using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessMongoDB.Schemas;

namespace AccessMongoDB
{
    public class FiliationsCollection
    {
        private static IMongoCollection<Filiations> filiationsCollections = ConnectMongoDB.db.GetCollection<Filiations>("filiations");
    }
}
