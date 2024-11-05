
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

namespace QuanLyBanhang
{
    public partial class HoaDoncs : Form
    {
        private string pb;
        public HoaDoncs(string xd_nv)
        {
            InitializeComponent();
            pb= xd_nv;
        }
        private string sql;
        DataTable dt;
        private void loaddata()
        {
            if (pb == "Nhan Vien")
            {
                sql = "SELECT hdx.hd_xuat, NhanVien.ma_nv, NhanVien.ten,KhachHang.ma_kh,KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl * hdx.dg) FROM hdx LEFT JOIN KhachHang ON hdx.ma_kh = KhachHang.ma_kh LEFT JOIN SanPham ON hdx.ma_sp = SanPham.ma_sp LEFT JOIN NhanVien ON hdx.ma_nv = NhanVien.ma_nv where NhanVien.ma_nv='"+Function.TaiKhoanInfo.TenTaiKhoan.Trim()+"'";
                dt = Function.GetDataTable(sql);
                dgv_hdx.DataSource = dt;
                tong();
                TSMN_giamGia.Visible = false;
            }
            else
            {
                sql = "SELECT hdx.hd_xuat, NhanVien.ma_nv, NhanVien.ten,KhachHang.ma_kh,KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl * hdx.dg) FROM hdx LEFT JOIN KhachHang ON hdx.ma_kh = KhachHang.ma_kh LEFT JOIN SanPham ON hdx.ma_sp = SanPham.ma_sp LEFT JOIN NhanVien ON hdx.ma_nv = NhanVien.ma_nv";
                dt = Function.GetDataTable(sql);
                dgv_hdx.DataSource = dt;
                tong();
            }

        }
        private void tong()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgv_hdx.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells[10].Value);
                int donGia = Convert.ToInt32(row.Cells[11].Value);
                sum += soLuong * donGia;
            }
            lbl_tongst.Text = sum.ToString();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxData()
        {
            if(pb =="Nhan Vien")
            {
                sql = "select ma_nv,ten from NhanVien where ma_nv='"+Function.TaiKhoanInfo.TenTaiKhoan.Trim()+"'";
                DataTable mtTable3 = Function.GetDataTable(sql);
                cb_manv.DataSource = mtTable3;
                cb_manv.DisplayMember = "ma_nv";
                cb_manv.ValueMember = "ma_nv";

                cb_tennv.DataSource = mtTable3;
                cb_tennv.DisplayMember = "ten";
                cb_tennv.ValueMember = "ten";
            }
            else
            {
                sql = "select ma_nv,ten from NhanVien";
                DataTable mtTable3 = Function.GetDataTable(sql);
                cb_manv.DataSource = mtTable3;
                cb_manv.DisplayMember = "ma_nv";
                cb_manv.ValueMember = "ma_nv";

                cb_tennv.DataSource = mtTable3;
                cb_tennv.DisplayMember = "ten";
                cb_tennv.ValueMember = "ten";
            }
            sql = "select ma_sp,ten_sp,hang_sx,mat_hang from SanPham";
            DataTable mtTable1 = Function.GetDataTable(sql);

            sql = "select ma_kh,ten from KhachHang";
            DataTable mtTable2 = Function.GetDataTable(sql);



            // Gán dữ liệu vào ComboBoxes
            cb_mankh.DataSource = mtTable2;
            cb_mankh.DisplayMember = "ma_kh";
            cb_mankh.ValueMember = "ma_kh";

            cb_tenkh.DataSource = mtTable2;
            cb_tenkh.DisplayMember = "ten";
            cb_tenkh.ValueMember = "ten";

            cb_masp.DataSource = mtTable1;
            cb_masp.DisplayMember = "ma_sp";
            cb_masp.ValueMember = "ma_sp";

            cb_tensp.DataSource = mtTable1;
            cb_tensp.DisplayMember = "ten_sp";
            cb_tensp.ValueMember = "ten_sp";

            cb_hangsx.DataSource = mtTable1;
            cb_hangsx.DisplayMember = "hang_sx";
            cb_hangsx.ValueMember = "hang_sx";

            txt_loaihang.DataBindings.Add("Text", mtTable1, "Mat_hang");

        }
        private void HoaDoncs_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadComboBoxData();
            dgv_hdx.Columns[0].HeaderText = "Số Phiếu";
            dgv_hdx.Columns[1].HeaderText = "Mã Nhân Viên";
            dgv_hdx.Columns[2].HeaderText = "Họ Tên";
            dgv_hdx.Columns[3].HeaderText = "Mã KH";
            dgv_hdx.Columns[4].HeaderText = "Tên Khách Hàng";
            dgv_hdx.Columns[5].HeaderText = "Mã Sản Phẩm";
            dgv_hdx.Columns[6].HeaderText = "Tên Sản Phẩm";
            dgv_hdx.Columns[7].HeaderText = "Hãng SX";
            dgv_hdx.Columns[8].HeaderText = "Mặt Hàng";
            dgv_hdx.Columns[9].HeaderText = "Ngày Nhập";
            dgv_hdx.Columns[10].HeaderText = "Số Lượng";
            dgv_hdx.Columns[11].HeaderText = "Đơn Giá";
            dgv_hdx.Columns[12].HeaderText = "Thành Tiền";
            dgv_hdx.Columns[9].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        private void ClearTextBox()
        {
            Random random = new Random();
            string sp;
            sp = "SP" + random.Next(1, 999).ToString();
            txt_Sophieu.Text = sp;
            nud_sl.Text = "1";
            txt_donGia.Text = Convert.ToString(GetGia(cb_masp.Text));

            cb_mankh.Focus();
        }
        private bool checkID(string ma)
        {
            sql = "select count(*) from hdx where hd_xuat='" + ma + "'";
            int kq = Convert.ToInt32(Function.ExecuteScalar(sql));
            return kq > 0;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearTextBox();           
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
                btn_timkiem.Enabled=false;
                txt_TKtenKH.Enabled = false;

            }
            else if (btnThem.Text == "Lưu")
            {

                sql = "update hdx set ngay_lp='" + dateNgayLap.Value.ToString("yyyy-MM-dd") + "', sl=N'" + nud_sl.Text + "', dg='" + txt_donGia.Text + "' where hd_xuat='" + ma + "' and ma_kh='" + cb_mankh.Text + "' and ma_nv='" + cb_manv.Text + "' and ma_sp='" + cb_masp.Text + "'";
                Function.ExecuteNonQuery(sql);
                loaddata();
                ClearTextBox();
                cb_manv.Focus();
                MessageBox.Show("Sua Thanh Cong", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_TKtenKH.Enabled = true;
                ClearTextBox();
            }
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
                btn_timkiem.Enabled = false;
                txt_TKtenKH.Enabled=false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if ( !string.IsNullOrEmpty(txt_Sophieu.Text) && !checkID(ma))
                {
                    sql = "select sl from hdn where ma_sp='" + cb_masp.Text + "'";
                    string kt_sltk = Function.ExecuteScalar(sql);
                    string kt_slb = nud_sl.Text;
                    if (!string.IsNullOrEmpty(kt_sltk) && !string.IsNullOrEmpty(kt_slb))
                    {
                        int sl_tonkho = Convert.ToInt16(kt_sltk);
                        int sl_canban = Convert.ToInt16(kt_slb);

                        if (sl_canban <= sl_tonkho)
                        {
                            if (sl_tonkho >= 1)
                            {
                                long z = 0;
                                if (!string.IsNullOrEmpty(nud_sl.Text) && !string.IsNullOrEmpty(txt_donGia.Text))
                                {
                                    int x = Convert.ToInt32(nud_sl.Text);
                                    int y = Convert.ToInt32(txt_donGia.Text);
                                    z = x * y;
                                }
                                sql = "insert into hdx values('" + txt_Sophieu.Text + "','" + cb_mankh.Text + "','" + cb_masp.Text + "','" + cb_manv.Text + "','" + dateNgayLap.Value.ToString("yyyy-MM-dd") + "','" + nud_sl.Text + "','" + txt_donGia.Text + "','" + z + "')";
                                Function.ExecuteNonQuery(sql);
                                string sql2 = "update hdn set sl=sl - " + sl_canban + " where ma_sp='" + cb_masp.Text + "'";
                                Function.ExecuteNonQuery(sql2);
                                MessageBox.Show("Them Thanh Cong", "Thong bao", MessageBoxButtons.OK);
                                loaddata();
                                ClearTextBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số Lượng Tồn Kho Không Đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show("Số Lượng Sản Phẩm Hiện Có: " + sl_tonkho, "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Mã Hóa Đơn Khác!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnLammoi.Enabled = true;
                btn_timkiem.Enabled = true;
                txt_TKtenKH.Enabled = true;
                ClearTextBox();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Sophieu.Text) || !string.IsNullOrEmpty(txt_donGia.Text) || !string.IsNullOrEmpty(nud_sl.Text))
            {
                DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "delete hdx where hd_xuat='" + txt_Sophieu.Text + "' and ma_kh='" + cb_mankh.Text + "' and ma_nv='" + cb_manv.Text + "' and ma_sp='" + cb_masp.Text + "' ";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    ClearTextBox();
                }
            }
        }
        private void Menu_phu_Opening(object sender, CancelEventArgs e)
        {

        }
        private long GetGia(string masp)
        {
            sql = "select hd_nhap from hdn where ma_sp= '" + masp + "' ";
            string sp = Function.ExecuteScalar(sql);
            string query = "SELECT dg FROM hdn WHERE hd_nhap = '" + sp + "' and ma_sp='" + masp + "'";
            string gia_sp= Function.ExecuteScalar(query);
            if (string.IsNullOrEmpty(gia_sp))
            {
                return 0;
            }
            else if (Convert.ToInt64(gia_sp) <=0)
                return 0;
            else
                return Convert.ToInt64(gia_sp);
        }

        private void cb_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_donGia.Text = GetGia(cb_masp.Text).ToString();
        }

        private void dgv_hdx_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hdx.CurrentRow != null)
            {
                txt_Sophieu.Text = dgv_hdx.CurrentRow.Cells[0].Value.ToString();
                cb_manv.Text = dgv_hdx.CurrentRow.Cells[1].Value.ToString();
                cb_tennv.Text = dgv_hdx.CurrentRow.Cells[2].Value.ToString();
                cb_mankh.Text = dgv_hdx.CurrentRow.Cells[3].Value.ToString();
                cb_tenkh.Text = dgv_hdx.CurrentRow.Cells[4].Value.ToString();
                cb_masp.Text = dgv_hdx.CurrentRow.Cells[5].Value.ToString();
                cb_tensp.Text = dgv_hdx.CurrentRow.Cells[6].Value.ToString();
                cb_hangsx.Text = dgv_hdx.CurrentRow.Cells[7].Value.ToString();
                txt_loaihang.Text = dgv_hdx.CurrentRow.Cells[8].Value.ToString();
                dateNgayLap.Text = dgv_hdx.CurrentRow.Cells[9].Value.ToString();
                nud_sl.Text = dgv_hdx.CurrentRow.Cells[10].Value.ToString();
                txt_donGia.Text = dgv_hdx.CurrentRow.Cells[11].Value.ToString();
            }
        }

        private void btn_cnp_Click(object sender, EventArgs e)
        {
           Menu_phu.Show(btn_cnp,0,btn_cnp.Height);
        }

        private void TSMN_giamGia_Click(object sender, EventArgs e)
        {
                GiamGia gg = new GiamGia();
                gg.ShowDialog();
                loaddata();
                this.Show();
        }

        private void TSMN_hoanTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoanTra hoanTra = new HoanTra();
            hoanTra.ShowDialog();
            this.Show();
        }

        private void TSMN_excel_Click(object sender, EventArgs e)
        {
            if (dgv_hdx.SelectedRows.Count > 0)
            {
                // Tạo DataTable mới và thêm các dòng được chọn vào
                DataTable selectedDataTable = dt.Clone();
                foreach (DataGridViewRow selectedRow in dgv_hdx.SelectedRows)
                {
                    DataRowView dataRowView = selectedRow.DataBoundItem as DataRowView;
                    if (dataRowView != null)
                    {
                        selectedDataTable.ImportRow(dataRowView.Row);
                    }
                }

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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "M1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Tạo màu tiêu đề
            head.Interior.Color = ColorTranslator.ToOle(Color.Red);

            // Tạo tiêu đề cột 
            string[] columnNames = { "Số Phiếu","Mã nhân viên", "Tên nhân viên", "Mã Khách Hàng", "Tên Khách Hàng", "Mã Sản Phẩm", "Tên Sản Phẩm","Hãng Sản Xuất","Mặt Hàng","Ngày Lập Hóa Đơn","Số Lượng","Đơn Giá", "Thành tiền" };
            double[] columnWidths = { 20.0, 18.0, 18.0, 15.5, 20.5, 20.5, 21.5,20.5,20.5,20.5,10,18.5,20.0 };

            for (int i = 0; i < columnNames.Length; i++)
            {
                Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(((char)('A' + i)).ToString() + "3");
                cl.Value2 = columnNames[i];
                cl.ColumnWidth = columnWidths[i];
            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "M3");

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

                for (int j = 0; j < dataTable.Columns.Count ; j++)
                {
                    a[i, j] = dataRow[j];
                }
            }
            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count ;

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

            oSheet.get_Range("J:J").NumberFormat = "DD-MM-YYYY";
            oSheet.get_Range("N:N").NumberFormat = "#,##0";
            oSheet.get_Range("M:M").NumberFormat = "#,##0";

            // Tạo ô cho Tổng Số Tiền dưới cột L
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.Cells[rowEnd+1,columnEnd-1];
            cl14.Value2 = "Tổng Số Tiền:";
            cl14.ColumnWidth = 17;
            cl14.Font.Bold = true;
            cl14.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tìm số dòng cuối cùng trong cột "Thành Tiền"
            int lastRow = oSheet.Cells[oSheet.Rows.Count, "M"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;

            // Tạo phạm vi dữ liệu từ dòng 4 đến dòng cuối cùng trong cột "Thành Tiền"
            Microsoft.Office.Interop.Excel.Range re = oSheet.get_Range("M4", $"M{lastRow}");

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
            Microsoft.Office.Interop.Excel.Range tongTienColumn = oSheet.get_Range("M:M");
            tongTienColumn.NumberFormat = "#,##0";


            // Giải phóng các đối tượng COM
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oSheets);
            Marshal.ReleaseComObject(oBook);
            Marshal.ReleaseComObject(oBooks);
            Marshal.ReleaseComObject(oExcel);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenKH.Text == "")
            {
                loaddata();
            }
            else
            {
                sql = "SELECT hdx.hd_xuat, NhanVien.ma_nv, NhanVien.ten,KhachHang.ma_kh,KhachHang.ten,SanPham.ma_sp,SanPham.ten_sp,SanPham.hang_sx,SanPham.mat_hang,hdx.ngay_lp,hdx.sl,hdx.dg,(hdx.sl * hdx.dg) FROM hdx LEFT JOIN KhachHang ON hdx.ma_kh = KhachHang.ma_kh LEFT JOIN SanPham ON hdx.ma_sp = SanPham.ma_sp LEFT JOIN NhanVien ON hdx.ma_nv = NhanVien.ma_nv where KhachHang.ten like'%"+txt_TKtenKH.Text.Trim()+"%'";
                dgv_hdx.DataSource = Function.GetDataTable(sql);
                tong();
            }
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenKH.Clear();
        }
    }
}
