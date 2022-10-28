using SeaSensor.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaSensor.Repositories
{
    public interface ICarparkRepository
    {
        public SeaSensorRepoResponse addData(RepoSeaSensor repoSeaSensor);
        public RepoSeaSensor addStatus();

    }
}