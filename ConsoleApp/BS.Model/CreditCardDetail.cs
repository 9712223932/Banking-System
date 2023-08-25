using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class CreditCardDetail : Generics<int, DateTime>
    {
        public int CardNumber { get; set; }
        public int CardLimit { get; set; }
    }
}
