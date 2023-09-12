using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class Transection : Generics<DateTime>
    {
        public int TransectionId { get; set; }
        public int TransectionType { get; set; }
        public long TransectionAmmount { get; set; }
        public int TransectionMethod { get; set; }
        public int CustomerAccountManageId { get; set; }

    }
}
