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
    public partial class Chucvu : UserControl
    {

        public delegate void _Close();
        public event _Close Close;
        NS_CHUCVU cv;
        int flag = 0;
        frmHoidap f;
        public Chucvu()
        {
            InitializeComponent();
        }
        private void SetLink()
        {
            this.ucLink1.SetValues("Nhân viên", "Chức vụ");
        }
        private void Event()
        {

            txttencv.Focus();
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
            AddCheckbox(NS_CHUCVUBUS.SelectAll());


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
            txttencv.Focus();

        }
        NS_CHUCVU AddDuLieu(NS_CHUCVU cvs)
        {
            try
            {
                cvs.MACV = txtmacv.Text;
                cvs.TENCV = txttencv.Text;
            }
            catch { }
            return cvs;
        }
        void Save()
        {
            //khoi tao
            cv = new NS_CHUCVU();
            if (flag == 1)
            {
                if (NS_CHUCVUBUS.Insert(AddDuLieu(cv)) == true)
                {
                    f = new frmHoidap("Thêm Chức vụ thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                    f.ShowDialog();
                    LoadData();
                    this.toolbar1.SetSave();
                    Clear();
                }
                else
                {
                    f = new frmHoidap("Thêm Chức vụ  có lỗi xảy ra!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
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
                    f = new frmHoidap("Bạn có muốn sửa Chức vụ  ?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.canhbao);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        if (NS_CHUCVUBUS.Update(AddDuLieu(cv)) == true)
                        {
                            f = new frmHoidap("Sửa Chức vụ  thành công!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                            LoadData();
                            this.dgvtp.ReadOnly = true;
                            this.toolbar1.SetSave();
                            Clear();
                        }
                        else
                        {
                            f = new frmHoidap("Có lỗi khi Sửa Chức vụ  !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.baoloi);
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
                f = new frmHoidap("Bạn có chắc chắn muốn xóa dữ liệu Chức vụ  vừa chọn?", frmHoidap.CO.hien, frmHoidap.KHONG.hien, frmHoidap.THOAT.an, frmHoidap.HINH.dauhoi);
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dr in this.dgvtp.Rows)
                    {
                        try
                        {
                            if (dr.Cells[0].Value != null)
                            {
                                cv = new NS_CHUCVU();
                                cv.MACV = dr.Cells["MACV"].Value.ToString();
                                NS_CHUCVUBUS.Delete(cv);
                            }
                        }
                        catch
                        {
                            f = new frmHoidap("Bạn chưa chọn phần Chức vụ nào vui lòng chọn lại!", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
                            f.ShowDialog();
                        }
                    }
                    f = new frmHoidap("Xóa thành công Chức vụ !", frmHoidap.CO.an, frmHoidap.KHONG.an, frmHoidap.THOAT.an, frmHoidap.HINH.thongtin);
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
            cv = new NS_CHUCVU();
            this.txtmacv.Text = NS_CHUCVUBUS.GetID();
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
            Common.HightLightDataGridViewRow(ref this.dgvtp, NS_CHUCVUBUS.SelectAll());
            this.dgvtp.Columns["MACV"].Width = 100;
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
                    txtmacv.Text = dr.Cells["MACV"].Value.ToString();
                    txttencv.Text = dr.Cells["TENCV"].Value.ToString();
                }
                catch { return; };
            }
        }

        private void dgvtp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void dgvtp_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            ChooseData(sender,0);
        }

        private void dgvtp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChooseData(sender, e.RowIndex);
        }

        private void Chucvu_Load(object sender, EventArgs e)
        {
            SetLink();
            Event();
        }
    }
}
