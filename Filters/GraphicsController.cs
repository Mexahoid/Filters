using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filters
{
    internal class GraphicsController
    {
        private Graphics _graphics;
        private Bitmap _canvas;
        private Image _img;
        public event Action<int, int> Resize;
        private event Action<PaintEventArgs> Painter;
        public GraphicsController(Action<int, int> resizer, Action<PaintEventArgs> painterAction)
        {
            Resize += resizer;
            Painter += painterAction;
        }
        

        public Image Img
        {
            set
            {
                _img = value;
                _canvas = new Bitmap(_img.Width, _img.Height);
                Resize?.Invoke(_img.Width, _img.Height);
            }
        }

        public void SetGraphics(Control control)
        {
            _graphics = control.CreateGraphics();
        }

        public void Draw()
        {
            if(_canvas != null)
            using (Graphics g = Graphics.FromImage(_canvas))
            {
                g.Clear(Color.White);
                g.DrawImage(_img, 0, 0);
                _graphics.DrawImage(_canvas, 0, 0);
            }
        }

        public void OnPainter(PaintEventArgs obj)
        {
            Painter?.Invoke(obj);
        }
    }
}
