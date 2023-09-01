using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class LoanPayment  : Generics<int, DateTime>
    {

        public long PaymentAmount { get; set; }
        public int LoanID { get; set; }
        
    }
}
