using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace QLKS
{
    public partial class frmWaiting : Form
    {
        public frmWaiting()
        {
            InitializeComponent();
        }
        [DllImport("User32", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);
        [DllImport("User32", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd,
        int Index, int Value);
        [DllImport("User32", CharSet = CharSet.Auto)]
        private static extern int SetLayeredWindowAttributes(IntPtr hWnd,
        int clrKey, Byte bAlpha, int dwFlags);

        private const int LWA_COLORKEY = 1;
        private const int LWA_ALPHA = 2;
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        public static void SetTransparentForm(IntPtr hwnd)
        {
            int rtn = GetWindowLong((IntPtr)hwnd, GWL_EXSTYLE);
            rtn = rtn | WS_EX_LAYERED;
            SetWindowLong((IntPtr)hwnd, GWL_EXSTYLE, rtn);
            SetLayeredWindowAttributes((IntPtr)hwnd, 5, 150, LWA_ALPHA);
        }
        private void frmWaiting_Load(object sender, EventArgs e)
        {
            SetTransparentForm(this.Handle);
            this.BackColor = Color.White;
            this.TransparencyKey = this.BackColor;
        }
    }
}
