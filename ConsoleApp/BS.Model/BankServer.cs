using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class BankServer : Generics<DateTime>
    {
        public int BankServerId { get; set; }
        public int CustomerAccountManageId { get; set; }
        public int TransectionId { get; set; }
        public int CreditCardDetailID { get; set; }
        public int LoanID { get; set; }
    }
}
