using AccessMongoDB.Schemas;
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
        private static IMongoCollection<Planets> planetsCollections = ConnectMongoDB.db.GetCollection<Planets>("planets");
        //public static List<string> SelectAll()
        //{

        //}
    }
}
