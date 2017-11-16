using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filters
{
    public partial class FormEdited : Form
    {
        private readonly GraphicsController _controller;

        public FormEdited(FormMain fm)
        {
            InitializeComponent();
            _controller = new GraphicsController(Resizer, OnPaint);
            fm.GetListener(Redraw, false);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true);
        }

        private void Redraw(Image img)
        {
            _controller.Img = img;
            _controller.SetGraphics(CtrlPnlMain);
            _controller.OnPainter(null);
        }

        private void Resizer(int width, int height)
        {
            CtrlPnlMain.Width = width;
            CtrlPnlMain.Height = height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _controller.Draw();
        }
    }
}
