using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_danhsachsinhvien : Form
    {
        databaseDataContext db = new databaseDataContext();

        // Tạo một biến toàn cục để lưu mã lớp được truyền sang
        string maLopDuocChon = "";


        public frm_danhsachsinhvien()
        {
            InitializeComponent();
        }

        public frm_danhsachsinhvien(string maLop)
        {
            InitializeComponent();
            maLopDuocChon = maLop; // Lưu mã lớp được truyền vào biến toàn cục
        }

        private void frm_danhsachsinhvien_Load(object sender, EventArgs e)
        {
            // Cập nhật tiêu đề của Form cho chuyên nghiệp
            this.Text = "Danh sách sinh viên lớp: " + maLopDuocChon;

            // Dùng LINQ tìm các sinh viên thuộc mã lớp này (và chưa bị xóa)
            var dsSinhVien = db.tbl_sinhviens
                               .Where(s => s.malop == maLopDuocChon && (s.isDeleted == false || s.isDeleted == null))
                               .ToList();

            dgv_dssv_lop.AutoGenerateColumns = false;


            // Đổ dữ liệu lên bảng
            dgv_dssv_lop.DataSource = dsSinhVien;
        }
    }
}
