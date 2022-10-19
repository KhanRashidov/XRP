using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRP.Console
{
    public class Param
    {
        public string account { get; set; }
        public bool strict { get; set; }
        public string ledger_index { get; set; }
        public  bool queue { get; set; }
    }
}
