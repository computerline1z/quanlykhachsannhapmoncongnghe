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
    public partial class UcLeftToolBar : UserControl
    {
        public delegate void _AddQuan();
        public event _AddQuan Quan;
        public delegate void _AddThanhPho();
        public event _AddThanhPho ThanhPho;
        public delegate void _AddQuocGia();
        public event _AddQuocGia Quocgia;
        public delegate void _AddLoaiKH();
        public event _AddLoaiKH LoaiKH;
        public delegate void _AddLoaiPhong();
        public event _AddLoaiPhong LoaiPhong;
        public delegate void _AddPhong();
        public event _AddPhong Phong;
        public delegate void _AddChucVu();
        public event _AddChucVu Chucvu;
        public delegate void _AddThamSo();
        public event _AddThamSo ThamSo;


        public UcLeftToolBar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UcLeftToolBar_Load(object sender, EventArgs e)
        {

        }

        private void nbquan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.Quan != null)
                this.Quan();
        }

        private void nbthanhpho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.ThanhPho != null)
                this.ThanhPho();
        }

        private void nbquocgia_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if(this.Quocgia!=null)
                this.Quocgia();
        }

        private void nvlkh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.LoaiKH != null)
                this.LoaiKH();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.LoaiPhong != null)
                this.LoaiPhong();
        }

        private void nbphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.Phong != null)
                this.Phong();
        }

        private void nvcv_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.Chucvu != null)
                this.Chucvu();
        }

        private void nbthamso_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this.ThamSo != null)
                this.ThamSo();
        }
    }
}
