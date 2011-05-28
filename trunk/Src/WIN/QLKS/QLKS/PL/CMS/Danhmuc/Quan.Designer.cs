namespace QLKS.PL.Images.Danhmuc
{
    partial class Quan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvquan = new Datagridview.CustomGrid();
            this.cmbthanhpho = new MultiColumnCombobox.MultiColumnComboBox();
            this.txtmaquan = new System.Windows.Forms.TextBox();
            this.txttenquan = new System.Windows.Forms.TextBox();
            this.toolbar1 = new QUANLYCHAMCONG.PL.CMS.Toolbar();
            this.ucLink1 = new QLKS.PL.CMS.UcLink();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txttenquan);
            this.panel1.Controls.Add(this.txtmaquan);
            this.panel1.Controls.Add(this.cmbthanhpho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 115);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quận :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Quận :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thuộc thành phố :";
            // 
            // dgvquan
            // 
            this.dgvquan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvquan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvquan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvquan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvquan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvquan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvquan.Location = new System.Drawing.Point(0, 184);
            this.dgvquan.Name = "dgvquan";
            this.dgvquan.ReadOnly = true;
            this.dgvquan.RowHeadersWidth = 25;
            this.dgvquan.Size = new System.Drawing.Size(1010, 566);
            this.dgvquan.TabIndex = 3;
            this.dgvquan.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvquan_CellBeginEdit);
            this.dgvquan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvquan_RowEnter);
            this.dgvquan.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvquan_CellStateChanged);
            // 
            // cmbthanhpho
            // 
            this.cmbthanhpho.AutoComplete = false;
            this.cmbthanhpho.AutoDropdown = false;
            this.cmbthanhpho.BackColorEven = System.Drawing.Color.White;
            this.cmbthanhpho.BackColorOdd = System.Drawing.Color.White;
            this.cmbthanhpho.ColumnNames = "";
            this.cmbthanhpho.ColumnWidthDefault = 75;
            this.cmbthanhpho.ColumnWidths = "";
            this.cmbthanhpho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbthanhpho.FormattingEnabled = true;
            this.cmbthanhpho.LinkedColumnIndex = 0;
            this.cmbthanhpho.LinkedTextBox = null;
            this.cmbthanhpho.Location = new System.Drawing.Point(151, 74);
            this.cmbthanhpho.Name = "cmbthanhpho";
            this.cmbthanhpho.Size = new System.Drawing.Size(121, 21);
            this.cmbthanhpho.TabIndex = 3;
            // 
            // txtmaquan
            // 
            this.txtmaquan.Location = new System.Drawing.Point(151, 24);
            this.txtmaquan.Name = "txtmaquan";
            this.txtmaquan.ReadOnly = true;
            this.txtmaquan.Size = new System.Drawing.Size(121, 20);
            this.txtmaquan.TabIndex = 4;
            // 
            // txttenquan
            // 
            this.txttenquan.Location = new System.Drawing.Point(151, 49);
            this.txttenquan.Name = "txttenquan";
            this.txttenquan.Size = new System.Drawing.Size(172, 20);
            this.txttenquan.TabIndex = 5;
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
            this.toolbar1.TabIndex = 1;
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
            this.ucLink1.TabIndex = 0;
            // 
            // Quan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvquan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.ucLink1);
            this.Name = "Quan";
            this.Size = new System.Drawing.Size(1010, 750);
            this.Load += new System.EventHandler(this.Quan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKS.PL.CMS.UcLink ucLink1;
        private QUANLYCHAMCONG.PL.CMS.Toolbar toolbar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Datagridview.CustomGrid dgvquan;
        private MultiColumnCombobox.MultiColumnComboBox cmbthanhpho;
        private System.Windows.Forms.TextBox txtmaquan;
        private System.Windows.Forms.TextBox txttenquan;
    }
}
