using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS.PL.CMS
{
    public partial class UcTopToolBar : UserControl
    {
        public UcTopToolBar()
        {
            InitializeComponent();
        }

        private void btncheckin_Click(object sender, EventArgs e)
        {
            frmDatPhong f = new frmDatPhong();
            f.Show();
        }

    }
}
