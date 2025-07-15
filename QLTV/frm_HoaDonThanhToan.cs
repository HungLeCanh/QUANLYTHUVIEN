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
    public partial class frm_HoaDonThanhToan : Form
    {
        Database db;
        string maPhieuMuon;
        DataTable chiTiet;
        int soNgayMuon;
        decimal thanhTien;
        public bool done = false;
        public frm_HoaDonThanhToan(string maPhieuMuon, DataTable chiTiet, int soNgayMuon, decimal thanhTien)
        {
            InitializeComponent();
            this.maPhieuMuon = maPhieuMuon;
            db = new Database();
            this.chiTiet = chiTiet;
            this.soNgayMuon = soNgayMuon;
            this.thanhTien = thanhTien;
        }

        private void frm_HoaDonThanhToan_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin mã phiếu
            lbl_MaPhieu.Text = $"Mã phiếu: {maPhieuMuon}";

            // Hiển thị số ngày mượn
            lbl_SoNgayMuon.Text = $"Số ngày mượn: {soNgayMuon}";

            // Hiển thị tiền thanh toán
            lbl_TienThanhToan.Text = $"Tiền thanh toán: {thanhTien:N0} đ";

            // Gán dữ liệu chi tiết vào DataGridView
            dgv_ChiTiet.AutoGenerateColumns = false; // rất quan trọng để dùng các cột đã thiết kế

            // Gán DataPropertyName tương ứng với tên cột trong DataTable
            col_MaSach.DataPropertyName = "col_MaSach";
            col_TenSach.DataPropertyName = "col_TenSach";
            col_DonGiaMuon.DataPropertyName = "col_DonGiaMuon";
            col_ThanhTien.DataPropertyName = "col_ThanhTien";

            // Gán nguồn dữ liệu
            dgv_ChiTiet.DataSource = chiTiet;

            // Tùy chỉnh hiển thị
            dgv_ChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ChiTiet.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_ChiTiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Định dạng tiền tệ cho các cột liên quan
            dgv_ChiTiet.Columns["col_DonGiaMuon"].DefaultCellStyle.Format = "N0";
            dgv_ChiTiet.Columns["col_ThanhTien"].DefaultCellStyle.Format = "N0";
        }


        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XacNhanThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuẩn bị dữ liệu
                string maPhieu = maPhieuMuon;
                decimal tongTien = thanhTien;
                string trangThai = "da_thanh_toan";
                string ngayThanhToan = DateTime.Now.ToString("yyyy-MM-dd");
                string ghiChu = txt_GhiChu?.Text?.Trim() ?? "";

                // Câu lệnh SQL UPDATE
                string sql = $@"
            UPDATE hoa_don
            SET 
                tong_thanh_toan = {tongTien.ToString(System.Globalization.CultureInfo.InvariantCulture)},
                trang_thai = N'{trangThai}',
                ngay_thanh_toan = '{ngayThanhToan}',
                ghi_chu = N'{ghiChu}'
            WHERE ma_phieu_muon = '{maPhieu}'
        ";

                // Thực thi
                int rows = db.ExecuteNonQuery(sql);

                if (rows > 0)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    done = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    done = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                done = false;
            }
        }

    }
}
