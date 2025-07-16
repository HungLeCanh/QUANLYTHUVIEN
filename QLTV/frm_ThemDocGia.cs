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
            InitializeComponent();
            db = new Database();
            LoadChart_DocGiaMoiTheoThang();
        }

        public void LoadChart_DocGiaMoiTheoThang()
        {
            int year = DateTime.Now.Year;

            string sql = $@"
        SELECT 
            MONTH(ngay_dang_ky) AS Thang,
            COUNT(*) AS SoLuong
        FROM doc_gia
        WHERE YEAR(ngay_dang_ky) = {year}
        GROUP BY MONTH(ngay_dang_ky)
        ORDER BY Thang";

            DataTable dt = db.ExecuteQuery(sql);

            // Xóa dữ liệu cũ nếu có
            chart_DocGiaMoiTheoThang.Series["Số Độc Giả Mới"].Points.Clear();

            // Thêm dữ liệu mới
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                chart_DocGiaMoiTheoThang.Series["Số Độc Giả Mới"].Points.AddXY("Tháng " + thang, soLuong);
            }

            // Định dạng biểu đồ
            chart_DocGiaMoiTheoThang.ChartAreas[0].AxisX.Title = "Tháng";
            chart_DocGiaMoiTheoThang.ChartAreas[0].AxisY.Title = "Số Độc Giả Mới";
            chart_DocGiaMoiTheoThang.ChartAreas[0].AxisX.Interval = 1;
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string tenDocGia = txt_TenDocGia.Text.Trim();
            string soDienThoai = txt_SoDienThoai.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();
            string email = txt_Email.Text.Trim();
            string sql = $"INSERT INTO doc_gia (so_dien_thoai, ho_ten, email, dia_chi) VALUES ('{soDienThoai}', N'{tenDocGia}', '{email}', N'{diaChi}')";
            
            try
            {
                // Kiểm tra tính hợp lệ của số điện thoại và email
                DocGia docGia = new DocGia(soDienThoai, tenDocGia, email, diaChi);
                string checkKeyValue = $"select top 1 * from doc_gia where so_dien_thoai = '{soDienThoai}'";
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
                DataTable result = db.ExecuteQuery(checkKeyValue);

                if (result.Rows.Count > 0)
                {
                    MessageBox.Show("Độc giả với số điện thoại này đã tồn tại.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Controls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Form_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
