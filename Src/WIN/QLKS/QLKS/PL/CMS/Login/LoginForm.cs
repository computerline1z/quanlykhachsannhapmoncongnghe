using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS.PL.CMS.Login
{
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (this.txtuser.Focused)
                return;
            else
                txtuser.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            f.Show();
        }
    }
}
