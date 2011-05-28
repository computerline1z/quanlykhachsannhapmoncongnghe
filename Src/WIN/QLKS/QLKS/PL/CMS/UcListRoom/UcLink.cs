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
    public partial class UcLink : UserControl
    {
        public UcLink()
        {
            InitializeComponent();
        }
        public void SetValues(string danhmuc, string Chucnang)
        {
            this.label1.Text = danhmuc;
            this.label2.Text = Chucnang;
        }
    }
}
