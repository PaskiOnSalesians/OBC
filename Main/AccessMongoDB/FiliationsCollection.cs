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
        private static IMongoCollection<Filiations> FiliationsCollections = ConnectMongoDB.db.GetCollection<Filiations>("filiations");
        public static List<Filiations> SelectAll()
        {
            List<Filiations> filiations = FiliationsCollections.Find(c => true).ToList();
            return filiations;
        }

        public static Filiations SelectById(ObjectId id)
        {
            Filiations filiations = (Filiations)FiliationsCollections.Find(c => c.Id == id);
            return filiations;
        }

        public static void Insert(Filiations filiations)
        {
            FiliationsCollections.InsertOne(filiations);
        }

        public static void Update(Filiations filiations)
        {
            FiliationsCollections.ReplaceOne(c => c.Id == filiations.Id, filiations);
        }

        public static void Delete(Filiations filiations)
        {
            FiliationsCollections.DeleteOne(c => c.Id == filiations.Id);
        }
    }
}
