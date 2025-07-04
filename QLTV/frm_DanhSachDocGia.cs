using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_DanhSachDocGia : Form
    {
        Database db;
        public frm_DanhSachDocGia()
        {
            InitializeComponent();
            this.db = new Database();
            LoadData();
        }

        public void LoadData()
        {
            // Sử dụng đúng tên bảng trong CSDL
            string sql = "SELECT * FROM doc_gia";
            DataTable dt = db.ExecuteQuery(sql);

            // Tắt tự động tạo cột
            dgv_danhSachDocGia.AutoGenerateColumns = false;

            // Liên kết các cột với các trường trong CSDL
            col_SDT.DataPropertyName = "so_dien_thoai";
            col_hoTen.DataPropertyName = "ho_ten";
            col_email.DataPropertyName = "email";
            col_diaChi.DataPropertyName = "dia_chi";
            col_ngayDangKy.DataPropertyName = "ngay_dang_ky";

            // Gán DataSource sau khi đã cấu hình DataPropertyName
            dgv_danhSachDocGia.DataSource = dt;

            // Cấu hình để DataGridView tự động co giãn
            dgv_danhSachDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_danhSachDocGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cho phép nội dung ô văn bản tự động xuống dòng
            dgv_danhSachDocGia.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Đối với một số cột cụ thể, bạn có thể điều chỉnh riêng
            // Ví dụ:
            col_diaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgv_danhSachDocGia.CurrentRow == null || dgv_danhSachDocGia.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một độc giả để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dữ liệu từ dòng đang chọn
                string sdt = dgv_danhSachDocGia.CurrentRow.Cells["col_SDT"].Value?.ToString();
                string hoTen = dgv_danhSachDocGia.CurrentRow.Cells["col_hoTen"].Value?.ToString();
                string email = dgv_danhSachDocGia.CurrentRow.Cells["col_email"].Value?.ToString();
                string diaChi = dgv_danhSachDocGia.CurrentRow.Cells["col_diaChi"].Value?.ToString();

                // Xử lý ngày đăng ký (đảm bảo định dạng đúng cho MySQL)
                object ngayDangKyObj = dgv_danhSachDocGia.CurrentRow.Cells["col_ngayDangKy"].Value;
                string ngayDangKy = ngayDangKyObj != null ?
                    Convert.ToDateTime(ngayDangKyObj).ToString("yyyy-MM-dd") :
                    DateTime.Now.ToString("yyyy-MM-dd");

                // Tạo câu lệnh SQL UPDATE
                string sql = $@"UPDATE doc_gia 
                       SET ho_ten = N'{hoTen}', 
                           email = '{email}', 
                           dia_chi = N'{diaChi}'
                       WHERE so_dien_thoai = '{sdt}'";

                // Thực thi câu lệnh
                int result = db.ExecuteNonQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Tải lại dữ liệu
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgv_danhSachDocGia.CurrentRow == null || dgv_danhSachDocGia.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Lấy số điện thoại của độc giả đang chọn
                string sdt = dgv_danhSachDocGia.CurrentRow.Cells["col_SDT"].Value?.ToString();
                // Xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa độc giả với số điện thoại {sdt}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo câu lệnh SQL DELETE
                    string sql = $"DELETE FROM doc_gia WHERE so_dien_thoai = '{sdt}'";
                    // Thực thi câu lệnh
                    int result = db.ExecuteNonQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Tải lại dữ liệu
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_danhSachDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void panel_Controls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
