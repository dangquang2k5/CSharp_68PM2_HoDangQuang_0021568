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

        int currentPage = 1;
        int pageSize = 10;   // Bạn có thể chỉnh số dòng hiển thị trên 1 trang ở đây
        int totalPages = 0;

        public uc_qllh()
        {
            InitializeComponent();
        }

        private void uc_qllh_Load(object sender, EventArgs e)
        {
            // Tắt tự động tạo cột
            dgv_qllh.AutoGenerateColumns = false;

            // Khóa cứng ô Mã ID vì trong SQL nó là số tự động tăng (IDENTITY)
            txt_maID_qllh.Enabled = false;

            loadData();
        }
        public void loadData() //tạo hàm loadData để load lại dữ liệu sau khi thêm lớp học
        {
            //Lấy từ khóa tìm kiếm (nếu có)
            string tuKhoa = textBox1.Text.Trim().ToLower();

            // Khởi tạo truy vấn: Lấy toàn bộ danh sách lớp học
            var query = db.tbl_lophocs.AsQueryable();

            // Lọc theo từ khóa (Tìm theo Mã lớp HOẶC Tên lớp)
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(l => l.malop.ToLower().Contains(tuKhoa) || l.tenlop.ToLower().Contains(tuKhoa));
            }

            //Tính toán tổng số trang
            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            // Chặn lỗi: Nếu current page vượt quá giới hạn thì ép về chuẩn
            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages && totalPages > 0) currentPage = totalPages;

            // Cập nhật số trang lên Label lbl_sotrang_qllh
            if (totalPages == 0)
            {
                lbl_sotrang_qllh.Text = "Trang 0 / 0";
            }
            else
            {
                lbl_sotrang_qllh.Text = $"Trang {currentPage} / {totalPages}";
            }

            //  PHÂN TRANG BẰNG SKIP VÀ TAKE
            var pagedData = query.Skip((currentPage - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToList();

            // Đổ dữ liệu lên bảng
            dgv_qllh.DataSource = pagedData;

        }


        private void btn_add_qllh_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txt_malop_qllh.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_malop_qllh.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt__tenlop_qllh.Text))
            {
                MessageBox.Show("Tên lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt__tenlop_qllh.Focus();
                return;
            }

            // Kiểm tra trùng Mã Lớp
            string maLopMoi = txt_malop_qllh.Text.Trim();
            var kiemTra = db.tbl_lophocs.SingleOrDefault(l => l.malop == maLopMoi);
            if (kiemTra != null)
            {
                MessageBox.Show("Mã lớp này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tiến hành thêm (BỎ QUA ID VÌ NÓ TỰ TĂNG)
            tbl_lophoc lh = new tbl_lophoc();
            lh.malop = maLopMoi;
            lh.tenlop = txt__tenlop_qllh.Text.Trim();
            lh.ghichu = txt_ghichu_qllh.Text.Trim();

            try
            {
                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp học thành công!");
                loadData();
                btn_refresh_qllh_Click(sender, e); // Gọi hàm Làm mới để xóa text
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btn_edit_qllh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt__tenlop_qllh.Text))
            {
                MessageBox.Show("Tên lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txt_malop_qllh.Text;
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ bảng để sửa!");
                return;
            }

            // Tìm lớp theo mã lớp
            tbl_lophoc lh = db.tbl_lophocs.SingleOrDefault(l => l.malop == maLop);

            if (lh != null)
            {
                lh.tenlop = txt__tenlop_qllh.Text.Trim();
                lh.ghichu = txt_ghichu_qllh.Text.Trim();

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin lớp học thành công!");
                    loadData();
                    txt_malop_qllh.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }

        private void btn_del_qllh_Click(object sender, EventArgs e)
        {
            string maLop = txt_malop_qllh.Text;
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ bảng để xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                tbl_lophoc lh = db.tbl_lophocs.SingleOrDefault(l => l.malop == maLop);
                if (lh != null)
                {
                    try
                    {
                        // XÓA CỨNG: Nếu lớp đang có sinh viên, SQL sẽ tự bắn lỗi văng xuống khối catch
                        db.tbl_lophocs.DeleteOnSubmit(lh);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa lớp học thành công!");
                        loadData();
                        btn_refresh_qllh_Click(sender, e);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên học trong lớp! Vui lòng xóa hoặc chuyển sinh viên sang lớp khác trước.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btn_refresh_qllh_Click(object sender, EventArgs e)
        {
            txt_maID_qllh.Text = "";
            txt_malop_qllh.Text = "";
            txt__tenlop_qllh.Text = "";
            txt_ghichu_qllh.Text = "";

            // Mở khóa lại ô mã lớp để nhập mới (Ô mã ID vẫn khóa vĩnh viễn)
            txt_malop_qllh.Enabled = true;

            loadData();
        }

        private void dgv_qllh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_qllh.Rows[e.RowIndex];

                txt_maID_qllh.Text = row.Cells[0].Value?.ToString();
                txt_malop_qllh.Text = row.Cells[1].Value?.ToString();
                txt__tenlop_qllh.Text = row.Cells[2].Value?.ToString();
                txt_ghichu_qllh.Text = row.Cells[3].Value?.ToString();

                // Khóa mã lớp lại không cho sửa
                txt_malop_qllh.Enabled = false;
            }
        }

        private void btn_search_qllh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            loadData();
        }

        private void btn_quaylaitrangdau_qllh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            loadData();
        }

        private void btn_quaylaitrangtruoc_qllh_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadData();
            }
        }

        private void btn_chuyendentrangtiep_qllh_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadData();
            }
        }

        private void btn_chuyendentrangcuoi_qllh_Click(object sender, EventArgs e)
        {
            if (totalPages > 0)
            {
                currentPage = totalPages;
                loadData();
            }
        }
    }
}
