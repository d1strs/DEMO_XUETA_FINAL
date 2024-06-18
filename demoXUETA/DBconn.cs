using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoXUETA
{
    internal class DBconn
    {
        private DBconn() { }

        public static demoGovnaEntities DB = new demoGovnaEntities();
    }
}
