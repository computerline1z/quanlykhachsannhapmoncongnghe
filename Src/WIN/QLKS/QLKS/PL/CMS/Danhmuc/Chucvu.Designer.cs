namespace QLKS.PL.CMS.Danhmuc
{
    partial class Chucvu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chucvu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.cmbquocgia = new MultiColumnCombobox.MultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtp = new Datagridview.CustomGrid();
            this.toolbar1 = new QUANLYCHAMCONG.PL.CMS.Toolbar();
            this.ucLink1 = new QLKS.PL.CMS.UcLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txttencv);
            this.panel1.Controls.Add(this.txtmacv);
            this.panel1.Controls.Add(this.cmbquocgia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 115);
            this.panel1.TabIndex = 10;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(151, 49);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(172, 20);
            this.txttencv.TabIndex = 5;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(151, 24);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.ReadOnly = true;
            this.txtmacv.Size = new System.Drawing.Size(121, 20);
            this.txtmacv.TabIndex = 4;
            // 
            // cmbquocgia
            // 
            this.cmbquocgia.AutoComplete = false;
            this.cmbquocgia.AutoDropdown = false;
            this.cmbquocgia.BackColorEven = System.Drawing.Color.White;
            this.cmbquocgia.BackColorOdd = System.Drawing.Color.White;
            this.cmbquocgia.ColumnNames = "";
            this.cmbquocgia.ColumnWidthDefault = 75;
            this.cmbquocgia.ColumnWidths = "";
            this.cmbquocgia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbquocgia.FormattingEnabled = true;
            this.cmbquocgia.LinkedColumnIndex = 0;
            this.cmbquocgia.LinkedTextBox = null;
            this.cmbquocgia.Location = new System.Drawing.Point(151, 74);
            this.cmbquocgia.Name = "cmbquocgia";
            this.cmbquocgia.Size = new System.Drawing.Size(0, 21);
            this.cmbquocgia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ :";
            // 
            // dgvtp
            // 
            this.dgvtp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtp.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvtp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvtp.Location = new System.Drawing.Point(0, 184);
            this.dgvtp.Name = "dgvtp";
            this.dgvtp.ReadOnly = true;
            this.dgvtp.RowHeadersWidth = 25;
            this.dgvtp.Size = new System.Drawing.Size(1010, 566);
            this.dgvtp.TabIndex = 11;
            this.dgvtp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtp_RowEnter);
            this.dgvtp.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvtp_CellStateChanged);
            this.dgvtp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtp_CellEndEdit);
            // 
            // toolbar1
            // 
            this.toolbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.toolbar1.DataForCombobox = null;
            this.toolbar1.DisplayMember = null;
            this.toolbar1.Location = new System.Drawing.Point(0, 26);
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.Size = new System.Drawing.Size(1010, 43);
            this.toolbar1.TabIndex = 9;
            this.toolbar1.Values = null;
            this.toolbar1.ValuesMember = null;
            // 
            // ucLink1
            // 
            this.ucLink1.BackColor = System.Drawing.Color.Transparent;
            this.ucLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucLink1.BackgroundImage")));
            this.ucLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucLink1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucLink1.Location = new System.Drawing.Point(0, 0);
            this.ucLink1.Name = "ucLink1";
            this.ucLink1.Size = new System.Drawing.Size(1010, 27);
            this.ucLink1.TabIndex = 8;
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.dgvtp);
            this.Controls.Add(this.ucLink1);
            this.Name = "Chucvu";
            this.Size = new System.Drawing.Size(1010, 750);
            this.Load += new System.EventHandler(this.Chucvu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.TextBox txtmacv;
        private MultiColumnCombobox.MultiColumnComboBox cmbquocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QUANLYCHAMCONG.PL.CMS.Toolbar toolbar1;
        private Datagridview.CustomGrid dgvtp;
        private UcLink ucLink1;
    }
}
