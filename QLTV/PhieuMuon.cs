using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    // Enum cho trạng thái phiếu mượn
    public enum TrangThaiPhieuMuon
    {
        DangMuon,
        DaTra,
        QuaHan
    }

    internal class PhieuMuon
    {
        // Properties tương ứng với các cột trong bảng phieu_muon
        private string maPhieuMuon { get; set; }
        private string soDienThoaiDocGia { get; set; }
        private DateTime ngayMuon { get; set; }
        private DateTime ngayTraDuKien { get; set; }
        private DateTime? ngayTraThucTe { get; set; }
        private TrangThaiPhieuMuon trangThai { get; set; }

        // Constructor mặc định
        public PhieuMuon()
        {
            maPhieuMuon = Guid.NewGuid().ToString();
            ngayMuon = DateTime.Now;
            trangThai = TrangThaiPhieuMuon.DangMuon;
        }

        // Constructor có tham số
        public PhieuMuon(string soDienThoaiDocGia, DateTime ngayTraDuKien)
        {
            this.maPhieuMuon = Guid.NewGuid().ToString();
            this.soDienThoaiDocGia = soDienThoaiDocGia;
            this.ngayMuon = DateTime.Now;
            this.ngayTraDuKien = ngayTraDuKien;
            this.ngayTraThucTe = null;
            this.trangThai = TrangThaiPhieuMuon.DangMuon;
        }

        // Public getters và setters
        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public string SoDienThoaiDocGia
        {
            get { return soDienThoaiDocGia; }
            set { soDienThoaiDocGia = value; }
        }

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set { ngayMuon = value; }
        }

        public DateTime NgayTraDuKien
        {
            get { return ngayTraDuKien; }
            set { ngayTraDuKien = value; }
        }

        public DateTime? NgayTraThucTe
        {
            get { return ngayTraThucTe; }
            set { ngayTraThucTe = value; }
        }

        public TrangThaiPhieuMuon TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        // Method để kiểm tra phiếu mượn có quá hạn không
        public bool IsOverdue()
        {
            return ngayTraThucTe == null && DateTime.Now > ngayTraDuKien;
        }

        // Method để cập nhật trạng thái tự động
        public void UpdateStatus()
        {
            if (ngayTraThucTe != null)
            {
                trangThai = TrangThaiPhieuMuon.DaTra;
            }
            else if (IsOverdue())
            {
                trangThai = TrangThaiPhieuMuon.QuaHan;
            }
            else
            {
                trangThai = TrangThaiPhieuMuon.DangMuon;
            }
        }

        // Method để trả sách
        public void TraSach()
        {
            ngayTraThucTe = DateTime.Now;
            UpdateStatus();
        }

        // Method để lấy tên trạng thái dạng tiếng Việt
        public string GetTrangThaiText()
        {
            switch (trangThai)
            {
                case TrangThaiPhieuMuon.DangMuon:
                    return "Đang mượn";
                case TrangThaiPhieuMuon.DaTra:
                    return "Đã trả";
                case TrangThaiPhieuMuon.QuaHan:
                    return "Quá hạn";
                default:
                    return "Không xác định";
            }
        }

        // Method để tính số ngày đã mượn
        public int GetSoNgayMuon()
        {
            DateTime ngayTinhToan = ngayTraThucTe ?? DateTime.Now;
            return (int)(ngayTinhToan - ngayMuon).TotalDays;
        }

        // Method để tính số ngày quá hạn
        public int GetSoNgayQuaHan()
        {
            if (ngayTraThucTe != null)
            {
                // Đã trả sách
                return Math.Max(0, (int)(ngayTraThucTe.Value - ngayTraDuKien).TotalDays);
            }
            else
            {
                // Chưa trả sách
                return Math.Max(0, (int)(DateTime.Now - ngayTraDuKien).TotalDays);
            }
        }

        // Method để validate đối tượng
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(maPhieuMuon) &&
                   !string.IsNullOrEmpty(soDienThoaiDocGia) &&
                   ngayTraDuKien >= ngayMuon;
        }

        // Override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"Phiếu mượn {maPhieuMuon} - {GetTrangThaiText()}";
        }
    }

    // Helper class để chuyển đổi giữa enum và string database
    internal static class TrangThaiPhieuMuonHelper
    {
        // Chuyển từ enum sang string database
        public static string ToDbString(TrangThaiPhieuMuon trangThai)
        {
            switch (trangThai)
            {
                case TrangThaiPhieuMuon.DangMuon:
                    return "dang_muon";
                case TrangThaiPhieuMuon.DaTra:
                    return "da_tra";
                case TrangThaiPhieuMuon.QuaHan:
                    return "qua_han";
                default:
                    return "dang_muon";
            }
        }

        // Chuyển từ string database sang enum
        public static TrangThaiPhieuMuon FromDbString(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "dang_muon":
                    return TrangThaiPhieuMuon.DangMuon;
                case "da_tra":
                    return TrangThaiPhieuMuon.DaTra;
                case "qua_han":
                    return TrangThaiPhieuMuon.QuaHan;
                default:
                    return TrangThaiPhieuMuon.DangMuon;
            }
        }
    }
}