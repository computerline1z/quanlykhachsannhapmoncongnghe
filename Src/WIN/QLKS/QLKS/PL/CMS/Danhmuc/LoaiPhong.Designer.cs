namespace QLKS.PL.CMS.Danhmuc
{
    partial class LoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttenlp = new System.Windows.Forms.TextBox();
            this.txtlp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvgd = new Datagridview.CustomGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.toolbar1 = new QUANLYCHAMCONG.PL.CMS.Toolbar();
            this.ucLink1 = new QLKS.PL.CMS.UcLink();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtdongia);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttenlp);
            this.panel1.Controls.Add(this.txtlp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 151);
            this.panel1.TabIndex = 18;
            // 
            // txttenlp
            // 
            this.txttenlp.Location = new System.Drawing.Point(151, 49);
            this.txttenlp.Name = "txttenlp";
            this.txttenlp.Size = new System.Drawing.Size(172, 20);
            this.txttenlp.TabIndex = 5;
            // 
            // txtlp
            // 
            this.txtlp.Location = new System.Drawing.Point(151, 24);
            this.txtlp.Name = "txtlp";
            this.txtlp.ReadOnly = true;
            this.txtlp.Size = new System.Drawing.Size(121, 20);
            this.txtlp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại Phòng:";
            // 
            // dgvgd
            // 
            this.dgvgd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvgd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvgd.Location = new System.Drawing.Point(0, 218);
            this.dgvgd.Name = "dgvgd";
            this.dgvgd.ReadOnly = true;
            this.dgvgd.RowHeadersWidth = 25;
            this.dgvgd.Size = new System.Drawing.Size(1010, 532);
            this.dgvgd.TabIndex = 19;
            this.dgvgd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvgd_CellBeginEdit);
            this.dgvgd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgd_RowEnter);
            this.dgvgd.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvgd_CellStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú :";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(151, 98);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(836, 44);
            this.txtghichu.TabIndex = 9;
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
            this.toolbar1.TabIndex = 17;
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
            this.ucLink1.TabIndex = 16;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(151, 72);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(172, 20);
            this.txtdongia.TabIndex = 10;
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.dgvgd);
            this.Controls.Add(this.ucLink1);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiPhong";
            this.Size = new System.Drawing.Size(1010, 750);
            this.Load += new System.EventHandler(this.LoaiPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttenlp;
        private System.Windows.Forms.TextBox txtlp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QUANLYCHAMCONG.PL.CMS.Toolbar toolbar1;
        private Datagridview.CustomGrid dgvgd;
        private UcLink ucLink1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtdongia;
    }
}
