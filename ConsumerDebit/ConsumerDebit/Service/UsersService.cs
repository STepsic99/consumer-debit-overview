using ConsumerDebit.Model;
using ConsumerDebit.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Service
{
    public class UsersService
    {
        IUsersRepository usersRepository;


        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public User FindUser(string username, string password)
        {
            return usersRepository.FindUser(username, password);
        }
    }
}
