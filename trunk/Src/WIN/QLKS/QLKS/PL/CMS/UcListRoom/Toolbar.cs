using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace QUANLYCHAMCONG.PL.CMS
{
    public partial class Toolbar : UserControl
    {
        #region "Field"
        KeyboardHook k;
        #endregion
        #region "Delegale"
        public delegate void _Add();
        public delegate void _Delete();
        public delegate void _Edit();
        public delegate void _Print();
        public delegate void _Refesh();
        public delegate void _Save();
        public delegate void _Excel();
        public delegate void _Close();
        public delegate void _SelectFillter();
        #endregion
        #region "Event"
        public event _Add Add;
        public event _Delete Delete;
        public event _Excel Excel;
        public event _Print Print;
        public event _Refesh Refresh;
        public event _Edit Edit;
        public event _Save Save;
        public event _Close Close;
        public event _SelectFillter SelectFillTer;
        #endregion
        #region "Property"
        private DataTable _DataForCombobox;
        public DataTable DataForCombobox
        {
            get { return _DataForCombobox; }
            set { _DataForCombobox = value; }
        }
        private string _Values;

        public string Values
        {
            get { return _Values; }
            set { _Values = value; }
        }
        private string _DisplayMember;

        public string DisplayMember
        {
            get { return _DisplayMember; }
            set { _DisplayMember = value; }
        }
        private string _ValuesMember;

        public string ValuesMember
        {
            get { return _ValuesMember; }
            set { _ValuesMember = value; }
        }
        #endregion
        #region "Method"
        public void AddData()
        {
            this.cmbshoft.DisplayMember = DisplayMember;
            this.cmbshoft.ValueMember = ValuesMember;
            this.cmbshoft.DataSource = DataForCombobox;
            this.cmbshoft.SelectedIndex = 0;
        }
        #endregion
        public Toolbar()
        {
            InitializeComponent();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (this.Add != null)
                this.Add();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (this.Delete != null)
                this.Delete();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (this.Edit != null)
                this.Edit();
        }
        private void btnin_Click(object sender, EventArgs e)
        {
            if (this.Print != null)
                this.Print();
        }
        private void btnrefesh_Click(object sender, EventArgs e)
        {
            if (this.Refresh != null)
                this.Refresh();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (this.Save != null)
                this.Save();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (this.Excel != null)
                this.Excel();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (this.Close != null)
                this.Close();
        }
        private void cmbshoft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectFillTer != null)
            {
                if (this.cmbshoft.SelectedIndex != -1)
                {
                    this.Values = cmbshoft.SelectedValue.ToString();
                    this.SelectFillTer();
                }
            }
        }
        public void SetVisibleFillter(bool Visible)
        {
            if (Visible)
                this.cmbshoft.Visible = true;
            else
                this.cmbshoft.Visible = false;
        }
        public void SetToolBar(bool IsAdd,bool IsEdit,bool IsDelete,bool IsSave,bool IsClose,bool IsPrint,bool IsRefesh,bool IsExcel)
        {
            if (IsAdd)
                this.btnthem.Enabled = true;
            else
                this.btnthem.Enabled = false;
            if (IsEdit)
                this.btnsua.Enabled = true;
            else
                this.btnsua.Enabled = false;
            if (IsDelete)
                this.btnxoa.Enabled = true;
            else
                this.btnxoa.Enabled = false;
            if (IsSave)
                this.btnluu.Enabled = true;
            else
                this.btnluu.Enabled = false;
            if (IsClose)
                this.btnthoat.Enabled = true;
            else
                this.btnthoat.Enabled = false;
            if (IsPrint)
                this.btnin.Enabled = true;
            else
                this.btnin.Enabled = false;
            if (IsRefesh)
                this.btnrefesh.Enabled = true;
            else
                this.btnrefesh.Enabled = false;
            if (IsExcel)
                this.btntimkiem.Enabled = true;
            else
                this.btntimkiem.Enabled = false;

        }
        public void SetAdd_Edit_Delete()
        {
            SetToolBar(false, false, false, true,true,false, true, false);
        }
        public void SetSave()
        {
            SetToolBar(true, true, true, false, true, false, false, false);
        }
        public void EditName(string Add,string Edit,string Delete,string Save,String Dong,string inhinh,string lamtuoi,string excel)
        {
            if (!String.IsNullOrEmpty(Add))
                btnthem.Text = Add;
            if (!String.IsNullOrEmpty(Edit))
                btnsua.Text = Edit;
            if (!String.IsNullOrEmpty(Delete))
                btnxoa.Text = Delete;
            if (!String.IsNullOrEmpty(Save))
                btnluu.Text = Save;
            if (!String.IsNullOrEmpty(Dong))
                btnthoat.Text = Dong;
            if (!String.IsNullOrEmpty(inhinh))
                btnin.Text = inhinh;
            if (!String.IsNullOrEmpty(lamtuoi))
                btnrefesh.Text = lamtuoi;
            if (!String.IsNullOrEmpty(excel))
                btntimkiem.Text = excel;
        }
        private void Toolbar_Load(object sender, EventArgs e)
        {
            Hookkey();
        }
        private void Hookkey()
        {
            k = new KeyboardHook();
            k.KeyDown += new KeyEventHandler(Hook);
            k.Start();
        }
        private void Hook(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N || (e.KeyCode == Keys.F2))//them
            {
                if (btnthem.Enabled == false)
                    e.Handled = true;
                else
                    btnthem_Click(sender, e);
            }
            if ((e.Control && e.KeyCode == Keys.E) || (e.KeyCode == Keys.F3))//sua
            {
                if (btnsua.Enabled == false)
                    e.Handled = true;
                else
                    btnsua_Click(sender, e);
            }
            if((e.Control&&e.KeyCode== Keys.D)||(e.KeyCode== Keys.Delete))//xoa
            {
                if(btnxoa.Enabled== false)
                    e.Handled=true;
                else
                    btnxoa_Click(sender,e);
            }
            if ((e.Control && e.KeyCode == Keys.P))//in 
            {
                if (btnin.Enabled == false)
                    e.Handled = true;
                else
                    btnin_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)//lam moi
            {
                if (btnrefesh.Enabled == false)
                    e.Handled = true;
                else
                    btnrefesh_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.S||e.KeyCode== Keys.F4)//save
            {
                if (btnluu.Enabled == false)
                    e.Handled = true;
                else
                    btnluu_Click(sender, e);
            }
            if (e.Control && e.Alt && e.KeyCode == Keys.E)//xuat ra excel
            {
                if (btntimkiem.Enabled == false)
                    e.Handled = true;
                else
                    btntimkiem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (btnthoat.Enabled == false)
                    e.Handled = true;
                else
                    btnthoat_Click(sender, e);
            }
        }



    }
}
