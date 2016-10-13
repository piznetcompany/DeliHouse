using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Enums;
using EiTBackend.Interfaces;

namespace EiTBackend.Objects
{
    class RouteRequest : IRouteRequest
    {
        private City _cityFrom;
        private City _cityTo;
        private PackageDimensions _dimensions;
        private PackageTypes _packageType;
        private RouteTypes _routeType;
        private DateTime _shipmentDate;
        private int _weight;

        public RouteRequest(City cityFrom, City cityTo, PackageDimensions dimensions, PackageTypes packageType, RouteTypes routeType, DateTime shipmentDate, int weight)
        {
            _cityFrom = cityFrom;
            _cityTo = cityTo;
            _dimensions = dimensions;
            _packageType = packageType;
            _routeType = routeType;
            _shipmentDate = shipmentDate;
            _weight = weight;
        }

        internal RouteTypes RouteTypes
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal PackageTypes PackageTypes
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal PackageDimensions PackageDimensions
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public String RequestToJson()
        {
            return null;
        }
    }
}
