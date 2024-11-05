using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;


namespace QuanLyBanhang
{
    public partial class PhieuNhap : Form
    {
        private string sql;
        DataTable dt;
        public PhieuNhap()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            sql = "SELECT hdn.hd_nhap, NhanVien.ma_nv, NhanVien.ten,SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,hdn.ngay_lp,hdn.sl,hdn.dg,(hdn.sl * hdn.dg) FROM hdn  LEFT JOIN SanPham ON hdn.ma_sp = SanPham.ma_sp LEFT JOIN NhanVien ON hdn.ma_nv = NhanVien.ma_nv";
            dt = Function.GetDataTable(sql);
            dgv_hdn.DataSource = dt;
            tong();
        }
        private void tong()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgv_hdn.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells[8].Value);
                int donGia = Convert.ToInt32(row.Cells[9].Value);
                sum += soLuong * donGia;
            }
            lbl_tongst.Text = sum.ToString();
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxData();
            dgv_hdn.Columns[0].HeaderText = "Số Phiếu";
            dgv_hdn.Columns[1].HeaderText = "Mã Nhân Viên";
            dgv_hdn.Columns[2].HeaderText = "Họ Tên";
            dgv_hdn.Columns[3].HeaderText = "Mã Sản Phẩm";
            dgv_hdn.Columns[4].HeaderText = "Tên Sản Phẩm";
            dgv_hdn.Columns[5].HeaderText = "Hãng SX";
            dgv_hdn.Columns[6].HeaderText = "Mặt Hàng";
            dgv_hdn.Columns[7].HeaderText = "Ngày Nhập";
            dgv_hdn.Columns[8].HeaderText = "Số Lượng";
            dgv_hdn.Columns[9].HeaderText = "Đơn Giá";
            dgv_hdn.Columns[10].HeaderText = "Thành Tiền";
            dgv_hdn.Columns[7].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            cb_manv.Focus();
        }
        private void ClearTextBox()     
        {
            Random random = new Random();
            string sp;
            sp = "SP" + random.Next(1, 999).ToString();
            txt_Sophieu.Text = sp;
            nud_sl.Text = "";
            txt_dg.Text = "";
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from hdn where hd_nhap='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }
        private void LoadComboBoxData()
        {
            sql = "select SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang from SanPham left join NhaCungCap on SanPham.ma_nhacc=NhaCungCap.ma_nhacc";
            DataTable mtTable1 = Function.GetDataTable(sql);
            sql = "select ma_nv,ten from NhanVien";
            DataTable mtTable2 = Function.GetDataTable(sql);

            // Gán dữ liệu vào ComboBoxes
            cb_masp.DataSource = mtTable1;
            cb_masp.DisplayMember = "ma_sp";
            cb_masp.ValueMember = "ma_sp";

            cb_tensp.DataSource = mtTable1;
            cb_tensp.DisplayMember = "ten_sp";
            cb_tensp.ValueMember = "ten_sp";

            cb_hangsx.DataSource = mtTable1;
            cb_hangsx.DisplayMember = "hang_sx";
            cb_hangsx.ValueMember = "hang_sx";

            txt_loaihang.DataBindings.Add("Text", mtTable1, "mat_hang");

            cb_manv.DataSource = mtTable2;
            cb_manv.DisplayMember = "ma_nv";
            cb_manv.ValueMember = "ma_nv";

            cb_tennv.DataSource = mtTable2;
            cb_tennv.DisplayMember = "ten";
            cb_tennv.ValueMember = "ten";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txt_Sophieu.Text.Trim();
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnSua.Text = "Lưu";
                btnLammoi.Enabled = false;
                btnXoa.Enabled = false;

            }
            else if (btnThem.Text == "Lưu")
            {
                if ((int.TryParse(txt_dg.Text, out _)))              
                    {
                    int x = GetGiaNhapcu(txt_Sophieu.Text, cb_manv.Text, cb_masp.Text);
                    int y = Convert.ToInt32(txt_dg.Text);
                    sql = "update hdn set ngay_lp='" + dateNgayLap.Value.ToString("yyyy-MM-dd") + "', sl=N'" + nud_sl.Text + "', dg=(" + x + "+" + y + ")/2 where hd_nhap='" + ma + "'  and ma_nv='" + cb_manv.Text + "' and ma_sp='" + cb_masp.Text + "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    ClearTextBox();
                    cb_manv.Focus();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                ClearTextBox();
                cb_manv.Focus();
            }
        }
        private int GetGiaNhapcu(string SP, string manv, string masp)
        {
            string query = "SELECT dg FROM hdn WHERE hd_nhap = '" + SP + "' and ma_nv = '" + manv + "' and ma_sp='" + masp + "'";
            int dg = Convert.ToInt32(Function.ExecuteScalar(query));
            return dg;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txt_Sophieu.Text.Trim();
 
            if (btnSua.Text == "Sửa")
            {
                btnThem.Text = "Lưu";
                btnSua.Text = "Hủy";
                btnXoa.Enabled = false;
                btnLammoi.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (!checkID(ma))
                {
                    if ((int.TryParse(txt_dg.Text, out _)) && (!string.IsNullOrEmpty(nud_sl.Text)))                    {
                        long z = 0;
                            int x = Convert.ToInt32(nud_sl.Text);
                            int y = Convert.ToInt32(txt_dg.Text);
                            z = x * y;
                        sql = "insert into hdn values('" + txt_Sophieu.Text + "','" + cb_manv.Text + "','" + cb_masp.Text + "','" + dateNgayLap.Value.ToString("yyyy-MM-dd") + "','" + nud_sl.Text + "','" + txt_dg.Text + "','" + z + "')";
                        Function.ExecuteNonQuery(sql);
                        loaddata();
                        ClearTextBox();
                        cb_manv.Focus();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                ClearTextBox();
                cb_manv.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "delete hdn where hd_nhap='" + txt_Sophieu.Text + "'  and ma_nv='"+cb_manv.Text+"' and ma_sp='"+cb_masp.Text+"' ";
                Function.ExecuteNonQuery(sql);
                loaddata();
            }
        }

        private void dgv_hdn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hdn.CurrentRow != null)
            {
                txt_Sophieu.Text = dgv_hdn.CurrentRow.Cells[0].Value.ToString();
                cb_manv.Text = dgv_hdn.CurrentRow.Cells[1].Value.ToString();
                cb_tennv.Text = dgv_hdn.CurrentRow.Cells[2].Value.ToString();
                cb_masp.Text = dgv_hdn.CurrentRow.Cells[3].Value.ToString();
                cb_tensp.Text = dgv_hdn.CurrentRow.Cells[4].Value.ToString();
                cb_hangsx.Text = dgv_hdn.CurrentRow.Cells[5].Value.ToString();
                txt_loaihang.Text = dgv_hdn.CurrentRow.Cells[6].Value.ToString();
                dateNgayLap.Text = dgv_hdn.CurrentRow.Cells[7].Value.ToString();
                nud_sl.Text = dgv_hdn.CurrentRow.Cells[8].Value.ToString();
                txt_dg.Text = dgv_hdn.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenSP.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "SELECT hdn.hd_nhap, NhanVien.ma_nv, NhanVien.ten,SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,hdn.ngay_lp,hdn.sl,hdn.dg,(hdn.sl * hdn.dg) FROM hdn  LEFT JOIN SanPham ON hdn.ma_sp = SanPham.ma_sp LEFT JOIN NhanVien ON hdn.ma_nv = NhanVien.ma_nv where SanPham.ten_sp like '%"+txt_TKtenSP.Text+"%'";
                dgv_hdn.DataSource = Function.GetDataTable(sql);
                tong();
            }
        }

        private void txt_TKtenSP_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenSP.Clear();
        }

        private void btn_cnp_Click(object sender, EventArgs e)
        {
            Menu_phuNhap.Show(btn_cnp, 0, btn_cnp.Height);
        }

        private void Menu_PhufileExcel_Click(object sender, EventArgs e)
        {
            if (dgv_hdn.SelectedRows.Count > 0)
            {
                // Tạo DataTable mới và thêm các dòng được chọn vào
                DataTable selectedDataTable = dt.Clone();
                foreach (DataGridViewRow selectedRow in dgv_hdn.SelectedRows)
                {
                    DataRowView dataRowView = selectedRow.DataBoundItem as DataRowView;
                    if (dataRowView != null)
                    {
                        selectedDataTable.ImportRow(dataRowView.Row);
                    }
                }

                // Gọi hàm ExportFile với DataTable mới chứa các dòng được chọn
                ExportFile(selectedDataTable, "Hoa don", "Hoá thanh toán");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xuất file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Tạo màu tiêu đề
            head.Interior.Color = ColorTranslator.ToOle(Color.Red);
            // Tạo tiêu đề cột 
            string[] columnNames = { "Số Phiếu", "Mã nhân viên", "Tên nhân viên", "Mã Sản Phẩm", "Tên Sản Phẩm", "Hãng Sản Xuất", "Mặt Hàng", "Ngày Nhập", "Số Lượng", "Đơn Giá", "Thành tiền" };
            double[] columnWidths = { 20.0, 18.0, 18.0, 15.5, 21.5, 20.5, 20.5, 18.5, 10, 18.5, 20.0 };

            for (int i = 0; i < columnNames.Length; i++)
            {
                Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(((char)('A' + i)).ToString() + "3");
                cl.Value2 = columnNames[i];
                cl.ColumnWidth = columnWidths[i];
            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] a = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    a[i, j] = dataRow[j];
                }
            }
            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = a;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cả bảng
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oSheet.get_Range("H:H").NumberFormat = "DD-MM-YYYY";
            oSheet.get_Range("J:J").NumberFormat = "#,##0";
            oSheet.get_Range("K:K").NumberFormat = "#,##0";

            // Tạo ô cho Tổng Số Tiền dưới cột L
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.Cells[rowEnd + 1, columnEnd - 1];
            cl14.Value2 = "Tổng Số Tiền:";
            cl14.ColumnWidth = 17;
            cl14.Font.Bold = true;
            cl14.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tìm số dòng cuối cùng trong cột "Thành Tiền"
            int lastRow = oSheet.Cells[oSheet.Rows.Count, "K"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;

            // Tạo phạm vi dữ liệu từ dòng 4 đến dòng cuối cùng trong cột "Thành Tiền"
            Microsoft.Office.Interop.Excel.Range re = oSheet.get_Range("K4", $"K{lastRow}");

            // Tính tổng các giá trị trong phạm vi dữ liệu
            long sum = 0;
            foreach (Microsoft.Office.Interop.Excel.Range cell in re.Cells)
            {
                if (cell.Value != null)
                {
                    long cellValue = (long)cell.Value;
                    sum += cellValue;
                }
            }

            //Tạo ô cho giá trị tổng ST của cột Thành tiền dưới cột M
            Microsoft.Office.Interop.Excel.Range cl15 = oSheet.Cells[rowEnd + 1, columnEnd];
            cl15.Font.Bold = true;
            cl15.Formula = sum.ToString();
            cl15.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Thiết lập định dạng cho ô giá trị tổng ST của cột Thành Tiền
            Microsoft.Office.Interop.Excel.Range tongTienColumn = oSheet.get_Range("K:K");
            tongTienColumn.NumberFormat = "#,##0";


            // Giải phóng các đối tượng COM
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oSheets);
            Marshal.ReleaseComObject(oBook);
            Marshal.ReleaseComObject(oBooks);
            Marshal.ReleaseComObject(oExcel);
        }

        private void Menu_PhuBSCN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapNhapSL cnsl = new CapNhapSL();
            cnsl.ShowDialog();
            loaddata();
            this.Show();
        }
    }
  
}
