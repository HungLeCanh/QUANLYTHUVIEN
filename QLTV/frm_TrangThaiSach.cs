using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_TrangThaiSach : Form
    {
        Database db;
       
        
        public frm_TrangThaiSach()
        {
            InitializeComponent();
            db = new Database();
            this.dataGridView1.RowHeadersVisible = false;


            LoadDB();
        }


        // Hàm xử lý Resize
        

        public void LoadDB() {
            // Sử dụng đúng tên bảng trong CSDL
            string sql = "SELECT * FROM sach";
            DataTable dt = db.ExecuteQuery(sql);

            // Tắt tự động tạo cột
            dataGridView1.AutoGenerateColumns = false;


            // Liên kết các cột với các trường trong CSDL
            col_MaSach.DataPropertyName = "ma_sach";
            col_TenSach.DataPropertyName = "ten_sach";
            col_TheLoai.DataPropertyName = "the_loai";
            col_NhaXuatBan.DataPropertyName = "nha_xuat_ban";
            col_NamXuatBan.DataPropertyName = "nam_xuat_ban";   
            col_DonGia.DataPropertyName = "don_gia_muon";    
            col_TrangThai.DataPropertyName = "trang_thai";
            col_TenTacGia.DataPropertyName = "tac_gia";


            // Gán DataSource sau khi đã cấu hình DataPropertyName
            dataGridView1.DataSource = dt;

            // Cấu hình để DataGridView tự động co giãn
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cho phép nội dung ô văn bản tự động xuống dòng
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Đối với một số cột cụ thể, bạn có thể điều chỉnh riêng
            // Ví dụ:
           

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //lấy value của cột mã sách từ hàng đang được chọn
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells["col_MaSach"].Value?.ToString();
                // Kiểm tra nếu mã sách không rỗng
                if (!string.IsNullOrEmpty(maSach))
                {
                    //lấy thông tin từ trường dữ liệu
                    string tenSach = txt_TenSach.Text.Trim();
                    string tacGia = txt_TenTacGia.Text.Trim();
                    string theLoai = cbb_TheLoai.Text.Trim();
                    string nhaXuatBan = txt_NhaXuatBan.Text.Trim();
                    string namXuatBan = txt_NamXuatBan.Text.Trim();
                    decimal donGia = decimal.Parse(txt_DonGiaMuon.Text);
                    //viết câu lệnh sql update ở bảng sach

                    string sql = $@"update sach
                        SET ten_sach = N'{tenSach}',
                            tac_gia = N'{tacGia}', 
                            the_loai = N'{theLoai}',
                            nha_xuat_ban = N'{nhaXuatBan}',
                            nam_xuat_ban = N'{namXuatBan}',
                            don_gia_muon = N'{donGia}'
                        where ma_sach = '{maSach}'";
                    int res = db.ExecuteNonQuery(sql);
                   
                   //
                   if (res >0 )
                    {
                        MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDB();
                    }else
                    {
                        MessageBox.Show("Cập nhật thông tin sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sách để sửa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string trangThai = row.Cells["col_TrangThai"].Value?.ToString();

                if (trangThai == null) return;

                // Đổi màu dòng và text theo trạng thái
                switch (trangThai)
                {
                    case "co_san":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.Cells["col_TrangThai"].Value = "Có Sẵn";
                        break;
                    case "da_muon":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        row.Cells["col_TrangThai"].Value = "Đã Mượn";
                        break;
                    case "mat":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.Cells["col_TrangThai"].Value = "Mất";
                        break;
                    case "bao_tri":
                        // Nếu muốn xử lý riêng cho bảo trì có thể thêm tại đây
                        break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dữ liệu trong dòng đã chọn và set vào các ô nhập liệu
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               
                txt_TenSach.Text = row.Cells["col_TenSach"].Value?.ToString();
                cbb_TheLoai.Text = row.Cells["col_TheLoai"].Value?.ToString();
                txt_NhaXuatBan.Text = row.Cells["col_NhaXuatBan"].Value?.ToString();
                txt_NamXuatBan.Text = row.Cells["col_NamXuatBan"].Value?.ToString();
                txt_DonGiaMuon.Text = row.Cells["col_DonGia"].Value?.ToString();
                txt_TenTacGia.Text = row.Cells["col_TenTacGia"].Value?.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSach = selectedRow.Cells["col_MaSach"].Value?.ToString();

                try
                {
                    //thông báo một dialog
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sách đang được chọn", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) {
                        string sql = $"delete from sach where ma_sach = '{maSach}'";
                        int res = db.ExecuteNonQuery(sql);
                        if (res > 0)
                        {
                            MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDB();
                                
                        }
                        else
                        {
                            MessageBox.Show("Xóa sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
             

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                
            }else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }
    }

}
