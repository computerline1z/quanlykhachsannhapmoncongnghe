using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datagridview;
using System.Drawing;

namespace QLKS.BLL.BL
{
    public class Common
    {
        private static int _flag = 0;

        public static int Flag
        {
            get { return Common._flag; }
            set { Common._flag = value; }
        }

        private static string _MaNV;

        public static string MaNV
        {
            get { return Common._MaNV; }
            set { Common._MaNV = value; }
        }
        public static void Remove(ref GroupBox gr)
        {
            foreach (Control c in gr.Controls)
            {
                if (c.Name.ToString() != "grmain")
                {
                    gr.Controls.Remove(c);
                    break;
                }
            }

        }
        public static void HightLightDataGridViewRow(ref DataGridView dgv, System.Data.DataTable dt)
        {
            // Setting the style of the DataGridView control
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            dgv.DefaultCellStyle.BackColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = SystemColors.ControlDarkDark;

            // Binding the DataGridViewControl to the DataSet generated above
            dgv.DataSource = dt;
            // Changing the last column alignment to be in the Right alignment            
            dgv.Columns[dgv.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Adjusting each column to be fit as the content of all its cells, including the header cell
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //MyDataGridView.Columns[0].Visible = false;
        }
        public static void HightLightDataGridViewRow(ref CustomGrid dgv, System.Data.DataTable dt)
        {
            try
            {
                // Setting the style of the DataGridView control
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
                dgv.DefaultCellStyle.BackColor = Color.Empty;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgv.GridColor = SystemColors.ControlDarkDark;

                // Binding the DataGridViewControl to the DataSet generated above
                dgv.DataSource = dt;
                // Changing the last column alignment to be in the Right alignment            
                dgv.Columns[dgv.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

                // Adjusting each column to be fit as the content of all its cells, including the header cell
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                //MyDataGridView.Columns[0].Visible = false;
            }
            catch { }
        }
        //custom control 
    }
}
