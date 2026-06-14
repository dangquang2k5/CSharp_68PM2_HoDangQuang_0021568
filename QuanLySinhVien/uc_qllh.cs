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
    public partial class    uc_qllh : UserControl
    {
        databaseDataContext db = new databaseDataContext(); //thêm phần này 



        public uc_qllh()
        {
            InitializeComponent();
        }

        private void uc_qllh_Load(object sender, EventArgs e)
        {
            //code ở đây để load bảng dữ liệu
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList(); //lấy dữ liệu từ bảng lớp học

            // Tắt tự động tạo cột
            dgv_qllh.AutoGenerateColumns = false;

            dgv_qllh.DataSource = dSLH; // đây nữa
        }
        public void loadData() //tạo hàm loadData để load lại dữ liệu sau khi thêm lớp học
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList(); //lấy dữ liệu từ bảng lớp học
            dgv_qllh.DataSource = dSLH; // đây nữa

        }
    }
}
