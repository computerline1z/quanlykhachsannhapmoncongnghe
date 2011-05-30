using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKS.BLL.Object;
using QLKS.BLL.BL;

namespace QLKS.PL.CMS.DatPhong
{
    public partial class UcDatPhong : UserControl
    {
        
        public UcDatPhong()
        {
            InitializeComponent();
        }
        LT_PHONG objPhong;
        object[] obj;
        public string[] main_DSPhong = new string[100];
        private void GrdPhong_Load()
        {
            //foreach (string MaPhong in main_DSPhong)
            //{
                Common.HightLightDataGridViewRow (ref this.grd_phong, LT_PHONGBUS.SelectAll());
            //}
        }
        #region "LOAD CAC COMBOBOX"
            private void cbxLoaiKhach_Load()
            {
                cbx_LoaiKH.DataSource = LT_LOAIKHBUS.SelectAll();
                cbx_LoaiKH.DisplayMember = "TENLKH";
                cbx_LoaiKH.ValueMember = "MALKH";
            }
            private void cbxQuan_Load()
            {
                LT_QUAN objQuan = new LT_QUAN();
                objQuan.MATP = cbx_quocgia.SelectedValue.ToString();
                cbx_thanhpho.DataSource = LT_QUANBUS.SelectByTP(objQuan);
                cbx_quan.DataSource = LT_QUANBUS.SelectAll();
                cbx_quan.DisplayMember = "TENQUAN";
                cbx_quan.ValueMember = "MAQUAN";
            }
            private void cbxQuocGia_Load()
            {
                cbx_quocgia.DataSource = LT_QUOCGIABUS.SelectAll();
                cbx_quocgia.DisplayMember = "TENQG";
                cbx_quocgia.ValueMember = "MAQG";
            }
            private void cbxThanhPho_Load()
            {
                LT_THANHPHO objThanhPho = new LT_THANHPHO();
                objThanhPho.MAQG = cbx_quocgia.SelectedValue.ToString();
                cbx_thanhpho.DataSource = LT_THANHPHOBUS.SelectByQG(objThanhPho);
                cbx_thanhpho.DisplayMember = "TENTP";
                cbx_thanhpho.ValueMember = "MATP";
            }
            private void cbx_load()
            {
                cbxLoaiKhach_Load();
                cbxQuocGia_Load();
                cbxThanhPho_Load();
                cbxQuan_Load();
            }
        #endregion
        #region  "EVENT CAC COMBOBOX"
            private void cbxQuocGia_SelectedValueChanged()
            {
                cbxThanhPho_Load();
            }
            private void cbxThanhPho_SelectedValueChanged()
            {
                cbxQuan_Load();
            }
        #endregion

            private void UcDatPhong_Load(object sender, EventArgs e)
        {
            main_DSPhong[0] = "PHG110529110";
            GrdPhong_Load();
            cbx_load();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ThemKHvaoList();
        }
        private void ThemKHvaoList()
        {
            LT_KHACHHANG kh = new LT_KHACHHANG();
            kh.CMND = txt_CMND.Text;
            kh.DIACHI = txt_diachi.Text;
            if (checkEdit1.Checked == true)
                kh.GIOITINH = true;
            else if (checkEdit2.Checked == true)
                kh.GIOITINH = false;
            kh.HOKH = txt_Ho.Text;
            kh.MALKH = cbx_LoaiKH.SelectedValue.ToString();
            kh.MAQG = cbx_quocgia.SelectedItem.ToString();
            kh.MAQUAN = cbx_quan.SelectedItem.ToString();
            kh.MATP = cbx_thanhpho.SelectedItem.ToString();
            kh.PASSPORT = txt_Passport.Text;
            kh.SODT = txt_Sdt.Text;
            kh.TENKH = txt_Ten.Text;
            obj[obj.Length] = kh;
        }

        private void cbx_quocgia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
