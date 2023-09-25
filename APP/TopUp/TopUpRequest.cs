using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUp
{
    public class TopUpRequest
    {
        public int accountId { get; set; } 
        public double amount { get; set; }
    }
}
