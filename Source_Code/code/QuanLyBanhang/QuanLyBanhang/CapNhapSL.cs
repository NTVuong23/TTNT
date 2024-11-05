using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuanLyBanhang
{
    public partial class CapNhapSL : Form
    {
        string sql;
        public CapNhapSL()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            sql = "select hdn.hd_nhap,SanPham.ma_sp,SanPham.ten_sp,hdn.sl from hdn left join SanPham on SanPham.ma_sp = hdn.ma_sp";
            dgv_BSSP.DataSource = Function.GetDataTable(sql);
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSP.Text) && !string.IsNullOrEmpty(txt_tsp.Text))
            {
                if (btn_timkiem.Text == "Lưu")
                    sql = "update hdn set sl=sl+ '" + nud_sl.Text + "' where ma_sp='" + txt_msp.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
                MessageBox.Show("Bổ Sung Thành Công");
            }
            else
            {
                if (txt_timkiemSP.Text == "")
                {
                    sql = "select hdn.hd_nhap,SanPham.ma_sp,SanPham.ten_sp,hdn.sl from hdn left join SanPham on SanPham.ma_sp = hdn.ma_sp";
                    dgv_BSSP.DataSource = Function.GetDataTable(sql);
                }
                else
                {
                    sql = "select hdn.hd_nhap,SanPham.ma_sp,SanPham.ten_sp,hdn.sl from hdn left join SanPham on SanPham.ma_sp = hdn.ma_sp where SanPham.ten_sp like'%" + txt_timkiemSP.Text + "%'";
                    dgv_BSSP.DataSource = Function.GetDataTable(sql);
                }
            
            }
        }

        private void CapNhapSL_Load(object sender, EventArgs e)
        {
            loaddata();
            dgv_BSSP.Columns[0].HeaderText = "Số Phiếu";
            dgv_BSSP.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgv_BSSP.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgv_BSSP.Columns[3].HeaderText = "Số Lượng";
        }

        private void txt_timkiemSP_MouseClick(object sender, MouseEventArgs e)
        {
            txt_timkiemSP.Clear();
        }

        private void dgv_BSSP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_BSSP.CurrentRow != null)
            {
                txtSP.Text = dgv_BSSP.CurrentRow.Cells[0].Value.ToString();
                txt_msp.Text = dgv_BSSP.CurrentRow.Cells[1].Value.ToString();
                txt_tsp.Text = dgv_BSSP.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btn_hoanTra_Click(object sender, EventArgs e)
        {
            if (btn_bs.Text == "Bổ Sung")
            {
                btn_bs.Text = "Hủy";
                btn_timkiem.Text = "Lưu";
            }
            else
            {
                btn_bs.Text = "Bổ Sung";
                btn_timkiem.Text = "Tìm Kiếm";
            }
        }
    }
}
