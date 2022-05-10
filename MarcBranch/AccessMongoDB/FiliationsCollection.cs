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
    public class FiliationsCollection
    {
        private static IMongoCollection<Filiation> FiliationsCollections = ConnectMongoDB.db.GetCollection<Filiation>("filiations");
        public static List<Filiation> SelectAll()
        {
            List<Filiation> filiations = FiliationsCollections.Find(c => true).ToList();
            return filiations;
        }

        public static Filiation SelectById(ObjectId id)
        {
            Filiation filiations = (Filiation)FiliationsCollections.Find(c => c.Id == id);
            return filiations;
        }

        public static void Insert(Filiation filiations)
        {
            FiliationsCollections.InsertOne(filiations);
        }

        public static void Update(Filiation filiations)
        {
            FiliationsCollections.ReplaceOne(c => c.Id == filiations.Id, filiations);
        }

        public static void Delete(Filiation filiations)
        {
            FiliationsCollections.DeleteOne(c => c.Id == filiations.Id);
        }
    }
}
