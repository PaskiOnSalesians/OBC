using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB
{
    public class AllCollections
    {
        public List<string> GetCollections()
        {
            List<string> collections = new List<string>();

            foreach (BsonDocument collection in ConnectMongoDB.db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                string name = collection["name"].AsString;
                collections.Add(name);
            }

            return collections;
        }
    }
}
