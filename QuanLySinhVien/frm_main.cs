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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        // Hàm này sẽ được gọi mỗi khi một menu item được click để reset màu nền của tất cả menu về mặc định
        private void ResetMauMenu()
        {
            // SystemColors.Control là màu nền xám nhạt mặc định của thanh Menu
            tstr_qlsv.BackColor = SystemColors.Control;
            tstr_qllh.BackColor = SystemColors.Control;
        }

        private void tstr_qlsv_Click(object sender, EventArgs e)
        {
            // Làm tương tự cho tab Lớp học
            ResetMauMenu();
            tstr_qlsv.BackColor = Color.LightSkyBlue;


            uc_qlsv uc_qlsv = new uc_qlsv();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uc_qlsv);
        }

        private void tstr_qllh_Click(object sender, EventArgs e)
        {
            // Làm tương tự cho tab Lớp học
            ResetMauMenu();
            tstr_qllh.BackColor = Color.LightSkyBlue;


            uc_qllh uc_qllh = new uc_qllh();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uc_qllh);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //khi load form chính thì sẽ tự động click vào menu quản lý sinh viên để hiển thị giao diện quản lý sinh viên ngay
            tstr_qlsv_Click(sender, e);
        }

        private void tstr_logout_Click(object sender, EventArgs e)
        {
            // 1. Hiện hộp thoại hỏi người dùng có chắc chắn muốn đăng xuất không
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                                              "Xác nhận đăng xuất",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            // 2. Nếu người dùng chọn Yes
            if (dr == DialogResult.Yes)
            {
                // Khởi động lại toàn bộ ứng dụng. 
                // Lệnh này sẽ xóa sạch bộ nhớ tạm và quay về file Program.cs để mở lại frm_login
                Application.Restart();
            }
        }
    }
}
