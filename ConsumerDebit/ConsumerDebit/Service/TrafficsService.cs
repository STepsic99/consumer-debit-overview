using ConsumerDebit.Model;
using ConsumerDebit.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Service
{
    public class TrafficsService
    {
        ITrafficsRepository trafficsRepository;

        public TrafficsService(ITrafficsRepository trafficsRepository)
        {
            this.trafficsRepository = trafficsRepository;
        }

        public List<Traffic> GetAllTrafficForUser(string id)
        {
            List<Traffic> traffics = trafficsRepository.GetAllTrafficForUser(id);
            CalculateSaldo(traffics);
            return traffics;
        }

        private void CalculateSaldo(List<Traffic> traffics)
        {
            for(int i = 0; i < traffics.Count; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    traffics[i].Saldo += traffics[j].Owes - traffics[j].Claims;
                }
            }
        }
    }
}
