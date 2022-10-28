using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaSensor.Repositories;
using SeaSensor.Repositories.Models;

namespace SeeSensor.Repositories.MongoDB
{
    public class MongoSeeSensorRepository : ISeaSensorRepository
    {
        public SeaSensorRepoResponse addData(RepoSeaSensorData repoSeaSensor)
        {
            throw new NotImplementedException();
        }

        public RepoSeaSensorData addStatus(RepoSeaSensorStatus repoSeaSensor)
        {
            throw new NotImplementedException();
        }
    }
}
