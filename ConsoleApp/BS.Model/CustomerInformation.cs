using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class CustomerInformation : Generics<int, DateTime>
    {
        public string customerName { get; set; }
        public long customerMobileNumber { get; set; }
        public string customerAddress { get; set; }

    }
}
