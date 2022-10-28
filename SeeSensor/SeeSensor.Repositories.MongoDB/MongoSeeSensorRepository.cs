using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using SeaSensor.Repositories;
using SeaSensor.Repositories.Models;
using SeeSensor.Repositories.MongoDB.Models;

namespace SeeSensor.Repositories.MongoDB
{
    public class MongoSeeSensorRepository : ISeaSensorRepository
    {
        private readonly IMongoCollection<SeeSensorMongoPersistenceModelStatus> statusCollection;
        private readonly IMongoCollection<SeeSensorMongoPersistenceModelData> dataCollection;

        public MongoSeeSensorRepository(IMongoDatabase mongoDatabase)
        {
            statusCollection = mongoDatabase.GetCollection<SeeSensorMongoPersistenceModelStatus>("SeaSensorStatus");
            dataCollection = mongoDatabase.GetCollection<SeeSensorMongoPersistenceModelData>("SeaSensorData");
        }

        public SeaSensorRepoResponse addData(RepoSeaSensorData repoSeaSensor)
        {
            var dataQuantity = dataCollection.CountDocuments(DataAll());

            dataCollection.InsertOne(repoSeaSensor.ToMongoPersistenceSeaSensorData());

            if(dataQuantity + 1 == dataCollection.CountDocuments(DataAll())) { 
                return SeaSensorRepoResponse.Success;
            }

            return SeaSensorRepoResponse.Unsuccessful;
        }

        public SeaSensorRepoResponse addStatus(RepoSeaSensorStatus repoSeaSensor)
        {
            var statusQuantity = statusCollection.CountDocuments(StatusAll());

            statusCollection.InsertOne(repoSeaSensor.ToMongoPersistenceSeaSensorStatus());

            if (statusQuantity + 1 == statusCollection.CountDocuments(StatusAll()))
            {
                return SeaSensorRepoResponse.Success;
            }

            return SeaSensorRepoResponse.Unsuccessful;
        }


        private static FilterDefinition<SeeSensorMongoPersistenceModelData> DataAll() => Builders<SeeSensorMongoPersistenceModelData>.Filter.Empty;
        private static FilterDefinition<SeeSensorMongoPersistenceModelStatus> StatusAll() => Builders<SeeSensorMongoPersistenceModelStatus>.Filter.Empty;

    }
}
