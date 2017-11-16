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
    public partial class FormOriginal : Form
    {
        private readonly GraphicsController _controller;

        public FormOriginal(FormMain mainform)
        {
            InitializeComponent();
            _controller = new GraphicsController(Resizer, OnPaint);
            mainform.GetListener(Redraw, true);
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
