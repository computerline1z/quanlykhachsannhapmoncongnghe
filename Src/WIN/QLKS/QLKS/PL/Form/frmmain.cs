using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKS.BLL.BL;
using QLKS.PL.Images.Danhmuc;
using QLKS.PL.CMS.Danhmuc;

namespace QLKS
{
    public partial class frmmain : Form
    {
        Quan q;
        ThanhPho tp;
        QuocGia quocgia;
        LoaiKH lkh;
        LoaiPhong lp;
        Phong ph;
        Chucvu cv;
        Thamso ts;
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            EventForMenuLeft();
        }
        public void EventForMenuLeft()
        {
            this.ucLeftToolBar1.Quan += new QLKS.PL.CMS.UcLeftToolBar._AddQuan(ucLeftToolBar1_Quan);
            this.ucLeftToolBar1.ThanhPho += new QLKS.PL.CMS.UcLeftToolBar._AddThanhPho(ucLeftToolBar1_ThanhPho);
            this.ucLeftToolBar1.Quocgia += new QLKS.PL.CMS.UcLeftToolBar._AddQuocGia(ucLeftToolBar1_Quocgia);
            this.ucLeftToolBar1.LoaiKH += new QLKS.PL.CMS.UcLeftToolBar._AddLoaiKH(ucLeftToolBar1_LoaiKH);
            this.ucLeftToolBar1.LoaiPhong += new QLKS.PL.CMS.UcLeftToolBar._AddLoaiPhong(ucLeftToolBar1_LoaiPhong);
            this.ucLeftToolBar1.Phong += new QLKS.PL.CMS.UcLeftToolBar._AddPhong(ucLeftToolBar1_Phong);
            this.ucLeftToolBar1.Chucvu += new QLKS.PL.CMS.UcLeftToolBar._AddChucVu(ucLeftToolBar1_Chucvu);
            this.ucLeftToolBar1.ThamSo += new QLKS.PL.CMS.UcLeftToolBar._AddThamSo(ucLeftToolBar1_ThamSo);
        }
        void AddThamSo(ref GroupBox gr)
        {
            ts = new  Thamso();
            ts.Dock = DockStyle.Top;
            gr.Controls.Add(ts);
        }
        void ucLeftToolBar1_ThamSo()
        {
            Common.Remove(ref this.grmain);
            AddThamSo(ref this.grmain);
        }
        void AddChucVu(ref GroupBox gr)
        {
            cv = new Chucvu();
            cv.Dock = DockStyle.Top;
            gr.Controls.Add(cv);
        }
        void ucLeftToolBar1_Chucvu()
        {
            Common.Remove(ref this.grmain);
            AddChucVu(ref this.grmain);
        }

        void AddPhong(ref GroupBox gr)
        {
            ph = new  Phong();
            ph.Dock = DockStyle.Top;
            gr.Controls.Add(ph);
        }
        void ucLeftToolBar1_Phong()
        {
            Common.Remove(ref this.grmain);
            AddPhong(ref this.grmain);
        }
        void AddLoaiPhong(ref GroupBox gr)
        {

            lp = new  LoaiPhong();
            lp.Dock = DockStyle.Top;
            gr.Controls.Add(lp);
        }
        void ucLeftToolBar1_LoaiPhong()
        {
            Common.Remove(ref this.grmain);
            AddLoaiPhong(ref this.grmain);
        }
        void AddLoaiKH(ref GroupBox gr)
        {
            lkh = new  LoaiKH();
            lkh.Dock = DockStyle.Top;
            gr.Controls.Add(lkh);
        }
        void ucLeftToolBar1_LoaiKH()
        {
            Common.Remove(ref this.grmain);
            AddLoaiKH(ref this.grmain);
        }
        void AddQuocGia(ref GroupBox gr)
        {
            quocgia = new QuocGia();
            quocgia.Dock = DockStyle.Top;
            gr.Controls.Add(quocgia);
        }
        void ucLeftToolBar1_Quocgia()
        {
            Common.Remove(ref this.grmain);
            AddQuocGia(ref this.grmain);
        }
        void AddThanhPho(ref GroupBox gr)
        {
            tp = new ThanhPho();
            tp.Dock = DockStyle.Top;
            gr.Controls.Add(tp);
        }
        void ucLeftToolBar1_ThanhPho()
        {
            Common.Remove(ref this.grmain);
            AddThanhPho(ref this.grmain);
        }
        void AddQuan(ref GroupBox gr)
        {
            q = new Quan();
            q.Dock = DockStyle.Top;
            gr.Controls.Add(q);
        }
        void ucLeftToolBar1_Quan()
        {
            Common.Remove(ref this.grmain);
            AddQuan(ref this.grmain);
        }
    }
}
