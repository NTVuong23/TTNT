using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
           
        }

        private void report_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "rpSach.rdlc";
            using (var db = new QLSachEntities())
            {
                var books = db.Sach
                    .Select(b => new
                    {
                        b.MaSach,
                        b.TenSach,
                        b.NamXB,
                        b.MaLoai
                    })
                    .OrderByDescending(b => b.NamXB)
                    .ToList();

                var categories = db.LoaiSach
                .Select(c => new
                {
                    c.MaLoai,
                    c.TenLoai
                })
                .ToList();

                // Xóa các nguồn dữ liệu cũ
                reportViewer1.LocalReport.DataSources.Clear();

                // Thêm nguồn dữ liệu cho reportViewer
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("thongke", books));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", categories));
                reportViewer1.RefreshReport();
            }
        }


    }
}
