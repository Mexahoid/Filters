using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringStation
{
    internal class NonLinearFilters
    {
        private double[] _args;
        public NonLinearFilters(double[] args)
        {
            _args = args;
        }

        public Image ProcessImage(Filters type, Image input)
        {
            switch (type)
            {
                case Filters.NonLinearMedian:
                    break;
                case Filters.NonLinearStaticstical:
                    break;
                case Filters.NonLinearKurahawa:
                    break;
                case Filters.NonLinearAdaptiveBinary:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            return null;
        }
    }
}
