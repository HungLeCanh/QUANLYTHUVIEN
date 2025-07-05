using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV
{
    public partial class frm_TaoPhieuMuon : Form
    {
        private Database db;
        private List<SachDaChon> danhSachSachDaChon;
        private decimal tongTien = 0;

        public frm_TaoPhieuMuon()
        {
            InitializeComponent();
            db = new Database();
            danhSachSachDaChon = new List<SachDaChon>();
        }

        private void frm_TaoPhieuMuon_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mượn mặc định là hôm nay
            dtp_NgayMuon.Value = DateTime.Now;

            // Thiết lập ngày trả dự kiến mặc định là 14 ngày sau
            dtp_NgayTraDuKien.Value = DateTime.Now.AddDays(14);

            // Load danh sách sách có thể mượn
            LoadDanhSachSach();

            // Thiết lập DataGridView
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Thiết lập cho DataGridView sách
            dgv_Sach.AutoGenerateColumns = false;
            dgv_Sach.ReadOnly = false;
            dgv_Sach.AllowUserToAddRows = false;
            dgv_Sach.AllowUserToDeleteRows = false;
            dgv_Sach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Thiết lập cho DataGridView sách đã chọn
            dgv_SachDaChon.AutoGenerateColumns = false;
            dgv_SachDaChon.ReadOnly = true;
            dgv_SachDaChon.AllowUserToAddRows = false;
            dgv_SachDaChon.AllowUserToDeleteRows = false;
            dgv_SachDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadDanhSachSach(string timKiem = "")
        {
            try
            {
                string query = @"SELECT ma_sach, ten_sach, tac_gia, nha_xuat_ban, 
                               nam_xuat_ban, the_loai, don_gia_muon, trang_thai 
                               FROM sach WHERE trang_thai = 'co_san'";

                if (!string.IsNullOrEmpty(timKiem))
                {
                    query += " AND (ten_sach LIKE N'%" + timKiem + "%' OR CAST(ma_sach AS NVARCHAR) LIKE '%" + timKiem + "%')";
                }

                query += " ORDER BY ten_sach";

                DataTable dt = db.ExecuteQuery(query);

                dgv_Sach.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dgv_Sach.Rows.Add();
                    dgv_Sach.Rows[rowIndex].Cells["col_Chon"].Value = false;
                    dgv_Sach.Rows[rowIndex].Cells["col_MaSach"].Value = row["ma_sach"];
                    dgv_Sach.Rows[rowIndex].Cells["col_TenSach"].Value = row["ten_sach"];
                    dgv_Sach.Rows[rowIndex].Cells["col_TacGia"].Value = row["tac_gia"];
                    dgv_Sach.Rows[rowIndex].Cells["col_NhaXuatBan"].Value = row["nha_xuat_ban"];
                    dgv_Sach.Rows[rowIndex].Cells["col_NamXuatBan"].Value = row["nam_xuat_ban"];
                    dgv_Sach.Rows[rowIndex].Cells["col_TheLoai"].Value = row["the_loai"];
                    dgv_Sach.Rows[rowIndex].Cells["col_DonGiaMuon"].Value = Convert.ToDecimal(row["don_gia_muon"]).ToString("N0");

                    // Sử dụng helper class để chuyển đổi trạng thái
                    TrangThaiSach trangThai = TrangThaiSachHelper.FromDbString(row["trang_thai"].ToString());
                    dgv_Sach.Rows[rowIndex].Cells["col_TrangThai"].Value = GetTrangThaiText(trangThai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTrangThaiText(TrangThaiSach trangThai)
        {
            // Sử dụng phương thức từ enum
            switch (trangThai)
            {
                case TrangThaiSach.CoSan:
                    return "Có sẵn";
                case TrangThaiSach.DaMuon:
                    return "Đã mượn";
                case TrangThaiSach.BaoTri:
                    return "Bảo trì";
                case TrangThaiSach.Mat:
                    return "Mất";
                default:
                    return "Không xác định";
            }
        }

        // Overload để tương thích với code cũ
        private string GetTrangThaiText(string trangThai)
        {
            return GetTrangThaiText(TrangThaiSachHelper.FromDbString(trangThai));
        }

        private void btn_TimDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDienThoai.Focus();
                return;
            }

            try
            {
                string query = "SELECT ho_ten, email FROM doc_gia WHERE so_dien_thoai = N'" + txt_SoDienThoai.Text.Trim() + "'";
                DataTable dt = db.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    txtHoTen.Text = dt.Rows[0]["ho_ten"].ToString();
                    txt_Email.Text = dt.Rows[0]["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả với số điện thoại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTen.Clear();
                    txt_Email.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachSach(txt_TimKiem.Text.Trim());
        }

        private void dgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Sach.Columns["col_Chon"].Index)
            {
                bool isChecked = Convert.ToBoolean(dgv_Sach.Rows[e.RowIndex].Cells["col_Chon"].Value);

                if (!isChecked)
                {
                    // Thêm sách vào danh sách đã chọn
                    ThemSachDaChon(e.RowIndex);
                }
                else
                {
                    // Xóa sách khỏi danh sách đã chọn
                    XoaSachDaChon(dgv_Sach.Rows[e.RowIndex].Cells["col_MaSach"].Value.ToString());
                }
            }
        }

        private void ThemSachDaChon(int rowIndex)
        {
            try
            {
                string maSach = dgv_Sach.Rows[rowIndex].Cells["col_MaSach"].Value.ToString();
                string tenSach = dgv_Sach.Rows[rowIndex].Cells["col_TenSach"].Value.ToString();
                decimal donGia = Convert.ToDecimal(dgv_Sach.Rows[rowIndex].Cells["col_DonGiaMuon"].Value.ToString().Replace(",", ""));

                // Kiểm tra xem sách đã được chọn chưa
                if (danhSachSachDaChon.Any(s => s.MaSach == maSach))
                {
                    MessageBox.Show("Sách này đã được chọn rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv_Sach.Rows[rowIndex].Cells["col_Chon"].Value = false;
                    return;
                }

                // Thêm vào danh sách
                SachDaChon sachMoi = new SachDaChon
                {
                    MaSach = maSach,
                    TenSach = tenSach,
                    DonGiaMuon = donGia,
                    ThanhTien = donGia // Có thể tính toán phức tạp hơn nếu cần
                };

                danhSachSachDaChon.Add(sachMoi);

                // Cập nhật DataGridView sách đã chọn
                CapNhatDanhSachSachDaChon();

                // Cập nhật tổng tiền
                CapNhatTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaSachDaChon(string maSach)
        {
            try
            {
                var sachCanXoa = danhSachSachDaChon.FirstOrDefault(s => s.MaSach == maSach);
                if (sachCanXoa != null)
                {
                    danhSachSachDaChon.Remove(sachCanXoa);
                    CapNhatDanhSachSachDaChon();
                    CapNhatTongTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatDanhSachSachDaChon()
        {
            dgv_SachDaChon.Rows.Clear();

            foreach (var sach in danhSachSachDaChon)
            {
                int rowIndex = dgv_SachDaChon.Rows.Add();
                dgv_SachDaChon.Rows[rowIndex].Cells["col_MaSachDaChon"].Value = sach.MaSach;
                dgv_SachDaChon.Rows[rowIndex].Cells["col_TenSachDaChon"].Value = sach.TenSach;
                dgv_SachDaChon.Rows[rowIndex].Cells["col_DonGiaMuonDaChon"].Value = sach.DonGiaMuon.ToString("N0");
                dgv_SachDaChon.Rows[rowIndex].Cells["col_ThanhTien"].Value = sach.ThanhTien.ToString("N0");
            }
        }

        private void CapNhatTongTien()
        {
            tongTien = danhSachSachDaChon.Sum(s => s.ThanhTien);
            txt_TongTien.Text = tongTien.ToString("N0");
        }

        private void dgv_SachDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_SachDaChon.Columns["col_Xoa"].Index)
            {
                string maSach = dgv_SachDaChon.Rows[e.RowIndex].Cells["col_MaSachDaChon"].Value.ToString();

                // Xóa khỏi danh sách sách đã chọn
                XoaSachDaChon(maSach);

                // Bỏ check trong DataGridView sách
                foreach (DataGridViewRow row in dgv_Sach.Rows)
                {
                    if (row.Cells["col_MaSach"].Value.ToString() == maSach)
                    {
                        row.Cells["col_Chon"].Value = false;
                        break;
                    }
                }
            }
        }

        private void btn_TaoPhieuMuon_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                TaoPhieuMuon();
            }
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrEmpty(txt_SoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDienThoai.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng tìm thông tin độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_TimDocGia.Focus();
                return false;
            }

            if (dtp_NgayTraDuKien.Value <= dtp_NgayMuon.Value)
            {
                MessageBox.Show("Ngày trả dự kiến phải sau ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_NgayTraDuKien.Focus();
                return false;
            }

            if (danhSachSachDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một cuốn sách để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void TaoPhieuMuon()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Tạo phiếu mượn
                    string maPhieuMuon = Guid.NewGuid().ToString();
                    string insertPhieuMuon = @"INSERT INTO phieu_muon (ma_phieu_muon, so_dien_thoai_doc_gia, ngay_muon, ngay_tra_du_kien, trang_thai) 
                                              VALUES (@maPhieuMuon, @soDienThoai, @ngayMuon, @ngayTraDuKien, 'dang_muon')";

                    SqlCommand cmdPhieuMuon = new SqlCommand(insertPhieuMuon, conn, transaction);
                    cmdPhieuMuon.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                    cmdPhieuMuon.Parameters.AddWithValue("@soDienThoai", txt_SoDienThoai.Text.Trim());
                    cmdPhieuMuon.Parameters.AddWithValue("@ngayMuon", dtp_NgayMuon.Value);
                    cmdPhieuMuon.Parameters.AddWithValue("@ngayTraDuKien", dtp_NgayTraDuKien.Value);
                    cmdPhieuMuon.ExecuteNonQuery();

                    // Tạo chi tiết phiếu mượn
                    foreach (var sach in danhSachSachDaChon)
                    {
                        string insertChiTiet = @"INSERT INTO chi_tiet_phieu_muon (ma_phieu_muon, ma_sach, don_gia_muon, thanh_tien, trang_thai) 
                                               VALUES (@maPhieuMuon, @maSach, @donGia, @thanhTien, 'dang_muon')";

                        SqlCommand cmdChiTiet = new SqlCommand(insertChiTiet, conn, transaction);
                        cmdChiTiet.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                        cmdChiTiet.Parameters.AddWithValue("@maSach", sach.MaSach);
                        cmdChiTiet.Parameters.AddWithValue("@donGia", sach.DonGiaMuon);
                        cmdChiTiet.Parameters.AddWithValue("@thanhTien", sach.ThanhTien);
                        cmdChiTiet.ExecuteNonQuery();
                    }

                    // Tạo hóa đơn
                    string insertHoaDon = @"INSERT INTO hoa_don (ma_phieu_muon, tong_tien, tong_thanh_toan, trang_thai, ngay_tao_hoa_don) 
                                          VALUES (@maPhieuMuon, @tongTien, @tongThanhToan, 'chua_thanh_toan', @ngayTao)";

                    SqlCommand cmdHoaDon = new SqlCommand(insertHoaDon, conn, transaction);
                    cmdHoaDon.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                    cmdHoaDon.Parameters.AddWithValue("@tongTien", tongTien);
                    cmdHoaDon.Parameters.AddWithValue("@tongThanhToan", tongTien);
                    cmdHoaDon.Parameters.AddWithValue("@ngayTao", DateTime.Now);
                    cmdHoaDon.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Tạo phiếu mượn thành công!\nMã phiếu mượn: " + maPhieuMuon, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới form
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi tạo phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txt_SoDienThoai.Clear();
            txtHoTen.Clear();
            txt_Email.Clear();
            dtp_NgayMuon.Value = DateTime.Now;
            dtp_NgayTraDuKien.Value = DateTime.Now.AddDays(14);
            danhSachSachDaChon.Clear();
            dgv_SachDaChon.Rows.Clear();
            tongTien = 0;
            txt_TongTien.Text = "0";

            // Bỏ check tất cả checkbox trong dgv_Sach
            foreach (DataGridViewRow row in dgv_Sach.Rows)
            {
                row.Cells["col_Chon"].Value = false;
            }

            // Xóa từ khóa tìm kiếm và load lại danh sách sách
            txt_TimKiem.Clear();
            LoadDanhSachSach();

            // Focus về textbox số điện thoại
            txt_SoDienThoai.Focus();
        }
    }

    // Class helper để lưu thông tin sách đã chọn
    public class SachDaChon
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal DonGiaMuon { get; set; }
        public decimal ThanhTien { get; set; }
    }
}