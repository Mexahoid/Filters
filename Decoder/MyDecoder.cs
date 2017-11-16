using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Codec
{
    public class MyDecoder
    {
        private string _path;
        public MyDecoder(string path)
        {
            _path = path;
        }

        public Image Decode()
        {
            return new Bitmap(_path, true);
        }
    }
}
