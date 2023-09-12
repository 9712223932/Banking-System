using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class AccountorTransectionType : Generics<DateTime>
    {
        public int AccountorTransectionTypeId { get; set; }
        public string AccountorTransectionTypeName { get; set; }
    }
}
