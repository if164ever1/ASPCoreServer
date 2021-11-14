using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreServer
{
    public class Message
    {
        public  string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
