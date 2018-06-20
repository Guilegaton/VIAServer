using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            new VIAServer<JSONSerializer<Event>>(8080);
        }
    }
}
