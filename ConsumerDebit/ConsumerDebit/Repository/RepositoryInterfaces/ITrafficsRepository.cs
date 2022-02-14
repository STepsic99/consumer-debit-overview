using ConsumerDebit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Repository.RepositoryInterfaces
{
    public interface ITrafficsRepository
    {
        public List<Traffic> GetAllTrafficForUser(string id);
    }
}
