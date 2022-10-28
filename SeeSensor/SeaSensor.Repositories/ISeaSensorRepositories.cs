using SeaSensor.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories
{
    public interface ISeaSensorRepository
    {
        public SeaSensorRepoResponse addData(RepoSeaSensorData repoSeaSensor);
        public RepoSeaSensorData addStatus(RepoSeaSensorStatus repoSeaSensor);

    }
}