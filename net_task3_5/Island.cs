using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task3_5
{
    class Island
    {
        private string name;

        public Island(string islandName)
        {
            name = islandName;
        }

        public string GetIslandName()
        {
            return name;
        }
    }
}
