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
    public partial class frm_XuatHoaDon : Form
    {
        Database db;
        public frm_XuatHoaDon()
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
            string sql = "Select * from phieu_muon where trang_thai = 'dang_muon'";
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

        private void dgv_PhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maPhieuMuon = dgv_PhieuMuon.CurrentRow.Cells["col_MaPhieuMuon"].Value.ToString();
            txt_MaPhieuMuon.Text = maPhieuMuon;
            txt_SoDienThoai.Text = dgv_PhieuMuon.CurrentRow.Cells["col_SoDienThoaiDocGia"].Value.ToString();

            DateTime ngayMuon = Convert.ToDateTime(dgv_PhieuMuon.CurrentRow.Cells["col_NgayMuon"].Value);
            DateTime ngayTraDuKien = Convert.ToDateTime(dgv_PhieuMuon.CurrentRow.Cells["col_NgayTraDuKien"].Value);

            txt_NgayMuon.Text = ngayMuon.ToString("dd-MM-yyyy");
            txt_NgayTraDuKien.Text = ngayTraDuKien.ToString("dd-MM-yyyy");

            // Lấy ngày trả thực tế từ textbox
            DateTime? ngayTraThucTe = null;
            if (!string.IsNullOrWhiteSpace(txt_NgayTraThucTe.Text))
            {
                if (DateTime.TryParseExact(txt_NgayTraThucTe.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedNgayTra))
                {
                    ngayTraThucTe = parsedNgayTra;
                }
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
            s.trang_thai, 
            ctpm.don_gia_muon AS don_gia_muon_thoi_diem_muon, 
            (ctpm.don_gia_muon * {soNgayMuon}) AS thanh_tien 
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

            // Gán trạng thái
            string trangThai = dgv_PhieuMuon.CurrentRow.Cells["col_TrangThaiPhieu"].Value.ToString();
            if (cbo_TrangThai.Items.Contains(trangThai))
            {
                cbo_TrangThai.SelectedItem = trangThai;
            }
            else
            {
                cbo_TrangThai.SelectedIndex = -1;
            }

            // Tính tổng thành tiền
            decimal tongThanhTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (decimal.TryParse(row["thanh_tien"].ToString(), out decimal thanhTien))
                {
                    tongThanhTien += thanhTien;
                }
            }

            txt_ThanhTien.Text = tongThanhTien.ToString("N0"); // hiển thị có dấu phân cách hàng nghìn
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

        private void frm_XuatHoaDon_Load(object sender, EventArgs e)
        {
            LoadPhieuMuon();
        }

        private void TinhLaiThanhTien()
        {
            if (!TryParseDate(txt_NgayMuon.Text, out DateTime ngayMuon, "Ngày mượn"))
                return;

            if (!TryParseDate(txt_NgayTraThucTe.Text, out DateTime ngayTraThucTe, "Ngày trả thực tế"))
                return;

            int soNgayMuon = (ngayTraThucTe - ngayMuon).Days;
            if (soNgayMuon <= 0)
            {
                MessageBox.Show("Ngày trả thực tế phải sau ngày mượn!", "Lỗi tính ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongThanhTien = 0;

            foreach (DataGridViewRow row in dgv_ChiTietPhieuMuon.Rows)
            {
                if (row.IsNewRow) continue;

                object donGiaObj = row.Cells["col_DonGiaMuon"].Value;

                if (donGiaObj == null || !decimal.TryParse(donGiaObj.ToString(), out decimal donGia))
                {
                    MessageBox.Show("Có dòng bị thiếu hoặc sai đơn giá mượn.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal thanhTien = donGia * soNgayMuon;
                row.Cells["col_ThanhTien"].Value = thanhTien;

                tongThanhTien += thanhTien;
            }

            txt_ThanhTien.Text = tongThanhTien.ToString("N0");
        }

        private void btn_TinhLaiThanhTien_Click(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
        }


        private bool TryParseDate(string input, out DateTime date, string fieldName)
        {
            if (!DateTime.TryParseExact(input, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                MessageBox.Show($"Ngày '{fieldName}' không hợp lệ. Định dạng đúng là dd-MM-yyyy.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_HomNay_Click(object sender, EventArgs e)
        {
            txt_NgayTraThucTe.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
            string maPhieuMuon = txt_MaPhieuMuon.Text.Trim();

            if (!TryParseDate(txt_NgayMuon.Text, out DateTime ngayMuon, "Ngày mượn"))
                return;

            if (!TryParseDate(txt_NgayTraThucTe.Text, out DateTime ngayTraThucTe, "Ngày trả thực tế"))
                return;

            int soNgayMuon = (ngayTraThucTe - ngayMuon).Days;
            decimal thanhTien = decimal.Parse(txt_ThanhTien.Text);

            if (string.IsNullOrEmpty(maPhieuMuon))
            {
                MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable chiTietTable = GetDataTableFromGrid(dgv_ChiTietPhieuMuon);

            if (chiTietTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết để thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form hóa đơn
            frm_HoaDonThanhToan frm = new frm_HoaDonThanhToan(maPhieuMuon, chiTietTable, soNgayMuon, thanhTien);
            frm.ShowDialog();
        }


        private DataTable GetDataTableFromGrid(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name, typeof(string)); // hoặc tự xác định kiểu dữ liệu nếu muốn
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                var dr = dt.NewRow();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    dr[col.Name] = row.Cells[col.Name].Value?.ToString() ?? "";
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }

    }
}
