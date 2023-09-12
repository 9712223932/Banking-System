using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class CustomerAccountManage : Generics<DateTime>
    {
        public int CustomerAccountManageId { get; set; }
        public long AccountNumber { get; set; }
        public int AccountType { get; set; }
        public long AccountBalance { get; set; }
        public int BranchId { get; set; }
        public int CustomerInformationId { get; set; }
    }
}
