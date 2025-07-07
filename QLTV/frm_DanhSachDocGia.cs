using Mysqlx.Resultset;
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
        private void suaEventWhenCusorOuted()
        {
            try
            {     
                  string sdt = this.txt_SDT.Text.ToString();
                  string email = this.txt_Email.Text.ToString();
                  string hoTen = this.txt_HoTen.Text.ToString();
                  string diaChi = this.txt_DiaChi.Text.ToString();
                        // Tạo câu lệnh SQL UPDATE
                  string sql = $@"UPDATE doc_gia 
                       SET ho_ten = '{hoTen}', 
                           email = '{email}', 
                           dia_chi = '{diaChi}' 
                       WHERE so_dien_thoai = '{sdt}'";
                        int result = db.ExecuteNonQuery(sql);   
                if(result > 0)
                {
                    MessageBox.Show($"Sửa thành công thông tin độc giả");
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

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            // sửa một lúc nhiều row được
            suaEventWhenCusorOuted();
            LoadData();
        }

        private void dgv_danhSachDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chonThongTinDocGia();
        }

        private void chonThongTinDocGia()
        {
            DataGridViewRow dtRow  = this.dgv_danhSachDocGia.CurrentRow;
            if (dtRow != null)
            {
                this.txt_SDT.Text = dtRow.Cells["col_SDT"].Value.ToString();
                this.txt_Email.Text = dtRow.Cells["col_email"].Value.ToString();
                this.txt_HoTen.Text = dtRow.Cells["col_hoTen"].Value.ToString();
                this.txt_DiaChi.Text = dtRow.Cells["col_diaChi"].Value.ToString();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.txt_SDT.Clear();
            this.txt_Email.Clear();
            this.txt_HoTen.Clear();
            this.txt_DiaChi.Clear();
            if(this.txt_TimKiem.Text != "Số điện thoại")
            {
                LoadData();
                this.txt_TimKiem.Text = "Số điện thoại";
            }
            
        }
        // Placeholder text handling for search box
        private void txt_TimKiem_Enter(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "Số điện thoại")
            {
                txt_TimKiem.Text = "";
                txt_TimKiem.ForeColor = Color.Black;
            }
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                txt_TimKiem.Text = "Số điện thoại";
                txt_TimKiem.ForeColor = Color.Gray;
            }
        }

        private void txt_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemDocGia();
                e.SuppressKeyPress = true; // Prevent the beep sound
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiemDocGia();
        }

        private void TimKiemDocGia()
        {
            string searchText = txt_TimKiem.Text;

            // If the search box contains the placeholder text or is empty, load all data
            if (string.IsNullOrWhiteSpace(searchText) || searchText == "Số điện thoại" || searchText.Length < 10)
            {
                MessageBox.Show("Số điện thoại không phù hợp (không được để trống và không được bé hơn 10 chữ số)");
                LoadData();
                return;
            }

            // Search for the phone number
            string sql = $"SELECT * FROM doc_gia WHERE so_dien_thoai LIKE '%{searchText}%'";
            DataTable dt = db.ExecuteQuery(sql);
              if(dt != null)
             {
               // Update the DataGridView
                dgv_danhSachDocGia.DataSource = dt;
                chonThongTinDocGia();
              }

            // If no results found, show a message
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy độc giả với số điện thoại này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
