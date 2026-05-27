using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class uc_qlsv : UserControl
    {
        databaseDataContext db = new databaseDataContext(); //thêm phần này 

        public uc_qlsv()
        {
            InitializeComponent();
        }

        private void uc_qlsv_Load(object sender, EventArgs e)
        {
            loadDSLH4CBB();
            //code ở đây để load bảng dữ liệu
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList(); //lấy dữ liệu từ bảng sinh viên
            dgv_qlsv.DataSource = dSSV; // đây nữa
        }


        public void loadData() //tạo hàm loadData để load lại dữ liệu sau khi thêm sinh viên
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList(); //lấy dữ liệu từ bảng sinh viên
            dgv_qlsv.DataSource = dSSV; // đây nữa

        }
        private void btn_add_qlsv_Click(object sender, EventArgs e)
        {
            //code ở đây để thêm sinh viên

            tbl_sinhvien sv = new tbl_sinhvien(); //tạo đối tượng sinh viên
            sv.id = txt_mssv.Text; //gán mã sinh viên từ textbox
            sv.hoten = txt_hvt.Text; //gán họ tên từ textbox
            sv.ngaysinh = DateTime.Parse(dtpicker_ngaysinh.Text);
            sv.gioitinh = cbb_gioitinh.Text; //gán giới tính từ combobox
            sv.malop = cbb_lop.SelectedValue.ToString(); //lấy mã lớp học từ combobox

            try
            {
                db.tbl_sinhviens.InsertOnSubmit(sv); //insertOnSubmit để thêm vào bảng sinh viên
                db.SubmitChanges();
                MessageBox.Show("Thêm sinh viên thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }


        }

        //load dữ liệu cho commobox lớp học
        public void loadDSLH4CBB()
        {
            List<tbl_lophoc> dsLH = db.tbl_lophocs.ToList(); //lấy dữ liệu từ bảng lớp học
            cbb_lop.DataSource = dsLH; //đổ dữ liệu vào combobox lớp học
            cbb_lop.DisplayMember = "tenlop"; //hiển thị tên lớp học
            cbb_lop.ValueMember = "malop"; //giá trị là mã lớp học
        }
    }
}
