using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiTBackend.Objects
{
    class City
    {
        public String Name { get; private set; }
        public List<Route> NeighbouringCitiesRoutes { get; private set; }

        internal Route Route
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public City(String name)
        {
            this.Name = name;
            this.NeighbouringCitiesRoutes = new List<Route>();
        }

        public City(String name, List<Route> routes)
        {
            this.Name = name;
            this.NeighbouringCitiesRoutes = routes;
        }

        public void SetNeighbouringCitiesRoutes(List<Route> routes)
        {
            if (routes != null)
                NeighbouringCitiesRoutes = routes;
        }
    }
}
