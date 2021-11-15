using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_task3_5
{
    class Planet
    {
        private string name;
        private List<Continent> continents;
        private List<Ocean> oceans;
        private List<Island> islands;

        public Planet(string planetName, string[] continentNames, string[] oceanNames, string[] islandNames)
        {
            name = planetName;
            continents = new List<Continent>();
            oceans = new List<Ocean>();
            islands = new List<Island>();
            foreach (string name in continentNames)
            {
                AddContinent(name);
            }

            foreach (string name in oceanNames)
            {
                AddOcean(name);
            }

            foreach (string name in islandNames)
            {
                AddIsland(name);
            }

        }
        
        public string GetPlanetName()
        {
            return name;
        }

        public void AddContinent(string name)
        {
            continents.Add(new Continent(name));
        } 
        public void AddOcean(string name)
        {
            oceans.Add(new Ocean(name));
        } 
        public void AddIsland(string name)
        {
            islands.Add(new Island(name));
        }

        public List<string> GetContinents()
        {
            List<string> continentList = new List<string>();
            foreach(Continent continent in continents)
            {
                continentList.Add(continent.GetContinentName());
            }

            return continentList;
        }

        public List<string> GetOcean()
        {
            List<string> oceanList = new List<string>();
            foreach (Ocean ocean in oceans)
            {
                oceanList.Add(ocean.GetOceanName());
            }

            return oceanList;
        }

        public List<string> GetIsland()
        {
            List<string> islandList = new List<string>();
            foreach (Island island in islands)
            {
                islandList.Add(island.GetIslandName());
            }

            return islandList;
        }

        public int GetContinentCount()
        {
            return continents.Count;
        }

        public int GetOceanCount()
        {
            return oceans.Count;
        }

        public int GetIslandCount()
        {
            return islands.Count;
        }

    }
}
