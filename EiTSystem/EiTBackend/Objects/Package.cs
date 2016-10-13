using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Enums;

namespace EiTBackend.Objects
{
    class Package
    {
        private City _cityFrom;
        private City _cityTo;
        private PackageDimensions _dimensions;
        private PackageTypes _packageType;
        private RouteTypes _routeType;
        private DateTime _shipmentDate;
        private int _weight;
    }
}
