using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task3_5
{
    class Continent
    {
        private string name;

        public Continent(string continentName)
        {
            name = continentName;
        }

        public string GetContinentName()
        {
            return name;
        }
    }
}
