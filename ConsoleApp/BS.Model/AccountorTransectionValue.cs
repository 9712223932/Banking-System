using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class AccountorTransectionValue : Generics<DateTime>
    {
        public int AccountorTransectionValueId { get; set; }
        public string AccountorTransectionValueName { get; set; }
        public int AccountorTransectionTypeId { get; set; }
    }
}
