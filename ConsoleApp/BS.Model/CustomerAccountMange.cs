using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class CustomerAccountManage : Generics<int, DateTime>
    {
        public long accountNumber { get; set; }
        public int accountType { get; set; }
        public long accountBalance { get; set; }
        public string branch { get; set; }
        public string ifscCode { get; set; }
        public int customerInformationId { get; set; }
    }
}
