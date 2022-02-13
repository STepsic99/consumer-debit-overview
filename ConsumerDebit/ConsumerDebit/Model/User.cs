using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Model
{
    public class User
    {
        [Key]
        public string IDUser { get; set; }
        public string Owner { get; set; }
        public string Password { get; set; }
    }
}
