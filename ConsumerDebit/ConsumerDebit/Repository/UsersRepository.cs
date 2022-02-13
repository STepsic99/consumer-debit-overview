using ConsumerDebit.Model;
using ConsumerDebit.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private ConsumerDebitDbContext dbContext = new ConsumerDebitDbContext();
        public User FindUser(string username, string password)
        {
            return dbContext.Users.Where(u => u.Owner == username && u.Password== password).SingleOrDefault();
        }
    }
}
