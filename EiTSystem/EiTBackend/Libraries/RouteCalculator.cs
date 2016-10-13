using System.Collections.Generic;
using EiTBackend.Objects;

namespace EiTBackend.Libraries
{
    class RouteCalculator
    {
        readonly List<City> _citiesList = new List<City>();

        public City City
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal Package Package
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void AddCity(City city)
        {
            _citiesList.Add(city);
        }

        public List<City> CalculateCheapestPath(City origin, City destination)
        {
            return null;
        }

        public List<City> CalculateShortestPath(City origin, City destination)
        {
            var previous = new Dictionary<City, City>();
            var distances = new Dictionary<City, int>();
            var nodes = new List<City>();

            List<City> path = null;

            foreach (var vertex in _citiesList)
            {
                distances[vertex] = (vertex.Equals(origin)) ? 0 : int.MaxValue;
                nodes.Add(vertex);
            }
            nodes.Sort((x, y) => distances[x] - distances[y]);
            while (nodes.Count != 0)
            {
                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest.Equals(destination))
                {
                    path = new List<City>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }
                    path.Add(origin);
                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in smallest.NeighbouringCitiesRoutes)
                {
                    var alt = distances[smallest] + neighbor.TransportDuration;
                    if (alt < distances[neighbor.Destination])
                    {
                        distances[neighbor.Destination] = alt;
                        previous[neighbor.Destination] = smallest;
                    }
                }
            }
            return path;
        }

        public double CalculateShipmentPrice(List<Route> route)
        {
            return 0.0;
        }

        public int CalculateShipmentDuration(List<Route> route)
        {
            return 0;
        }
    }
}
