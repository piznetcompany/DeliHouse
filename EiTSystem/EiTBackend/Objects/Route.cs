using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EiTBackend.Objects
{
    class Route
    {
        public City Origin { get; private set; }
        public City Destination { get; private set; }
        public int TransportDuration { get; private set; }
        public int TransportSegments { get; private set; }

        internal RouteRequest RouteRequest
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal City City
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Route(City origin, City destination, int duration, int segments)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.TransportDuration = duration;
            this.TransportSegments = segments;
        }

        private void SetOrigin(City origin)
        {
            this.Origin = origin;
        }

        private void SetDestination(City destination)
        {
            this.Destination = destination;
        }

        private void SetTransportDuration(int duration)
        {
            this.TransportDuration = duration;
        }

        private void SetTransportSegments(int segments)
        {
            this.TransportSegments = segments;
        }
    }
}
