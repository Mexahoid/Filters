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
    public partial class FormMain : Form
    {
        private MainFiltersLogics mfl;
        private double current;

        public FormMain()
        {
            InitializeComponent();
            mfl = new MainFiltersLogics();
        }

        private void MormMain_Load(object sender, EventArgs e)
        {
        }

        public void GetListener(Action<Image> del, bool flag)
        {
            mfl.SetDrawer(del, flag);
        }

        private void CtrlBtnLoad_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                FormOriginal ft = new FormOriginal(this);
                ft.Show();
                FormEdited fe = new FormEdited(this);
                fe.Show();
                string path = ofd.FileName;
                mfl.LoadImage(path);
            }
        }

        private void CtrlBtnSave_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTrB_Scroll(object sender, EventArgs e)
        {
            if (CtrlTrBM.Value % 2 != 0)
                mfl.ShowImage(current, CtrlTrBM.Value, CtrlTrBM.Value, (double)CtrlNUDCounterHarmonic.Value);
        }

        private void CtrlRB_Checked(object sender, EventArgs e)
        {
            if (!((RadioButton) sender).Checked)
                return;
            current = Convert.ToDouble(((Control) sender)?.Tag);
            if (CtrlTrBM.Value % 2 != 0)
                mfl.ShowImage(current, CtrlTrBM.Value, CtrlTrBM.Value, (double)CtrlNUDCounterHarmonic.Value);
        }
    }
}
