using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKS.BLL.Object;
using Hopthoai;
using QUANLYCHAMCONG.PL.CMS;
using QLKS.BLL.BL;
using DgvFilterPopup;

namespace QLKS.PL.CMS.Danhmuc
{
    public partial class ThanhPho : UserControl
    {
        public delegate void _Close();
        public event _Close Close;
        LT_THANHPHO tp;
        int flag = 0;
        frmHoidap f;
        public ThanhPho()
        {
            InitializeComponent();
        }
        private void SetLink()
        {
            this.ucLink1.SetValues("Địa chỉ", "Thành phố");
        }
        private void Event()
        {

            txttentp.Focus();
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
            this.dgvtp.ReadOnly = true;
            this.dgvtp.AllowUserToAddRows = true;
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
            foreach (DataGridViewColumn dr in this.dgvtp.Columns)
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
                this.dgvtp.Columns.RemoveAt(0);
                this.dgvtp.Controls.RemoveByKey(((CheckBox)this.dgvtp.Controls.Find("checkboxHeader", true)[0]).Name);
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
                this.dgvtp.Columns.Insert(0, cb);
                Rectangle rect = this.dgvtp.GetCellDisplayRectangle(0, -1, true);
                rect.X = rect.Location.X + cb.Width / 33;
                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeader";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
                this.dgvtp.Controls.Add(checkboxHeader);
                this.dgvtp.Columns[0].Width = 50;
                this.dgvtp.DataSource = dt;
            }
        }

        void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)this.dgvtp.Controls.Find("checkboxHeader", true)[0]).Checked == true)
            {
                for (int i = 0; i < this.dgvtp.RowCount; i++)
                {
                    this.dgvtp[0, i].Value = ((CheckBox)this.dgvtp.Controls.Find("checkboxHeader", true)[0]).Checked;
                }
            }
            else
            {
                for (int i = 0; i < this.dgvtp.RowCount; i++)
                {
                    this.dgvtp[0, i].Value = false;
                }
            }
        }
        void toolbar1_Delete()
        {
            flag = 3;
            this.dgvtp.ReadOnly = false;
            this.dgvtp.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
            AddCheckbox(LT_THANHPHOBUS.SelectAll());


        }

        void toolbar1_Edit()
        {
            flag = 2;
            Clear();
            this.dgvtp.Focus();
            this.dgvtp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvtp.Rows[0].Selected = true;
            this.dgvtp.ReadOnly = false;
            this.dgvtp.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
        }

        void toolbar1_Add()
        {
            flag = 1;
            Clear();
            CreateID();
            this.toolbar1.SetAdd_Edit_Delete();
            txttentp.Focus();

        }
        LT_THANHPHO AddDuLieu(LT_THANHPHO tps)
        {
            try
            {
                tps.MATP = txtmatp.Text;
                tps.TENTP = txttentp.Text;
                tps.MAQG = cmbquocgia.SelectedValue.ToString();
            }
            catch { }
            return tps;
        }
        void Save()
        {
            //khoi tao
            tp = new LT_THANHPHO();
            if (flag == 1)
            {
                if (LT_THANHPHOBUS.Insert(AddDuLieu(tp)) == true)
                {
                    f = new frmHoidap("Thêm thành phố thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    LoadData();
                    this.toolbar1.SetSave();
                    Clear();
                }
                else
                {
                    f = new frmHoidap("Thêm thành phố  có lỗi xảy ra!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
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
                    f = new frmHoidap("Bạn có muốn sửa thành phố  ?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        if (LT_THANHPHOBUS.Update(AddDuLieu(tp)) == true)
                        {
                            f = new frmHoidap("Sửa thành phố  thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                            LoadData();
                            this.dgvtp.ReadOnly = true;
                            this.toolbar1.SetSave();
                            Clear();
                        }
                        else
                        {
                            f = new frmHoidap("Có lỗi khi Sửa thành phố  !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
                            f.ShowDialog();
                            this.toolbar1.SetSave();
                            this.dgvtp.ReadOnly = true;
                            Clear();
                        }
                    }
                    else
                    {
                        this.dgvtp.ReadOnly = true;
                        this.toolbar1.SetSave();
                        Clear();
                    }
                }
                catch { return; }
            }
            if (flag == 3)
            {
                f = new frmHoidap("Bạn có chắc chắn muốn xóa dữ liệu thành phố  vừa chọn?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.dauhoi);
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in this.dgvtp.Rows)
                    {
                        try
                        {
                            if (dr.Cells[0].Value != null)
                            {
                                tp = new LT_THANHPHO();
                                tp.MATP = dr.Cells["MATP"].Value.ToString();
                                LT_THANHPHOBUS.Delete(tp);
                            }
                        }
                        catch
                        {
                            f = new frmHoidap("Bạn chưa chọn phần thành phố nào vui lòng chọn lại!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                        }
                    }
                    f = new frmHoidap("Xóa thành công thành phố !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    RemoveCheckbox();
                    this.toolbar1.SetSave();
                    this.dgvtp.ReadOnly = true;
                    this.dgvtp.AllowUserToAddRows = true;
                }

            }

        }
        void CreateID()
        {
            tp = new LT_THANHPHO();
            this.txtmatp.Text = LT_THANHPHOBUS.GetID();
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
            Common.HightLightDataGridViewRow(ref this.dgvtp, LT_THANHPHOBUS.SelectAll());
            this.dgvtp.Columns["MATP"].Width = 100;
            LoadCombobox();
        }
        void LoadCombobox()
        {
            this.cmbquocgia.DataSource = LT_QUOCGIABUS.SelectAll();
            this.cmbquocgia.DisplayMember = "TENQG";
            this.cmbquocgia.ValueMember = "MAQG";
        }
        private void InitGrid()
        {
            DgvFilterManager f = new DgvFilterManager();
            f.DataGridView = (DataGridView)this.dgvtp;
        }
        void ChooseData(object sender, int e)
        {
            if (flag == 2)
            {
                try
                {
                    this.dgvtp.EndEdit();
                    DataGridViewRow dr = this.dgvtp.Rows[e];
                    txttentp.Text = dr.Cells["MATP"].Value.ToString();
                    txttentp.Text = dr.Cells["TENTP"].Value.ToString();
                    cmbquocgia.SelectedIndex = this.cmbquocgia.FindString(dr.Cells["TENQG"].Value.ToString());
                }
                catch { return; };
            }
        }

        private void dgvtp_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void dgvtp_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ChooseData(sender, 0);
        }

        private void dgvtp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void ThanhPho_Load(object sender, EventArgs e)
        {
            Event();
            SetLink();
        }
    }
}
