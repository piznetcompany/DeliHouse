using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;

namespace EiTBackend.Objects
{
    static class PriceModel
    {
        private static List<PriceModelDetails> _priceModel { get; set; }

        internal static PriceModelDetails PriceModelDetails
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public static double CalculatePrice(Package package)
        {
            return 0.0;
        }
    }
}
