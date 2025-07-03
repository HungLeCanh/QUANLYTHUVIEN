using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    // Enum cho trạng thái hóa đơn
    public enum TrangThaiHoaDon
    {
        ChuaThanhToan,
        DaThanhToan
    }

    internal class HoaDon
    {
        private int maHoaDon { get; set; }
        private string maPhieuMuon { get; set; }
        private decimal tongTien { get; set; }
        private decimal tongThanhToan { get; set; }
        private TrangThaiHoaDon trangThai { get; set; }
        private DateTime ngayTaoHoaDon { get; set; }
        private DateTime? ngayThanhToan { get; set; }
        private string ghiChu { get; set; }

        public HoaDon()
        {
            trangThai = TrangThaiHoaDon.ChuaThanhToan;
            ngayTaoHoaDon = DateTime.Now;
            tongTien = 0;
            tongThanhToan = 0;
        }

        public HoaDon(string maPhieuMuon, decimal tongTien, string ghiChu = null)
        {
            this.maPhieuMuon = maPhieuMuon;
            this.tongTien = tongTien;
            this.tongThanhToan = tongTien;
            this.ghiChu = ghiChu;
            this.trangThai = TrangThaiHoaDon.ChuaThanhToan;
            this.ngayTaoHoaDon = DateTime.Now;
            this.ngayThanhToan = null;
        }

        // Public getters và setters
        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public decimal TongThanhToan
        {
            get { return tongThanhToan; }
            set { tongThanhToan = value; }
        }

        public TrangThaiHoaDon TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public DateTime NgayTaoHoaDon
        {
            get { return ngayTaoHoaDon; }
            set { ngayTaoHoaDon = value; }
        }

        public DateTime? NgayThanhToan
        {
            get { return ngayThanhToan; }
            set { ngayThanhToan = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        // Method để thanh toán hóa đơn
        public void ThanhToan()
        {
            trangThai = TrangThaiHoaDon.DaThanhToan;
            ngayThanhToan = DateTime.Now;
        }

        // Method để thanh toán với số tiền cụ thể
        public void ThanhToan(decimal soTienThanhToan)
        {
            tongThanhToan = soTienThanhToan;
            trangThai = TrangThaiHoaDon.DaThanhToan;
            ngayThanhToan = DateTime.Now;
        }

        // Method để tính tiền phạt quá hạn
        public decimal TinhTienPhatQuaHan(int soNgayQuaHan, decimal tienPhatMoiNgay = 1000)
        {
            if (soNgayQuaHan <= 0) return 0;
            return soNgayQuaHan * tienPhatMoiNgay;
        }

        // Method để cập nhật tổng tiền bao gồm phạt
        public void CapNhatTongTien(decimal tienPhat)
        {
            tongTien += tienPhat;
            tongThanhToan = tongTien;
        }

        // Method để lấy tên trạng thái dạng tiếng Việt
        public string GetTrangThaiText()
        {
            switch (trangThai)
            {
                case TrangThaiHoaDon.ChuaThanhToan:
                    return "Chưa thanh toán";
                case TrangThaiHoaDon.DaThanhToan:
                    return "Đã thanh toán";
                default:
                    return "Không xác định";
            }
        }

        // Method để format tiền
        public string GetFormattedTongTien()
        {
            return tongTien.ToString("N0") + " VNĐ";
        }

        // Method để format tiền thanh toán
        public string GetFormattedTongThanhToan()
        {
            return tongThanhToan.ToString("N0") + " VNĐ";
        }

        // Method để tính số tiền còn nợ
        public decimal GetSoTienConNo()
        {
            return Math.Max(0, tongTien - tongThanhToan);
        }

        // Method để format tiền còn nợ
        public string GetFormattedSoTienConNo()
        {
            return GetSoTienConNo().ToString("N0") + " VNĐ";
        }

        // Method để kiểm tra hóa đơn đã thanh toán đủ chưa
        public bool DaThanhToanDu()
        {
            return tongThanhToan >= tongTien;
        }

        // Method để validate đối tượng
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(maPhieuMuon) &&
                   tongTien >= 0 &&
                   tongThanhToan >= 0;
        }

        // Override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"Hóa đơn {maHoaDon} - {GetTrangThaiText()} - {GetFormattedTongTien()}";
        }
    }

    // Helper class để chuyển đổi giữa enum và string database
    internal static class TrangThaiHoaDonHelper
    {
        // Chuyển từ enum sang string database
        public static string ToDbString(TrangThaiHoaDon trangThai)
        {
            switch (trangThai)
            {
                case TrangThaiHoaDon.ChuaThanhToan:
                    return "chua_thanh_toan";
                case TrangThaiHoaDon.DaThanhToan:
                    return "da_thanh_toan";
                default:
                    return "chua_thanh_toan";
            }
        }

        // Chuyển từ string database sang enum
        public static TrangThaiHoaDon FromDbString(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "chua_thanh_toan":
                    return TrangThaiHoaDon.ChuaThanhToan;
                case "da_thanh_toan":
                    return TrangThaiHoaDon.DaThanhToan;
                default:
                    return TrangThaiHoaDon.ChuaThanhToan;
            }
        }
    }
}