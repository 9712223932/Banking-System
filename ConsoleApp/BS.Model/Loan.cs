using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class Loan : Generics<int, DateTime>
    {
        public  int LoanType { get; set; }
        public  int LoanNumber { get; set; }
        public  int IssuedLoanAmount { get; set; }
        public  int RemainingLoanAmmount { get; set; }
        public  int BranchId { get; set; }
        public  int CustomerAccountManageId { get; set; }
    }
}
