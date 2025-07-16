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
    public partial class frm_ThemSach : Form
    {
        Database db;

        public frm_ThemSach()
        {
            InitializeComponent();
            this.db = new Database();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //lấy thong tin từ các trường nhập liệu
            string tenSach = txt_TenSach.Text.Trim();
            string tacGia = txt_TenTacGia.Text.Trim();
            string theLoai = cbb_TheLoai.GetItemText(cbb_TheLoai.SelectedItem);
            string nhaXuatBan = txt_NhaXuatBan.Text.Trim();
            decimal donGiaMuon;
            string donGiaMuonInput = txt_DonGiaMuon.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(donGiaMuonInput) || !decimal.TryParse(donGiaMuonInput, out donGiaMuon) || donGiaMuon < 0)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Đơn giá mượn (không để trống và phải là số dương).");
                txt_DonGiaMuon.Focus();
                return;
            }
            int namXuatBan = int.Parse(txt_NamXuatBan.Text.Trim());
            string sql = $"INSERT INTO sach (ten_sach, tac_gia, the_loai, nha_xuat_ban, don_gia_muon, nam_xuat_ban) VALUES (N'{tenSach}', N'{tacGia}', N'{theLoai}', N'{nhaXuatBan}', {donGiaMuon}, {namXuatBan})";

            try
            {
                // Kiểm tra tính hợp lệ của các trường nhập liệu
                Sach sach = new Sach(tenSach, tacGia, nhaXuatBan, namXuatBan, theLoai, donGiaMuon);
                if (!sach.IsValid())
                {
                    MessageBox.Show("Thông tin sách không hợp lệ. Vui lòng kiểm tra lại.");
                    return;
                }
                // Thực hiện thêm sách vào cơ sở dữ liệu
                int rows = db.ExecuteNonQuery(sql);
                if (rows > 0)
                {
                    MessageBox.Show("Thêm sách thành công!");
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sách. Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách: {ex.Message}");
            }

        }

        //làm hàm xóa tất cả các trường nhập liệu
        private void ClearInputFields()
        {
            txt_TenSach.Clear();
            txt_TenTacGia.Clear();
            cbb_TheLoai.SelectedIndex = -1;
            cbb_TheLoai.Text = string.Empty;
            txt_NhaXuatBan.Clear();
            txt_DonGiaMuon.Clear();
            txt_NamXuatBan.Clear();
        }
        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void txt_DonGiaMuon_TextChanged(object sender, EventArgs e)
        {
            txt_DonGiaMuon.TextChanged -= txt_DonGiaMuon_TextChanged;

            string input = txt_DonGiaMuon.Text.Replace(",", "").Trim(); // Xóa dấu phẩy cũ

            if (long.TryParse(input, out long number))
            {
                // Lưu lại vị trí con trỏ trước khi thay đổi
                int selectionStart = txt_DonGiaMuon.SelectionStart;

                txt_DonGiaMuon.Text = number.ToString("N0"); // Format: 10000 -> 10,000

                // Đặt lại vị trí con trỏ phù hợp
                txt_DonGiaMuon.SelectionStart = txt_DonGiaMuon.Text.Length;
            }

            // Đăng ký lại sự kiện
            txt_DonGiaMuon.TextChanged += txt_DonGiaMuon_TextChanged;
        }
    }
}
