using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Objects;

namespace EiTBackend.Interfaces
{
    interface IParcel
    {
        List<Route> GetRoutes(IRouteRequest request);
    }
}
