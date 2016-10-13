using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EiTBackend.Attributes;

namespace EiTBackend.Enums
{
    enum RouteTypes
    {
        [StringValue("Weapon")]
        WEAPON,
        [StringValue("Standard")]
        STANDARD,
        [StringValue("Signature support")]
        SIGNATURESUPPORT,
        [StringValue("Priority mail")]
        PRIORITYMAIL,
        [StringValue("ive animals")]
        LIVEANIMALS,
        [StringValue("Fragile shipment")]
        FRAGILESHIPMENT,
        [StringValue("Cooled merchandise")]
        COOLEDMERCHANDISE
    }
}
