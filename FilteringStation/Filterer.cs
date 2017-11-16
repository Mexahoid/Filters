using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringStation
{
    public class Filterer
    {
        private Image _image;
        private Filters _current;
        private LinearFilters linears;
        private NonLinearFilters nonLinears;

        public Filterer(Image img)
        {
            _image = img;
            _current = Filters.Null;
        }

        public void SetFilter(params double[] args)
        {
            _current = (Filters)args[0];
            linears = new LinearFilters(args.Skip(1).ToArray());
            nonLinears = new NonLinearFilters(args.Skip(1).ToArray());
        }

        public Image Process()
        {
            if (_current != Filters.Null)
            {
                return linears.ProcessImage(_current, _image);
            }
            return null;
        }

    }
}
