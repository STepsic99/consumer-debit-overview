using ConsumerDebit.Model;
using ConsumerDebit.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Repository
{
    public class TrafficsRepository : ITrafficsRepository
    {
        private ConsumerDebitDbContext dbContext = new ConsumerDebitDbContext();
        public List<Traffic> GetAllTrafficForUser(string id)
        {
            return dbContext.Traffics.Where(t => t.UserId == id).ToList();
        }
    }
}
