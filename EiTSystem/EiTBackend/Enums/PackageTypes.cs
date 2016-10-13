using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Attributes;

namespace EiTBackend.Enums
{
    enum PackageTypes
    {
        [StringValue("Direct")]
        DIRECT,
        [StringValue("Cheapest")]
        CHEAPEST,
        [StringValue("Fastest")]
        FASTEST
    }
}
