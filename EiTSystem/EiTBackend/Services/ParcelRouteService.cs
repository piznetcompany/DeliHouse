using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Interfaces;
using EiTBackend.Objects;

namespace EiTBackend.Services
{
    class ParcelRouteService : IParcel
    {
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

        public List<Route> GetRoutes(IRouteRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
