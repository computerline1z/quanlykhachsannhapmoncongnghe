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
    public partial class Content : UserControl
    {
        public Content()
        {
            InitializeComponent();
        }

        private void Content_Load(object sender, EventArgs e)
        {
            try
            {
                flashaction.Movie=@"E:\Project\Src\WIN\QLKS\QLKS\PL\Images\Login Page\bannerLogin.swf";
                flashaction.WMode = "Transparent"; 
                
            }
            catch (Exception ex)
            {

                throw new InvalidProgramException("can't display flast!"+ex.Message.ToString()) ;
            }
        }
    }
}
