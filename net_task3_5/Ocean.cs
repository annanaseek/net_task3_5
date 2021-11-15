using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task3_5
{
    class Ocean
    {
        private string name;

        public Ocean(string oceanName)
        {
            name = oceanName;
        }

        public string GetOceanName()
        {
            return name;
        }
    }
}
