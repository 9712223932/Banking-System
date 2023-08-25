using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class Transection : Generics<int, DateTime>
    {
        public int transectionType { get; set; }
        public long transectionAmmount { get; set; }
    }
}
