using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class LoanPayment  : Generics<DateTime>
    {
        public int LoanPaymentID { get; set; }
        public long PaymentAmount { get; set; }
        public int LoanID { get; set; }
        
    }
}
