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
    public partial class frm_DanhSachPhieuMuon : Form
    {
        Database db;
        public frm_DanhSachPhieuMuon()
        {
            InitializeComponent();
            db = new Database();
        }

        private void TimKiemPhieuMuon(string sdt)
        {
            string sql = $"Select * from phieu_muon where so_dien_thoai_doc_gia = '{sdt}'";
            DataTable dt = db.ExecuteQuery(sql);

            dgv_PhieuMuon.AutoGenerateColumns = false;
            // gan gia tri cho cac cot
            col_MaPhieuMuon.DataPropertyName = "ma_phieu_muon";
            col_SoDienThoaiDocGia.DataPropertyName = "so_dien_thoai_doc_gia";
            col_NgayMuon.DataPropertyName = "ngay_muon";
            col_NgayTraDuKien.DataPropertyName = "ngay_tra_du_kien";
            col_NgayTraThucTe.DataPropertyName = "ngay_tra_thuc_te";
            col_TrangThaiPhieu.DataPropertyName = "trang_thai";
            // Gán DataSource sau khi đã cấu hình DataPropertyName
            dgv_PhieuMuon.DataSource = dt;

            // Cấu hình để DataGridView tự động co giãn
            dgv_PhieuMuon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cho phép nội dung ô văn bản tự động xuống dòng
            dgv_PhieuMuon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void LoadPhieuMuon()
        {
            string sql = "Select * from phieu_muon";
            DataTable dt = db.ExecuteQuery(sql);

            dgv_PhieuMuon.AutoGenerateColumns = false;
            // gan gia tri cho cac cot
            col_MaPhieuMuon.DataPropertyName = "ma_phieu_muon";
            col_SoDienThoaiDocGia.DataPropertyName = "so_dien_thoai_doc_gia";
            col_NgayMuon.DataPropertyName = "ngay_muon";
            col_NgayTraDuKien.DataPropertyName = "ngay_tra_du_kien";
            col_NgayTraThucTe.DataPropertyName = "ngay_tra_thuc_te";
            col_TrangThaiPhieu.DataPropertyName = "trang_thai";
            // Gán DataSource sau khi đã cấu hình DataPropertyName
            dgv_PhieuMuon.DataSource = dt;

            // Cấu hình để DataGridView tự động co giãn
            dgv_PhieuMuon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Cho phép nội dung ô văn bản tự động xuống dòng
            dgv_PhieuMuon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void frm_DanhSachPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon();
        }

        private void dgv_PhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Bỏ qua nếu click vào tiêu đề cột

            string maPhieuMuon = dgv_PhieuMuon.CurrentRow.Cells["col_MaPhieuMuon"].Value.ToString();
            txt_SoDienThoai.Text = dgv_PhieuMuon.CurrentRow.Cells["col_SoDienThoaiDocGia"].Value.ToString();

            // Ngày mượn và ngày trả dự kiến: luôn có
            DateTime ngayMuon = Convert.ToDateTime(dgv_PhieuMuon.CurrentRow.Cells["col_NgayMuon"].Value);
            DateTime ngayTraDuKien = Convert.ToDateTime(dgv_PhieuMuon.CurrentRow.Cells["col_NgayTraDuKien"].Value);

            txt_NgayMuon.Text = ngayMuon.ToString("dd-MM-yyyy");
            txt_NgayTraDuKien.Text = ngayTraDuKien.ToString("dd-MM-yyyy");

            // Ngày trả thực tế: có thể null
            object ngayTraThucTeObj = dgv_PhieuMuon.CurrentRow.Cells["col_NgayTraThucTe"].Value;
            DateTime? ngayTraThucTe = null;
            if (ngayTraThucTeObj != DBNull.Value && !string.IsNullOrWhiteSpace(ngayTraThucTeObj.ToString()))
            {
                ngayTraThucTe = Convert.ToDateTime(ngayTraThucTeObj);
                txt_NgayTraThucTe.Text = ngayTraThucTe.Value.ToString("dd-MM-yyyy");
            }
            else
            {
                txt_NgayTraThucTe.Text = "";
            }

            // Gán trạng thái cho ComboBox
            string trangThai = dgv_PhieuMuon.CurrentRow.Cells["col_TrangThaiPhieu"].Value.ToString();
            if (cbo_TrangThai.Items.Contains(trangThai))
            {
                cbo_TrangThai.SelectedItem = trangThai;
            }
            else
            {
                cbo_TrangThai.SelectedIndex = -1; // Không khớp, không chọn gì
            }

            // Tính số ngày mượn
            int soNgayMuon;
            if (ngayTraThucTe.HasValue)
            {
                soNgayMuon = (ngayTraThucTe.Value - ngayMuon).Days;
            }
            else
            {
                soNgayMuon = (ngayTraDuKien - ngayMuon).Days;
            }

            if (soNgayMuon <= 0) soNgayMuon = 1;

            // Truy vấn chi tiết phiếu mượn
            string sql = $@"
                        SELECT 
                            s.ma_sach, 
                            s.ten_sach, 
                            s.tac_gia, 
                            s.don_gia_muon, 
                            s.trang_thai, 
                            ctpm.don_gia_muon AS don_gia_muon_thoi_diem_muon, 
                            (ctpm.don_gia_muon * {soNgayMuon}) AS thanh_tien, 
                            ctpm.trang_thai AS trang_thai_muon
                        FROM chi_tiet_phieu_muon ctpm
                        JOIN sach s ON ctpm.ma_sach = s.ma_sach
                        WHERE ctpm.ma_phieu_muon = '{maPhieuMuon}'";

            DataTable dt = db.ExecuteQuery(sql);

            // Gán dữ liệu vào dgv chi tiết
            col_MaSach.DataPropertyName = "ma_sach";
            col_TenSach.DataPropertyName = "ten_sach";
            col_TacGia.DataPropertyName = "tac_gia";
            col_DonGiaMuon.DataPropertyName = "don_gia_muon_thoi_diem_muon";
            col_TrangThaiSach.DataPropertyName = "trang_thai";
            col_ThanhTien.DataPropertyName = "thanh_tien";

            dgv_ChiTietPhieuMuon.DataSource = dt;
            dgv_ChiTietPhieuMuon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_ChiTietPhieuMuon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadPhieuMuon();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại cần tìm.");
                return;
            }
            string sdt = txt_TimKiem.Text.Trim();
            TimKiemPhieuMuon(sdt);
        }
    }
}
