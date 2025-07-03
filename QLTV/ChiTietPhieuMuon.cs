using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    // Enum cho trạng thái chi tiết phiếu mượn
    public enum TrangThaiChiTietPhieuMuon
    {
        DangMuon,
        DaTra
    }

    internal class ChiTietPhieuMuon
    {
        // Properties tương ứng với các cột trong bảng chi_tiet_phieu_muon
        private int maChiTiet { get; set; }
        private string maPhieuMuon { get; set; }
        private int maSach { get; set; }
        private decimal donGiaMuon { get; set; }
        private decimal thanhTien { get; set; }
        private TrangThaiChiTietPhieuMuon trangThai { get; set; }

        // Constructor mặc định
        public ChiTietPhieuMuon()
        {
            trangThai = TrangThaiChiTietPhieuMuon.DangMuon;
            donGiaMuon = 0;
            thanhTien = 0;
        }

        // Constructor có tham số
        public ChiTietPhieuMuon(string maPhieuMuon, int maSach, decimal donGiaMuon)
        {
            this.maPhieuMuon = maPhieuMuon;
            this.maSach = maSach;
            this.donGiaMuon = donGiaMuon;
            this.thanhTien = donGiaMuon; // Có thể tính toán phức tạp hơn
            this.trangThai = TrangThaiChiTietPhieuMuon.DangMuon;
        }

        // Public getters và setters
        public int MaChiTiet
        {
            get { return maChiTiet; }
            set { maChiTiet = value; }
        }

        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public int MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public decimal DonGiaMuon
        {
            get { return donGiaMuon; }
            set { donGiaMuon = value; }
        }

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public TrangThaiChiTietPhieuMuon TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Method để tính thành tiền
        public void TinhThanhTien()
        {
            thanhTien = donGiaMuon;
        }

        // Method để tính thành tiền với số ngày mượn
        public void TinhThanhTien(int soNgayMuon)
        {
            thanhTien = donGiaMuon * soNgayMuon;
        }

        // Method để trả sách
        public void TraSach()
        {
            trangThai = TrangThaiChiTietPhieuMuon.DaTra;
        }

        // Method để lấy tên trạng thái dạng tiếng Việt
        public string GetTrangThaiText()
        {
            switch (trangThai)
            {
                case TrangThaiChiTietPhieuMuon.DangMuon:
                    return "Đang mượn";
                case TrangThaiChiTietPhieuMuon.DaTra:
                    return "Đã trả";
                default:
                    return "Không xác định";
            }
        }

        // Method để format giá tiền
        public string GetFormattedDonGia()
        {
            return donGiaMuon.ToString("N0") + " VNĐ";
        }

        // Method để format thành tiền
        public string GetFormattedThanhTien()
        {
            return thanhTien.ToString("N0") + " VNĐ";
        }

        // Method để validate đối tượng
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(maPhieuMuon) &&
                   maSach > 0 &&
                   donGiaMuon >= 0 &&
                   thanhTien >= 0;
        }

        // Override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"Chi tiết {maChiTiet} - Sách {maSach} - {GetTrangThaiText()}";
        }
    }

    // Helper class để chuyển đổi giữa enum và string database
    internal static class TrangThaiChiTietPhieuMuonHelper
    {
        // Chuyển từ enum sang string database
        public static string ToDbString(TrangThaiChiTietPhieuMuon trangThai)
        {
            switch (trangThai)
            {
                case TrangThaiChiTietPhieuMuon.DangMuon:
                    return "dang_muon";
                case TrangThaiChiTietPhieuMuon.DaTra:
                    return "da_tra";
                default:
                    return "dang_muon";
            }
        }

        // Chuyển từ string database sang enum
        public static TrangThaiChiTietPhieuMuon FromDbString(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "dang_muon":
                    return TrangThaiChiTietPhieuMuon.DangMuon;
                case "da_tra":
                    return TrangThaiChiTietPhieuMuon.DaTra;
                default:
                    return TrangThaiChiTietPhieuMuon.DangMuon;
            }
        }
    }
}