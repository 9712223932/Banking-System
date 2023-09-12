using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class CustomerInformation : Generics<DateTime>
    {
        public int CustomerInformationId { get; set; }
        public string CustomerName { get; set; }
        public long CustomerMobileNumber { get; set; }
        public string CustomerAddress { get; set; }      

    }
}
