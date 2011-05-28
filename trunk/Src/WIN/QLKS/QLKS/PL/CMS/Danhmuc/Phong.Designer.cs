namespace QLKS.PL.CMS.Danhmuc
{
    partial class Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.label3 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.dgvgd = new Datagridview.CustomGrid();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbloaiphong = new MultiColumnCombobox.MultiColumnComboBox();
            this.toolbar1 = new QUANLYCHAMCONG.PL.CMS.Toolbar();
            this.ucLink1 = new QLKS.PL.CMS.UcLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại phòng :";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(133, 46);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(172, 20);
            this.txttenphong.TabIndex = 5;
            // 
            // dgvgd
            // 
            this.dgvgd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgd.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvgd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvgd.Location = new System.Drawing.Point(0, 181);
            this.dgvgd.Name = "dgvgd";
            this.dgvgd.ReadOnly = true;
            this.dgvgd.RowHeadersWidth = 25;
            this.dgvgd.Size = new System.Drawing.Size(1010, 569);
            this.dgvgd.TabIndex = 23;
            this.dgvgd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvgd_CellBeginEdit);
            this.dgvgd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgd_RowEnter);
            this.dgvgd.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvgd_CellStateChanged);
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(133, 24);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.ReadOnly = true;
            this.txtmaphong.Size = new System.Drawing.Size(121, 20);
            this.txtmaphong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên  Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbloaiphong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttenphong);
            this.panel1.Controls.Add(this.txtmaphong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 113);
            this.panel1.TabIndex = 22;
            // 
            // cmbloaiphong
            // 
            this.cmbloaiphong.AutoComplete = false;
            this.cmbloaiphong.AutoDropdown = false;
            this.cmbloaiphong.BackColorEven = System.Drawing.Color.White;
            this.cmbloaiphong.BackColorOdd = System.Drawing.Color.White;
            this.cmbloaiphong.ColumnNames = "";
            this.cmbloaiphong.ColumnWidthDefault = 75;
            this.cmbloaiphong.ColumnWidths = "";
            this.cmbloaiphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbloaiphong.FormattingEnabled = true;
            this.cmbloaiphong.LinkedColumnIndex = 0;
            this.cmbloaiphong.LinkedTextBox = null;
            this.cmbloaiphong.Location = new System.Drawing.Point(133, 68);
            this.cmbloaiphong.Name = "cmbloaiphong";
            this.cmbloaiphong.Size = new System.Drawing.Size(121, 21);
            this.cmbloaiphong.TabIndex = 24;
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
            this.toolbar1.TabIndex = 21;
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
            this.ucLink1.TabIndex = 20;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvgd);
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.ucLink1);
            this.Controls.Add(this.panel1);
            this.Name = "Phong";
            this.Size = new System.Drawing.Size(1010, 750);
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenphong;
        private Datagridview.CustomGrid dgvgd;
        private System.Windows.Forms.TextBox txtmaphong;
        private QUANLYCHAMCONG.PL.CMS.Toolbar toolbar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UcLink ucLink1;
        private System.Windows.Forms.Panel panel1;
        private MultiColumnCombobox.MultiColumnComboBox cmbloaiphong;
    }
}
