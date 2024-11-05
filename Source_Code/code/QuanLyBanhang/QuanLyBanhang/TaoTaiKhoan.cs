using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanhang
{
    public partial class TaoTaiKhoan : Form
    {
        private string sql, callForm, pass, newPassword;
        private bool isPasswordVisible = false;

        public TaoTaiKhoan(string xd_form)
        {
            InitializeComponent();
            callForm = xd_form;
        }

        private void loaddata()
        {
            if (callForm != "Menu_NV")
            {
                sql = "select * from t_k";
                dgv_tk.DataSource = Function.GetDataTable(sql);
            }
            else
            {
                sql = "select * from t_k where tk='" + Function.TaiKhoanInfo.TenTaiKhoan.Trim() + "'";
                dgv_tk.DataSource = Function.GetDataTable(sql);
                txt_TKtenKH.Visible = false;
                btn_timkiem.Visible = false;
                btn_Sua.Visible = false;
                btn_xoa.Visible = false;
                btdk.Visible = false;
                txtmk.ReadOnly = true;

            }
        }

        private void btdk_Click(object sender, EventArgs e)
        {
            string ma = cb_tk.Text.Trim();
            if (btdk.Text == "Thêm")
            {
                btdk.Text = "Hủy";
                btn_Sua.Text = "Lưu";
                btn_xoa.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_TKtenKH.Enabled = false;
            }
            else if (btdk.Text == "Lưu")
            {

                sql = "update t_k set ten_nd=N'" + cb_tnv.Text + "',cv=N'" + cb_cv.Text + "', mk='" + txtmk.Text + "' where tk='" + cb_tk.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
                cb_tk.Focus();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                ClearTexBox();
            }
            else
            {
                btdk.Text = "Thêm";
                btn_Sua.Text = "Sửa";
                btn_xoa.Enabled = true;
                txt_TKtenKH.Enabled = true;
                btn_timkiem.Enabled = true;
                ClearTexBox();
            }
        }

        private bool KiemTratk(string taiKhoan)
        {
            sql = "SELECT COUNT(*) FROM t_k WHERE tk = '" + taiKhoan + "'";
            int count = Convert.ToInt32(Function.ExecuteScalar(sql));
            return count > 0;
        }

        private void LoadMaNhanVienToComboBox()
        {
            if (callForm != "Menu_NV")
            {
                sql = "select ma_nv, ten from NhanVien";
                DataTable dt = Function.GetDataTable(sql);
                cb_tk.DataSource = dt;
                cb_tk.DisplayMember = "ma_nv";
                cb_tk.ValueMember = "ma_nv";


                cb_tnv.DataSource = dt;
                cb_tnv.DisplayMember = "ten";
                cb_tnv.ValueMember = "ten";
            }

        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadMaNhanVienToComboBox();
            dgv_tk.Columns[0].HeaderText = "Tài Khoản";
            dgv_tk.Columns[1].HeaderText = "Mật Khẩu";
            dgv_tk.Columns[2].HeaderText = "Người Dùng";
            dgv_tk.Columns[3].HeaderText = "Chức vụ";
            eye_lock.Visible = true;
            eye_open.Visible = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string ma = cb_tk.Text.Trim();
            if (btn_Sua.Text == "Sửa")
            {
                btdk.Text = "Lưu";
                btn_Sua.Text = "Hủy";
                btn_xoa.Enabled = false;
                btn_timkiem.Enabled = false;
                txt_TKtenKH.Enabled = false;
            }
            else if (btn_Sua.Text == "Lưu")
            {
                if (!KiemTratk(cb_tk.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(txtmk.Text))
                    {
                        sql = "insert into t_k values('" + cb_tk.Text + "','" + txtmk.Text + "',N'" + cb_tnv.Text + "',N'" + cb_cv.Text + "')";
                        Function.ExecuteNonQuery(sql);
                        loaddata();
                        cb_tk.Focus();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        ClearTexBox();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btdk.Text = "Thêm";
                btn_Sua.Text = "Sửa";
                btn_xoa.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_TKtenKH.Enabled = true;
                ClearTexBox();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_tk.Text) || !string.IsNullOrEmpty(cb_tnv.Text) || !string.IsNullOrEmpty(txtmk.Text))
            {
                DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "delete t_k where tk='" + cb_tk.Text + "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    ClearTexBox();
                }
            }
        }

        private void ClearTexBox()
        {
            txtmk.Text = "";
            cb_tk.Focus();
        }

        private void dgv_tk_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tk.CurrentRow != null)
            {
                cb_tk.Text = dgv_tk.CurrentRow.Cells[0].Value.ToString();
                pass = dgv_tk.CurrentRow.Cells[1].Value.ToString(); // Lưu mật khẩu gốc
                txtmk.Text = new string('*', pass.Length); // Mã hóa mật khẩu
                newPassword = ""; // Xóa mật khẩu mới khi chọn tài khoản khác
                cb_tnv.Text = dgv_tk.CurrentRow.Cells[2].Value.ToString();
                cb_cv.Text = dgv_tk.CurrentRow.Cells[3].Value.ToString();
                eye_lock.Visible = true;
                eye_open.Visible = false;
            }
        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                newPassword = txtmk.Text; // Lưu mật khẩu mới khi người dùng nhập
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenKH.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "select * from t_k where ten_nd like '%" + txt_TKtenKH.Text + "%'";
                dgv_tk.DataSource = Function.GetDataTable(sql);
            }
        }

        private void dgv_tk_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_tk.Columns[e.ColumnIndex].HeaderText == "Mật Khẩu" && e.Value != null)
            {
                //Mã hóa mật khẩu thành ký tự *
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void eye_lock_Click(object sender, EventArgs e)
        {
            eye_lock.Visible = false;
            isPasswordVisible = true;
            if (!string.IsNullOrEmpty(newPassword))
            {
                txtmk.Text = newPassword; // Hiển thị mật khẩu mới nếu có
            }
            else
            {
                txtmk.Text = pass; // Hiển thị mật khẩu gốc nếu không có mật khẩu mới
            }
            eye_open.Visible = true;
        }

        private void eye_open_Click(object sender, EventArgs e)
        {
            eye_open.Visible = false;
            isPasswordVisible = false;
            txtmk.Text = new string('*', (string.IsNullOrEmpty(newPassword) ? pass : newPassword).Length);
            eye_lock.Visible = true;
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenKH.Clear();
        }
    }
}
