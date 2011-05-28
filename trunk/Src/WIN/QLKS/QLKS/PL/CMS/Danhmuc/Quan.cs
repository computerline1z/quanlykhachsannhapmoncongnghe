using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hopthoai;
using DgvFilterPopup;
using QLKS.BLL.Object;
using QUANLYCHAMCONG.PL.CMS;
using QLKS.BLL.BL;

namespace QLKS.PL.Images.Danhmuc
{
    public partial class Quan : UserControl
    {
        public delegate void _Close();
        public event _Close Close;
        LT_QUAN quan;
        int flag = 0;
        frmHoidap f;
        public Quan()
        {
            InitializeComponent();
        }
        private void SetLink()
        {
            this.ucLink1.SetValues("Địa chỉ", "Quận");
        }
        private void Event()
        {

            txtmaquan.Focus();
            this.toolbar1.Add += new Toolbar._Add(toolbar1_Add);
            this.toolbar1.Edit += new Toolbar._Edit(toolbar1_Edit);
            this.toolbar1.Save += new Toolbar._Save(Save);
            this.toolbar1.Delete += new Toolbar._Delete(toolbar1_Delete);
            this.toolbar1.Close += new Toolbar._Close(toolbar1_Close);
            this.toolbar1.Refresh += new Toolbar._Refesh(Refresh);
            InitGrid();
            LoadData();
        }

        void Refresh()
        {
            RemoveCheckbox();
            this.toolbar1.SetSave();
            this.flag = 0;
            this.dgvquan.ReadOnly = true;
            this.dgvquan.AllowUserToAddRows = true;
            LoadData();
            this.Clear();
        }
        void toolbar1_Close()
        {
            if (this.Close != null)
                this.Close();
        }
        private int FindAviable()
        {
            foreach (DataGridViewColumn dr in this.dgvquan.Columns)
            {
                if (dr is DataGridViewCheckBoxColumn)
                    return 1;
            }
            return 0;
        }
        private void RemoveCheckbox()
        {
            if (FindAviable() == 1)
            {
                this.dgvquan.Columns.RemoveAt(0);
                this.dgvquan.Controls.RemoveByKey(((CheckBox)this.dgvquan.Controls.Find("checkboxHeader", true)[0]).Name);
                LoadData();
            }
        }
        private void AddCheckbox(DataTable dt)
        {
            if (FindAviable() == 0)
            {
                DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
                cb.Width = 30;
                cb.FillWeight = 30;
                cb.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvquan.Columns.Insert(0, cb);
                Rectangle rect = this.dgvquan.GetCellDisplayRectangle(0, -1, true);
                rect.X = rect.Location.X + cb.Width / 33;
                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeader";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
                this.dgvquan.Controls.Add(checkboxHeader);
                this.dgvquan.Columns[0].Width = 50;
                this.dgvquan.DataSource = dt;
            }
        }

        void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)this.dgvquan.Controls.Find("checkboxHeader", true)[0]).Checked == true)
            {
                for (int i = 0; i < this.dgvquan.RowCount; i++)
                {
                    this.dgvquan[0, i].Value = ((CheckBox)this.dgvquan.Controls.Find("checkboxHeader", true)[0]).Checked;
                }
            }
            else
            {
                for (int i = 0; i < this.dgvquan.RowCount; i++)
                {
                    this.dgvquan[0, i].Value = false;
                }
            }
        }
        void toolbar1_Delete()
        {
            flag = 3;
            this.dgvquan.ReadOnly = false;
            this.dgvquan.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
            AddCheckbox(LT_QUANBUS.SelectAll());


        }

        void toolbar1_Edit()
        {
            flag = 2;
            Clear();
            this.dgvquan.Focus();
            this.dgvquan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvquan.Rows[0].Selected = true;
            this.dgvquan.ReadOnly = false;
            this.dgvquan.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
        }

        void toolbar1_Add()
        {
            flag = 1;
            Clear();
            CreateID();
            this.toolbar1.SetAdd_Edit_Delete();
            txttenquan.Focus();

        }
        LT_QUAN AddDuLieu(LT_QUAN quans)
        {
            try
            {
                quans.MAQUAN = txtmaquan.Text;
                quans.TENQUAN = txttenquan.Text;
                quans.MATP = cmbthanhpho.SelectedValue.ToString();
            }
            catch {}
            return quans;
        }
        void Save()
        {
            //khoi tao
            quan = new LT_QUAN();
            if (flag == 1)
            {
                if (LT_QUANBUS.Insert(AddDuLieu(quan)) == true)
                {
                    f = new frmHoidap("Thêm quận thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    LoadData();
                    this.toolbar1.SetSave();
                    Clear();
                }
                else
                {
                    f = new frmHoidap("Thêm quận  có lỗi xảy ra!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
                    f.ShowDialog();
                    LoadData();
                    this.toolbar1.SetSave();
                    Clear();
                }
            }
            if (flag == 2)
            {
                try
                {
                    f = new frmHoidap("Bạn có muốn sửa quận  ?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        if (LT_QUANBUS.Update(AddDuLieu(quan)) == true)
                        {
                            f = new frmHoidap("Sửa quận  thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                            LoadData();
                            this.dgvquan.ReadOnly = true;
                            this.toolbar1.SetSave();
                            Clear();
                        }
                        else
                        {
                            f = new frmHoidap("Có lỗi khi Sửa quận  !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
                            f.ShowDialog();
                            this.toolbar1.SetSave();
                            this.dgvquan.ReadOnly = true;
                            Clear();
                        }
                    }
                    else
                    {
                        this.dgvquan.ReadOnly = true;
                        this.toolbar1.SetSave();
                        Clear();
                    }
                }
                catch { return; }
            }
            if (flag == 3)
            {
                f = new frmHoidap("Bạn có chắc chắn muốn xóa dữ liệu quận  vừa chọn?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.dauhoi);
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in this.dgvquan.Rows)
                    {
                        try
                        {
                            if (dr.Cells[0].Value != null)
                            {
                                quan = new LT_QUAN();
                                quan.MAQUAN = dr.Cells["MAQUAN"].Value.ToString();
                                LT_QUANBUS.Delete(quan);
                            }
                        }
                        catch
                        {
                            f = new frmHoidap("Bạn chưa chọn phần quận nào vui lòng chọn lại!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                        }
                    }
                    f = new frmHoidap("Xóa thành công quận !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    RemoveCheckbox();
                    this.toolbar1.SetSave();
                    this.dgvquan.ReadOnly = true;
                    this.dgvquan.AllowUserToAddRows = true;
                }

            }

        }
        void CreateID()
        {
            quan = new LT_QUAN();
            this.txtmaquan.Text = LT_QUANBUS.GetID();
        }
        private void Clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                    foreach (Control d in c.Controls)
                        if (d is TextBox)
                            d.Text = "";
            }
        }
        void LoadData()
        {
            Common.HightLightDataGridViewRow(ref this.dgvquan, LT_QUANBUS.SelectAll());
            this.dgvquan.Columns["MAQUAN"].Width = 100;
            LoadCombobox();
        }
        void LoadCombobox()
        {
            this.cmbthanhpho.DataSource = LT_THANHPHOBUS.SelectAll();
            this.cmbthanhpho.DisplayMember = "TENTP";
            this.cmbthanhpho.ValueMember = "MATP";
        }
        private void InitGrid()
        {
            DgvFilterManager f = new DgvFilterManager();
            f.DataGridView = (DataGridView)this.dgvquan;
        }
        void ChooseData(object sender, int e)
        {
            if (flag == 2)
            {
                try
                {
                    this.dgvquan.EndEdit();
                    DataGridViewRow dr = this.dgvquan.Rows[e];
                    txtmaquan.Text = dr.Cells["MAQUAN"].Value.ToString();
                    txttenquan.Text = dr.Cells["TENQUAN"].Value.ToString();
                    cmbthanhpho.SelectedIndex = this.cmbthanhpho.FindString(dr.Cells["TENTP"].Value.ToString());
                }
                catch { return; };
            }
        }

        private void Quan_Load(object sender, EventArgs e)
        {
            Event();
            SetLink();
        }

        private void dgvquan_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void dgvquan_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ChooseData(sender, 0);
        }

        private void dgvquan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }
    }
}
