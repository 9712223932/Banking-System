using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model.Generic
{
    public class Generics<Y>
    {
        public Y createdon { get; set; }        
    }
}
