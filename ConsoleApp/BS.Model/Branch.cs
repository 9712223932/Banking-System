using BS.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model
{
    public class Branch :Generics<int,DateTime>
    {
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string BranchIFSC { get; set; }
    }
}
