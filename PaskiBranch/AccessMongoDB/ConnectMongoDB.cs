using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMongoDB
{
    public class ConnectMongoDB
    {
        public static MongoClient client = new MongoClient("mongodb+srv://paskiuser:12345aA.mongo@cluster-proyectos.gf00e.mongodb.net/test");
        public static IMongoDatabase db = client.GetDatabase("On-Board_Computer");
    }
}
