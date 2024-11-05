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
    public partial class LuongNhanVien : Form
    {
        private string sql;
        DataTable dt;
        public LuongNhanVien()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            sql = "select NhanVien.ma_nv,NhanVien.ten,Luong.so_gio,Luong.luong1h,NhanVien.ngay_nViec,Luong.ngay_nLuong from Luong inner join NhanVien on Luong.ma_nv=NhanVien.ma_nv";
            dt = Function.GetDataTable(sql);
            dgv_luong.DataSource =dt; 
        }
        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            dtp_ngayNV.Enabled = false;
            loaddata();
            dgv_luong.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_luong.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_luong.Columns[2].HeaderText = "Số Giờ Làm";
            dgv_luong.Columns[3].HeaderText = "Lương 1 Giờ";
            dgv_luong.Columns[4].HeaderText = "Ngày Nhận Việc";
            dgv_luong.Columns[5].HeaderText = "Ngày Nhận Lương";
            dgv_luong.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgv_luong.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void dgv_luong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_luong.CurrentRow != null)
            {
                txt_mnv.Text = dgv_luong.CurrentRow.Cells[0].Value.ToString();
                txt_tnv.Text = dgv_luong.CurrentRow.Cells[1].Value.ToString();
                nup_sgl.Text = dgv_luong.CurrentRow.Cells[2].Value.ToString();
                txt_luong.Text = dgv_luong.CurrentRow.Cells[3].Value.ToString();
                dtp_ngayNV.Text = dgv_luong.CurrentRow.Cells[4].Value.ToString();
                dtp_ngayNL.Text = dgv_luong.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void txt_TKtenKH_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TKtenNV.Clear();
        }
        private void cleartexbox()
        {
            nup_sgl.Text = "0";
            txt_luong.Text="0";
            nup_sgl.Focus();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_TKtenNV.Text == "")
            {
                sql = "select NhanVien.ma_nv,NhanVien.ten,Luong.so_gio,Luong.luong1h,NhanVien.ngay_nViec,Luong.ngay_nLuong from Luong inner join NhanVien on Luong.ma_nv=NhanVien.ma_nv";
                dgv_luong.DataSource = Function.GetDataTable(sql);
            }
            else
            {
                sql = "select NhanVien.ma_nv,NhanVien.ten,Luong.so_gio,Luong.luong1h,NhanVien.ngay_nViec,Luong.ngay_nLuong from Luong inner join NhanVien on Luong.ma_nv=NhanVien.ma_nv where NhanVien.ten like'%"+txt_TKtenNV.Text+"%'";
                dgv_luong.DataSource = Function.GetDataTable(sql);
            }
        }

        private void bt_lmoi_Click(object sender, EventArgs e)
        {
            cleartexbox();
        }

        private void bt_sgl_Click(object sender, EventArgs e)
        {
            if (bt_sgl.Text == "Cập nhật số giờ làm")
            {
                bt_sgl.Text = "Hủy";
                bt_sua.Text = "Lưu";
                btn_timkiem.Enabled = false;
                bt_lmoi.Enabled = false;
                bt_xoa.Enabled = false;
                btn_Excel.Enabled = false;
                txt_TKtenNV.Enabled = false;

            }
            else if (bt_sgl.Text == "Lưu")
            {
                if((int.TryParse(txt_luong.Text, out _)))
                {
                    sql = "update Luong set luong1h='"+txt_luong.Text+"',ngay_nLuong='"+dtp_ngayNL.Value.ToString("yyyy-MM-dd")+"' where ma_nv='"+txt_mnv.Text+"'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK);
                }             
                
                
            }
            else
            {
                bt_sgl.Text = "Cập nhật số giờ làm";
                bt_sua.Text = "Cập nhật lương";
                btn_timkiem.Enabled = true;
                bt_lmoi.Enabled = true;
                bt_xoa.Enabled = true;
                btn_Excel.Enabled = true;
                txt_TKtenNV.Enabled = true;
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (bt_sua.Text == "Cập nhật lương")
            {
                bt_sua.Text = "Hủy";
                bt_sgl.Text = "Lưu";
                btn_timkiem.Enabled = false;
                bt_lmoi.Enabled = false;
                bt_xoa.Enabled = false;
                btn_Excel.Enabled = false;
                txt_TKtenNV.Enabled = false;

            }
            else if (bt_sua.Text == "Lưu")
            {
                if ((int.TryParse(nup_sgl.Text, out _)))
                {
                    sql = "update Luong set so_gio='" + nup_sgl.Text + "',ngay_nLuong='" + dtp_ngayNL.Value.ToString("yyyy-MM-dd") + "' where ma_nv='" + txt_mnv.Text + "'";

                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                bt_sgl.Text = "Cập nhật số giờ làm";
                bt_sua.Text = "Cập nhật lương";
                btn_timkiem.Enabled = true;
                bt_lmoi.Enabled = true;
                bt_xoa.Enabled = true;
                btn_Excel.Enabled = true;
                txt_TKtenNV.Enabled = true;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_mnv.Text) || !string.IsNullOrEmpty(txt_tnv.Text) || !string.IsNullOrEmpty(nup_sgl.Text))
            {
                DialogResult kq = MessageBox.Show("Ban that su muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "delete Luong where ma_nv='" + txt_mnv.Text + "'";
                    Function.ExecuteNonQuery(sql);
                    loaddata();
                    cleartexbox();
                }
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgv_luong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_luong.SelectedRows[0]; // Lấy dòng đầu tiên nếu có

                // Kiểm tra xem dòng đã được chọn chưa
                if (selectedRow != null)
                {
                    // Lấy mã nhân viên từ dòng được chọn
                    string maNhanVien = selectedRow.Cells["ma_nv"].Value.ToString();

                    // Kiểm tra giá trị của so_gio
                    int soGio = Convert.ToInt32(selectedRow.Cells[2].Value); // Thay đổi index của cột tại đây
                    if (soGio == 0)
                    {
                        MessageBox.Show("Nhân viên không đủ điều kiện nhận lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Tạo DataTable mới và thêm các dòng được chọn vào
                        DataTable selectedDataTable = dt.Clone();
                        foreach (DataGridViewRow row in dgv_luong.SelectedRows)
                        {
                            DataRowView dataRowView = row.DataBoundItem as DataRowView;
                            if (dataRowView != null)
                            {
                                selectedDataTable.ImportRow(dataRowView.Row);
                            }
                        }

                        // Gọi hàm ExportFile với DataTable mới chứa các dòng được chọn
                        ExportFile(selectedDataTable, "Thanh toan", "Trả lương");

                        // Cập nhật số giờ về 0 trong cơ sở dữ liệu
                        sql = $"update Luong set so_gio = '0' where ma_nv = '{maNhanVien}'";
                        Function.ExecuteNonQuery(sql);

                        // Tải lại dữ liệu vào DataGridView
                        loaddata();

                        MessageBox.Show("Xuất file Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xuất file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            // Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            head.Interior.Color = ColorTranslator.ToOle(Color.Red);

            // Tạo tiêu đề cột 
            string[] columnNames = { "Mã nhân viên", "Tên nhân viên", "Số giờ làm", "Lương một giờ", "Ngày Nhận Việc", "Ngày Nhận Lương", "Thành tiền" };
            double[] columnWidths = { 20.0, 18.0, 18.0, 15.5, 20.5, 20.5, 18.5 };

            for (int i = 0; i < columnNames.Length; i++)
            {
                Microsoft.Office.Interop.Excel.Range cl = oSheet.get_Range(((char)('A' + i)).ToString() + "3");
                cl.Value2 = columnNames[i];
                cl.ColumnWidth = columnWidths[i];
            }

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable
            object[,] a = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    a[i, j] = dataRow[j];
                }
            }

            // Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            range.Value2 = a;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            oSheet.get_Range("F:F").NumberFormat = "DD-MM-YYYY";
            oSheet.get_Range("E:E").NumberFormat = "DD-MM-YYYY";
            oSheet.get_Range("D:D").NumberFormat = "#,##0";
            oSheet.get_Range("G:G").NumberFormat = "#,##0";

            // Tính giá trị "Thành Tiền" và tổng hợp
            long totalSum = 0;
            for (int i = rowStart; i <= rowEnd; i++)
            {
                Microsoft.Office.Interop.Excel.Range soGioCell = oSheet.Cells[i, 3];
                Microsoft.Office.Interop.Excel.Range luong1hCell = oSheet.Cells[i, 4];
                Microsoft.Office.Interop.Excel.Range ngayNhanViecCell = oSheet.Cells[i, 5];
                Microsoft.Office.Interop.Excel.Range ngayNhanLuongCell = oSheet.Cells[i, 6];
                Microsoft.Office.Interop.Excel.Range thanhTienCell = oSheet.Cells[i, 7];

                if (soGioCell.Value != null && luong1hCell.Value != null && ngayNhanViecCell.Value != null && ngayNhanLuongCell.Value != null)
                {
                    int soGio = Convert.ToInt32(soGioCell.Value);
                    int luong1h = Convert.ToInt32(luong1hCell.Value);
                    DateTime ngayNhanViec = Convert.ToDateTime(ngayNhanViecCell.Value);
                    DateTime ngayNhanLuong = Convert.ToDateTime(ngayNhanLuongCell.Value);
                    int soNgayLam = (ngayNhanLuong - ngayNhanViec).Days;

                    long thanhTien = soGio * luong1h;
                    if (soNgayLam > 30)
                    {
                        thanhTien += (long)(0.25 * thanhTien);
                    }

                    thanhTienCell.Value2 = thanhTien;
                    totalSum += thanhTien;
                }
            }

            // Tạo ô cho Tổng Số Tiền dưới cột "Thành Tiền"
            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.Cells[rowEnd + 1, 6]; // Cột trước cột "Thành Tiền"
            cl14.Value2 = "Tổng Số Tiền:";
            cl14.ColumnWidth = 17;
            cl14.Font.Bold = true;
            cl14.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo ô cho giá trị tổng của cột "Thành Tiền"
            Microsoft.Office.Interop.Excel.Range cl15 = oSheet.Cells[rowEnd + 1, 7]; // Cột "Thành Tiền"
            cl15.Font.Bold = true;
            cl15.Value2 = totalSum;
            cl15.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            cl15.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Giải phóng các đối tượng COM
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oSheets);
            Marshal.ReleaseComObject(oBook);
            Marshal.ReleaseComObject(oBooks);
            Marshal.ReleaseComObject(oExcel);
        }




    }
}
