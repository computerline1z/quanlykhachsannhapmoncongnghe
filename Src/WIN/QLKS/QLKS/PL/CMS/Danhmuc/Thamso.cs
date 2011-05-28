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
    public partial class Thamso : UserControl
    {
        public delegate void _Close();
        public event _Close Close;
        LT_THAMSO ts;
        int flag = 0;
        frmHoidap f;
        public Thamso()
        {
            InitializeComponent();
        }
        private void SetLink()
        {
            this.ucLink1.SetValues("Danh mục", "Tham số");
        }
        private void Event()
        {

            txttents.Focus();
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
            this.dgvgd.ReadOnly = true;
            this.dgvgd.AllowUserToAddRows = true;
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
            foreach (DataGridViewColumn dr in this.dgvgd.Columns)
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
                this.dgvgd.Columns.RemoveAt(0);
                this.dgvgd.Controls.RemoveByKey(((CheckBox)this.dgvgd.Controls.Find("checkboxHeader", true)[0]).Name);
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
                this.dgvgd.Columns.Insert(0, cb);
                Rectangle rect = this.dgvgd.GetCellDisplayRectangle(0, -1, true);
                rect.X = rect.Location.X + cb.Width / 33;
                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeader";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
                this.dgvgd.Controls.Add(checkboxHeader);
                this.dgvgd.Columns[0].Width = 50;
                this.dgvgd.DataSource = dt;
            }
        }

        void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)this.dgvgd.Controls.Find("checkboxHeader", true)[0]).Checked == true)
            {
                for (int i = 0; i < this.dgvgd.RowCount; i++)
                {
                    this.dgvgd[0, i].Value = ((CheckBox)this.dgvgd.Controls.Find("checkboxHeader", true)[0]).Checked;
                }
            }
            else
            {
                for (int i = 0; i < this.dgvgd.RowCount; i++)
                {
                    this.dgvgd[0, i].Value = false;
                }
            }
        }
        void toolbar1_Delete()
        {
            flag = 3;
            this.dgvgd.ReadOnly = false;
            this.dgvgd.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
            AddCheckbox(LT_THAMSOBUS.SelectAll());


        }

        void toolbar1_Edit()
        {
            flag = 2;
            Clear();
            this.dgvgd.Focus();
            this.dgvgd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvgd.Rows[0].Selected = true;
            this.dgvgd.ReadOnly = false;
            this.dgvgd.AllowUserToAddRows = false;
            this.toolbar1.SetAdd_Edit_Delete();
        }

        void toolbar1_Add()
        {
            flag = 1;
            Clear();
            CreateID();
            this.toolbar1.SetAdd_Edit_Delete();
            txttents.Focus();

        }
        LT_THAMSO AddDuLieu(LT_THAMSO tss)
        {
            try
            {
                tss.MATS = txtmats.Text;
                tss.TENTS = txttents.Text;
                tss.HESO = float.Parse(txtheso.Text.ToString());
                if (cbapdung.Checked == true)
                    tss.TINHTRANG = true;
                else
                    tss.TINHTRANG = false;
            }
            catch { }
            return tss;
        }
        void Save()
        {
            //khoi tao
            ts = new LT_THAMSO();
            if (flag == 1)
            {
                if (LT_THAMSOBUS.Insert(AddDuLieu(ts)) == true)
                {
                    f = new frmHoidap("Thêm Tham số thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    LoadData();
                    this.toolbar1.SetSave();
                    Clear();
                }
                else
                {
                    f = new frmHoidap("Thêm Tham số  có lỗi xảy ra!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
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
                    f = new frmHoidap("Bạn có muốn sửa Tham số  ?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        if (LT_THAMSOBUS.Update(AddDuLieu(ts)) == true)
                        {
                            f = new frmHoidap("Sửa Tham số  thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                            LoadData();
                            this.dgvgd.ReadOnly = true;
                            this.toolbar1.SetSave();
                            Clear();
                        }
                        else
                        {
                            f = new frmHoidap("Có lỗi khi Sửa Tham số  !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
                            f.ShowDialog();
                            this.toolbar1.SetSave();
                            this.dgvgd.ReadOnly = true;
                            Clear();
                        }
                    }
                    else
                    {
                        this.dgvgd.ReadOnly = true;
                        this.toolbar1.SetSave();
                        Clear();
                    }
                }
                catch { return; }
            }
            if (flag == 3)
            {
                f = new frmHoidap("Bạn có chắc chắn muốn xóa dữ liệu Tham số  vừa chọn?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.dauhoi);
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in this.dgvgd.Rows)
                    {
                        try
                        {
                            if (dr.Cells[0].Value != null)
                            {
                                ts = new LT_THAMSO();
                                ts.MATS = dr.Cells["MATS"].Value.ToString();
                                LT_THAMSOBUS.Delete(ts);
                            }
                        }
                        catch
                        {
                            f = new frmHoidap("Bạn chưa chọn phần Tham số nào vui lòng chọn lại!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                        }
                    }
                    f = new frmHoidap("Xóa thành công Tham số !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    RemoveCheckbox();
                    this.toolbar1.SetSave();
                    this.dgvgd.ReadOnly = true;
                    this.dgvgd.AllowUserToAddRows = true;
                }

            }

        }
        void CreateID()
        {
            ts = new LT_THAMSO();
            this.txtmats.Text = LT_THAMSOBUS.GetID();
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
            Common.HightLightDataGridViewRow(ref this.dgvgd, LT_THAMSOBUS.SelectAll());
            this.dgvgd.Columns["MATS"].Width = 100;
        }
        private void InitGrid()
        {
            DgvFilterManager f = new DgvFilterManager();
            f.DataGridView = (DataGridView)this.dgvgd;
        }
        void ChooseData(object sender, int e)
        {
            if (flag == 2)
            {
                try
                {
                    this.dgvgd.EndEdit();
                    DataGridViewRow dr = this.dgvgd.Rows[e];
                    txtmats.Text = dr.Cells["MATS"].Value.ToString();
                    txttents.Text = dr.Cells["TENTS"].Value.ToString();
                    txtheso.Text = dr.Cells["HESO"].Value.ToString();
                    if (dr.Cells["GHICHU"].Value.ToString() == "USE")
                        cbapdung.Checked = true;
                    else
                        cbapdung.Checked = false;
                }
                catch { return; };
            }
        }

        private void dgvgd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void dgvgd_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ChooseData(sender, 0);
        }

        private void dgvgd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void Thamso_Load(object sender, EventArgs e)
        {
            Event();
            SetLink();
        }
    }
}
