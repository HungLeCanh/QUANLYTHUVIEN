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
    public partial class frm_ThemDocGia : Form
    {
        Database db;
        public frm_ThemDocGia()
        {
            this.db = new Database();
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string tenDocGia = txt_TenDocGia.Text.Trim();
            string soDienThoai = txt_SoDienThoai.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();
            string email = txt_Email.Text.Trim();
            string sql = $"INSERT INTO doc_gia (so_dien_thoai, ho_ten, email, dia_chi) VALUES ('{soDienThoai}', '{tenDocGia}', '{email}', '{diaChi}')";
            try
            {
                // Kiểm tra tính hợp lệ của số điện thoại và email
                DocGia docGia = new DocGia(soDienThoai, tenDocGia, email, diaChi);
                if (!docGia.IsValidPhoneNumber())
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                    return;
                }
                if (!docGia.IsValidEmail())
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại.");
                    return;
                }
           


                // kiểm tra xem số điện thoại đã tồn tại chưa
                string checkSql = $"SELECT COUNT(*) FROM doc_gia WHERE so_dien_thoai = '{soDienThoai}'";
                int checkExistSDT  = Convert.ToInt32(db.ExecuteScalar(checkSql));
                
                if( checkExistSDT > 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.");
                    return;
                }

                // Thực hiện thêm độc giả vào cơ sở dữ liệu
                int rows = db.ExecuteNonQuery(sql);
                if (rows > 0)
                {
                    MessageBox.Show("Thêm độc giả thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể thêm độc giả. Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm độc giả: {ex.Message}");
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            // Xóa các trường nhập liệu
            txt_TenDocGia.Clear();
            txt_SoDienThoai.Clear();
            txt_DiaChi.Clear();
            txt_Email.Clear();
            // Đặt con trỏ về trường Số điện thoại
            txt_SoDienThoai.Focus();
        }


    }
}
