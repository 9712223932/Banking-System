using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class Bank : Generics<DateTime>
    {
        public int BankId { get; set; }
        public string BankerName { get; set; }
        public int BranchId { get; set; }
    }
}
