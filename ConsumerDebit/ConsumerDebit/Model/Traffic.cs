using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Model
{
    public class Traffic
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Document { get; set; }
        public int Owes { get; set; }
        public int Claims { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
