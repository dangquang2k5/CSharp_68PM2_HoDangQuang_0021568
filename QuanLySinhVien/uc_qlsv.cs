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
        int currentPage = 1; // Trang hiện tại
        int pageSize = 10;   // Số dòng trên 1 trang 
        int totalPages = 0;  // Tổng số trang

        public uc_qlsv()
        {
            InitializeComponent();
        }

        private void uc_qlsv_Load(object sender, EventArgs e)
        {
            loadDSLH4CBB();


            // Tắt tự động tạo cột
            dgv_qlsv.AutoGenerateColumns = false;

 
            loadData(); //gọi hàm loadData để load dữ liệu lên bảng khi form được load lên

            // THÊM 2 DÒNG NÀY ĐỂ CHỌN CẢ DÒNG VÀ CHỈ ĐỌC (da thao tác trên giao diện rồi nên đoạn này k cần)
            // dgv_qlsv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgv_qlsv.ReadOnly = true;
        }


        public void loadData() //tạo hàm loadData để load lại dữ liệu sau khi thêm sinh viên
        {
            // Lấy từ khóa tìm kiếm (nếu có)
            string tuKhoa = textBox1.Text.Trim().ToLower();

            // Khởi tạo truy vấn: Lấy danh sách SV chưa bị xóa mềm
            var query = db.tbl_sinhviens.Where(s => s.isDeleted == false || s.isDeleted == null);

            // 3. Lọc theo từ khóa tìm kiếm (nếu ô text tìm kiếm không trống)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(s => s.id.ToLower().Contains(tuKhoa) || s.hoten.ToLower().Contains(tuKhoa));
            }

            // Tính toán tổng số trang
            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize); // Làm tròn lên (VD: 11 dòng / 10 = 1.1 -> 2 trang)

            // Chặn lỗi: Nếu current page vượt quá giới hạn thì ép về chuẩn
            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages && totalPages > 0) currentPage = totalPages;


            //hiển thị số trang trên label
            if (totalPages == 0)
            {
                lbl_sotrang_qlsv.Text = "Trang 0 / 0"; // Trường hợp không có dữ liệu
            }
            else
            {
                lbl_sotrang_qlsv.Text = $"Trang {currentPage} / {totalPages}";
            }

            // HÂN TRANG BẰNG SKIP VÀ TAKE
            var pagedData = query.Skip((currentPage - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToList();

            // đổ dữ liệu lên bảng
            dgv_qlsv.DataSource = pagedData;

        }
        private void btn_add_qlsv_Click(object sender, EventArgs e)
        {
            // KIỂM TRA DỮ LIỆU RỖNG 
            if (string.IsNullOrWhiteSpace(txt_mssv.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mssv.Focus(); // Đưa con trỏ chuột nhấp nháy lại ô nhập ID
                return; // Dừng hàm ngay lập tức
            }

            if (string.IsNullOrWhiteSpace(txt_hvt.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_hvt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cbb_gioitinh.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbb_gioitinh.Focus();
                return;
            }



            string maSVMoi = txt_mssv.Text;
            // KIỂM TRA TRÙNG MÃ SINH VIÊN
            tbl_sinhvien kiemTraSV = db.tbl_sinhviens.SingleOrDefault(s => s.id == maSVMoi);
            if (kiemTraSV != null)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại! Vui lòng nhập mã khác.");
                return; // Dừng hàm lại, không chạy code thêm nữa
            }


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

                //ĐOẠN NÀY VÀO ĐỂ LÀM TRẮNG CÁC Ô NHẬP LIỆU:
                txt_mssv.Text = "";
                txt_hvt.Text = "";
                cbb_gioitinh.SelectedIndex = -1;
                dtpicker_ngaysinh.Value = DateTime.Now;
                txt_mssv.Enabled = true; // Đảm bảo ô ID luôn mở để nhập tiếp

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

        private void dgv_qlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra để tránh lỗi khi click vào tiêu đề cột (RowIndex = -1)
            if (e.RowIndex >= 0)
            {
                // Lấy ra dòng đang được chọn
                //DataGridViewRow row = this.dgv_qlsv.Rows[e.RowIndex];
                var row = dgv_qlsv.Rows[e.RowIndex];

                // Đổ dữ liệu lên các Control tương ứng theo thứ tự cột
                txt_mssv.Text = row.Cells[0].Value?.ToString();
                txt_hvt.Text = row.Cells[1].Value?.ToString();
                cbb_gioitinh.Text = row.Cells[2].Value?.ToString();
                txt_mssv.Enabled = false; // Khóa ô Mã sinh viên để không cho sửa khi click vào bảng

                // Xử lý riêng cho DateTimePicker (Ngày sinh)
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() != "")
                {
                    dtpicker_ngaysinh.Value = Convert.ToDateTime(row.Cells[3].Value);
                }

                // Xử lý riêng cho Combobox Lớp 
                // Vì trong hàm loadDSLH4CBB bạn cài đặt ValueMember = "malop" nên ta gán SelectedValue
                if (row.Cells[4].Value != null)
                {
                    cbb_lop.SelectedValue = row.Cells[4].Value.ToString();
                }


            }
        }

        private void btn_edit_qlsv_Click(object sender, EventArgs e)
        {
            //Lấy mã sinh viên hiện tại từ ô TextBox (đang bị khóa)
            string maSV = txt_mssv.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ bảng trước khi sửa!");
                return;
            }

            //Tìm kiếm sinh viên đó trong cơ sở dữ liệu qua databaseDataContext (db)
            tbl_sinhvien sv = db.tbl_sinhviens.SingleOrDefault(s => s.id == maSV);

            //Nếu tìm thấy thì tiến hành cập nhật dữ liệu mới
            if (sv != null)
            {
                sv.hoten = txt_hvt.Text;
                sv.ngaysinh = dtpicker_ngaysinh.Value; // Lấy giá trị ngày từ DateTimePicker
                sv.gioitinh = cbb_gioitinh.Text;
                sv.malop = cbb_lop.SelectedValue.ToString(); // Lấy mã lớp từ ComboBox

                try
                {
                    //lưu mọi thay đổi xuống Database 
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!");

                    //Gọi lại hàm loadData() có sẵn để làm mới bảng DataGridView
                    loadData();

                    //mở khóa lại ô Mã SV để có thể nhập mới
                    txt_mssv.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã này trong hệ thống!");
            }

        }

        private void btn_refresh_qlsv_Click(object sender, EventArgs e)
        {
            txt_mssv.Text = "";
            txt_hvt.Text = "";
            cbb_gioitinh.SelectedIndex = -1; // Bỏ chọn giới tính
            dtpicker_ngaysinh.Value = DateTime.Now; // Reset ngày về hôm nay

            // THÊM DÒNG NÀY: Mở khóa lại ô mã sinh viên để nhập mới
            txt_mssv.Enabled = true;

            loadData(); // Load lại bảng phòng trường hợp dữ liệu có thay đổi

        }

        private void btn_del_qlsv_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ TextBox
            string maSV = txt_mssv.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ bảng để xóa!");
                return;
            }

            // Hiện hộp thoại hỏi xác nhận người dùng trước khi xóa
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Tìm sinh viên đó trong CSDL
                tbl_sinhvien sv = db.tbl_sinhviens.SingleOrDefault(s => s.id == maSV);

                if (sv != null)
                {
                    // XÓA MỀM: Không dùng DeleteOnSubmit, chỉ chuyển trạng thái thành true
                    sv.isDeleted = true;

                    try
                    {
                        // Lưu thay đổi xuống DB
                        db.SubmitChanges();
                        MessageBox.Show("Xóa sinh viên thành công!");

                        // Tải lại bảng dữ liệu (dòng vừa xóa sẽ tự biến mất vì đã bị lọc ở trên)
                        loadData();

                        // Xóa trắng các ô nhập liệu và mở khóa lại ô mã SV
                        txt_mssv.Text = "";
                        txt_hvt.Text = "";
                        cbb_gioitinh.SelectedIndex = -1;
                        dtpicker_ngaysinh.Value = DateTime.Now;
                        txt_mssv.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thực hiện xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên này để xóa!");
                }
            }

        }

        private void btn_search_qlsv_Click(object sender, EventArgs e)
        {
            // Khi bấm tìm kiếm mới, bắt buộc phải ép về trang 1 để xem từ đầu
            currentPage = 1;
            loadData();
        }

        private void btn_quaylaitrangdau_qlsv_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            loadData();
        }

        private void btn_chuyendentrangcuoi_qlsv_Click(object sender, EventArgs e)
        {
            if (totalPages > 0)
            {
                currentPage = totalPages;
                loadData();
            }
        }

        private void btn_quaylaitrangtruoc_qlsv_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadData();
            }
        }

        private void btn_chuyendentrangtiep_qlsv_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadData();
            }
        }




    }
}
