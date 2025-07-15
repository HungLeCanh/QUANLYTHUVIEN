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
    public partial class frm_DanhSachHoaDon : Form
    {
        Database db;
        public frm_DanhSachHoaDon()
        {
            InitializeComponent();
            db = new Database();
        }

        private void LoadHoaDon()
        {
            string sql = "Select * from hoa_don";
            DataTable dt = db.ExecuteQuery(sql);

            dgv_DanhSachHoaDon.AutoGenerateColumns = false;

            col_MaHoaDon.DataPropertyName = "ma_hoa_don";
            col_MaPhieuMuon.DataPropertyName = "ma_phieu_muon";
            col_NgayTaoHoaDon.DataPropertyName = "ngay_tao_hoa_don";
            col_NgayThanhToan.DataPropertyName = "ngay_thanh_toan";
            col_TongThanhToan.DataPropertyName = "tong_thanh_toan";
            col_TrangThai.DataPropertyName = "trang_thai";
            col_GhiChu.DataPropertyName = "ghi_chu";
            col_TongTien.DataPropertyName = "tong_tien";
            dgv_DanhSachHoaDon.DataSource = dt;
            // Cấu hình để DataGridView tự động co giãn
            dgv_DanhSachHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cho phép nội dung ô văn bản tự động xuống dòng
            dgv_DanhSachHoaDon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void frm_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void dgv_DanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachHoaDon.Rows[e.RowIndex];
                txt_MaHoaDon.Text = row.Cells["col_MaHoaDon"].Value?.ToString();
                txt_MaPhieuMuon.Text = row.Cells["col_MaPhieuMuon"].Value?.ToString();

                // Ngày tạo hóa đơn
                var ngayTaoValue = row.Cells["col_NgayTaoHoaDon"].Value;
                if (ngayTaoValue != null && DateTime.TryParse(ngayTaoValue.ToString(), out DateTime ngayTao))
                {
                    txt_NgayTaoHoaDon.Text = ngayTao.ToString("dd-MM-yyyy");
                }
                else
                {
                    txt_NgayTaoHoaDon.Text = string.Empty;
                }

                // Ngày thanh toán
                var ngayThanhToanValue = row.Cells["col_NgayThanhToan"].Value;
                if (ngayThanhToanValue != null && DateTime.TryParse(ngayThanhToanValue.ToString(), out DateTime ngayThanhToan))
                {
                    txt_NgayThanhToan.Text = ngayThanhToan.ToString("dd-MM-yyyy");
                }
                else
                {
                    txt_NgayThanhToan.Text = string.Empty;
                }

                txt_TongThanhToan.Text = row.Cells["col_TongThanhToan"].Value?.ToString();
                txt_GhiChu.Text = row.Cells["col_GhiChu"].Value?.ToString();
                txt_TongTien.Text = row.Cells["col_TongTien"].Value?.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn sửa ghi chú của hoá đơn này?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string sql = $"update hoa_don set ghi_chu = '{txt_GhiChu.Text}' where ma_hoa_don = '{txt_MaHoaDon.Text}'";
                int rows = db.ExecuteNonQuery(sql);
                if (rows > 0)
                {
                    MessageBox.Show("Sửa hoá đơn thành công");
                    LoadHoaDon();
                }
                else
                {
                    MessageBox.Show("Sửa hoá đơn thất bại");
                }
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = string.Empty;
            txt_MaPhieuMuon.Text = string.Empty;
            txt_NgayTaoHoaDon.Text = string.Empty;
            txt_NgayThanhToan.Text = string.Empty;
            txt_TongThanhToan.Text = string.Empty;
            txt_GhiChu.Text = string.Empty;
            txt_TongTien.Text = string.Empty;
        }
    }
}
