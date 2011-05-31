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
using DevExpress.XtraEditors;
using Hopthoai;

namespace QLKS.PL.CMS.DatPhong
{
    public partial class UcDatPhong : UserControl
    {
        
        public UcDatPhong()
        {
            InitializeComponent();
        }
        private void GrdPhong_Load()
        {
            //foreach (string MaPhong in main_DSPhong)
            //{
                //Common.HightLightDataGridViewRow (ref this.grd_phong, LT_PHONGBUS.SelectAll());
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
                objQuan.MATP = cbx_thanhpho.SelectedValue.ToString();
                cbx_quan.DataSource = LT_QUANBUS.SelectByTP(objQuan);
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
            private void cbx_quocgia_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbx_clear(false, false, true, true);
                cbxThanhPho_Load();
            }
            private void cbx_thanhpho_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbx_clear(false, false, false, true);
                cbxQuan_Load();
            }
            private void cbx_clear(bool loaiKH, bool quocgia, bool thanhpho, bool quan)
            {
                if (loaiKH == true)
                {
                    cbx_LoaiKH.Text = "";
                }
                if (quocgia == true)
                {
                    cbx_quocgia.Text = "";
                }
                if (thanhpho == true)
                {
                    cbx_thanhpho.Text = "";
                }
                if (quan == true)
                {
                    cbx_quan.Text = "";
                }
            }
        #endregion
            private void UcDatPhong_Load(object sender, EventArgs e)
        {
            GrdPhong_Load();
            cbx_load();
            checkEdit1.Checked = true;
            checkEdit2.Checked = false;
        }
        #region "THEM KHACH HANG"
            private void simpleButton2_Click(object sender, EventArgs e)
            {
                ThemKH();
            }
            private void ThemKH()
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
                themKH_DataGrid(kh);

            }
            private int themKH_DataGrid(LT_KHACHHANG kh)
            {
                try
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    if (grd_phong.SelectedRows.Count != 0)
                    {
                        grd_KH.Rows.Add(dr);
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["Phong"].Value = grd_phong.SelectedRows[0].Cells["TenPhong"].Value;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["MaPhong"].Value = grd_phong.SelectedRows[0].Cells["MaPHG"].Value;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["Ho"].Value = kh.HOKH;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["Ten"].Value = kh.TENKH;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["HovaTen"].Value = kh.HOKH + " " + kh.TENKH;
                        if (kh.GIOITINH == true)
                            grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["GioiTinh"].Value = "Nam";
                        else
                            grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["GioiTinh"].Value = "Nữ";
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["LoaiKH"].Value = kh.MALKH;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["CMND"].Value = kh.CMND;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["Passport"].Value = kh.PASSPORT;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["SDT"].Value = kh.SODT;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["DiaChi"].Value = kh.DIACHI;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["QuocGia"].Value = kh.MAQG;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["ThanhPho"].Value = kh.MATP;
                        grd_KH.Rows[grd_KH.Rows.Count - 1].Cells["Quan"].Value = kh.MAQUAN;
                        clear_textbox();
                        return 1;
                    }
                    else
                    {
                        frmHoidap f = new frmHoidap("Chưa chọn phòng cho khách kìa đại ca!!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                        f.ShowDialog();
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }

            }
            private void clear_textbox()
            {
                txt_CMND.Text = "";
                txt_diachi.Text = "";
                txt_Ho.Text = "";
                txt_Passport.Text = "";
                txt_Sdt.Text = "";
                txt_Ten.Text = "";

            }
        #endregion
        #region "THEM PHONG"
            private bool Phong_Add()
            {
                try
                {
                    if (ThemPhong.TabViewer.SelectedTabPageIndex == 0)
                    {
                        try
                        {
                            foreach (DataGridViewRow dgr in ThemPhong.grd_All.SelectedRows)
                            {
                                DataGridViewRow dr = new DataGridViewRow();
                                if (DaDcChon(dgr) == true)
                                {
                                    frmHoidap f = new frmHoidap("Đã có phòng này trong danh sách!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                                    f.ShowDialog();
                                    return false;
                                }
                                grd_phong.Rows.Add(dr);
                                for (int i = 0; i < dgr.Cells.Count; i++ )
                                    grd_phong.Rows[grd_phong.Rows.Count - 1].Cells[i].Value = dgr.Cells[i].Value;
                            }
                        }
                        catch
                        {

                        }
                    }
                    else if (ThemPhong.TabViewer.SelectedTabPageIndex == 1)
                    {
                        try
                        {
                            foreach (DataGridViewRow dgr in ThemPhong.grd_VIP.SelectedRows)
                            {
                                DataGridViewRow dr = new DataGridViewRow();
                                if (DaDcChon(dgr) == true)
                                {
                                    frmHoidap f = new frmHoidap("Đã có phòng này trong danh sách!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                                    f.ShowDialog();
                                    return false;
                                }
                                grd_phong.Rows.Add(dr);
                                for (int i = 0; i < dgr.Cells.Count; i++)
                                    grd_phong.Rows[grd_phong.Rows.Count - 1].Cells[i].Value = dgr.Cells[i].Value;
                            }

                        }
                        catch
                        {

                        }
                    }
                    else if (ThemPhong.TabViewer.SelectedTabPageIndex == 2)
                    {
                        try
                        {
                            foreach (DataGridViewRow dgr in ThemPhong.grd_Normal.SelectedRows)
                            {
                                DataGridViewRow dr = new DataGridViewRow();
                                if (DaDcChon(dgr) == true)
                                {
                                    frmHoidap f = new frmHoidap("Đã có phòng này trong danh sách!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                                    f.ShowDialog();
                                    return false;
                                }
                                grd_phong.Rows.Add(dr);
                                for (int i = 0; i < dgr.Cells.Count; i++)
                                    grd_phong.Rows[grd_phong.Rows.Count - 1].Cells[i].Value = dgr.Cells[i].Value;
                            }
                        }
                        catch
                        {

                        }
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            private bool Phong_Drop()
            {
                try
                {
                    foreach (DataGridViewRow dgr in grd_phong.SelectedRows)
                    {
                        grd_phong.Rows.RemoveAt(dgr.Index);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            private bool DaDcChon(DataGridViewRow dgr)
            {
                try
                {
                    foreach (DataGridViewRow dr in grd_phong.Rows)
                        if (dgr.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
                            return true;
                    return false;
                }
                catch 
                {
                    return false;
                }
            }
        #endregion
        #region "HOAN TAT"
            private void ThemPhieuThue()
            {
                LT_PHIEUTHUE objPhieuThue = new LT_PHIEUTHUE();
                objPhieuThue.MAPT = LT_PHIEUTHUEBUS.GetID();
                //objPhieuThue.NGAYBD = DateTime.Now.date();
                objPhieuThue.SOLUONG = 0;
                objPhieuThue.TINHTRANG = 0;
                if (LT_PHIEUTHUEBUS.Insert(objPhieuThue))
                {
                    frmHoidap f = new frmHoidap("Đã tạo xong phiếu thuê!!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                }
                else
                {
                    frmHoidap f = new frmHoidap("Đã tạo xong phiếu thuê!!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.hien, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                }
            }
        #endregion
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            this.Parent.Dispose();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            Phong_Add();
        }

        private void btn_BoPhong_Click(object sender, EventArgs e)
        {
            Phong_Drop();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
                checkEdit2.Checked = false;
            else
                checkEdit2.Checked = true;
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == true)
                checkEdit1.Checked = false;
            else
                checkEdit1.Checked = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ThemPhieuThue();
        }
        
    }
}
