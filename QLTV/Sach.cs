using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    // Enum cho trạng thái sách
    public enum TrangThaiSach
    {
        CoSan,
        DaMuon,
        BaoTri,
        Mat
    }

    internal class Sach
    {
        // Properties tương ứng với các cột trong bảng sach
        private int maSach { get; set; }
        private string tenSach { get; set; }
        private string tacGia { get; set; }
        private string nhaXuatBan { get; set; }
        private int? namXuatBan { get; set; }
        private string theLoai { get; set; }
        private decimal donGiaMuon { get; set; }
        private TrangThaiSach trangThai { get; set; }

        // Constructor mặc định
        public Sach()
        {
            trangThai = TrangThaiSach.CoSan;
            donGiaMuon = 0;
        }

        // Constructor có tham số
        public Sach(string tenSach, string tacGia = null, string nhaXuatBan = null,
                   int? namXuatBan = null, string theLoai = null, decimal donGiaMuon = 0)
        {
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.nhaXuatBan = nhaXuatBan;
            this.namXuatBan = namXuatBan;
            this.theLoai = theLoai;
            this.donGiaMuon = donGiaMuon;
            trangThai = TrangThaiSach.CoSan;
        }

        // Method để kiểm tra sách có thể mượn được không
        public bool CoTheMuon()
        {
            return trangThai == TrangThaiSach.CoSan;
        }

        // Method để cập nhật trạng thái sách
        public void CapNhatTrangThai(TrangThaiSach trangThaiMoi)
        {
            trangThai = trangThaiMoi;
        }

        // Method để lấy tên trạng thái dạng tiếng Việt
        public string GetTrangThaiText()
        {
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

        // Method để validate đối tượng
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(tenSach) &&
                   donGiaMuon >= 0 &&
                   (namXuatBan == null || (namXuatBan >= 1800 && namXuatBan <= DateTime.Now.Year));
        }

        // Method để format giá tiền
        public string GetFormattedPrice()
        {
            return donGiaMuon.ToString("N0") + " VNĐ";
        }

        // Override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"{tenSach} - {tacGia} ({GetTrangThaiText()})";
        }
    }

    // Helper class để chuyển đổi giữa enum và string database
    internal static class TrangThaiSachHelper
    {
        // Chuyển từ enum sang string database
        public static string ToDbString(TrangThaiSach trangThai)
        {
            switch (trangThai)
            {
                case TrangThaiSach.CoSan:
                    return "co_san";
                case TrangThaiSach.DaMuon:
                    return "da_muon";
                case TrangThaiSach.BaoTri:
                    return "bao_tri";
                case TrangThaiSach.Mat:
                    return "mat";
                default:
                    return "co_san";
            }
        }

        // Chuyển từ string database sang enum
        public static TrangThaiSach FromDbString(string dbValue)
        {
            switch (dbValue?.ToLower())
            {
                case "co_san":
                    return TrangThaiSach.CoSan;
                case "da_muon":
                    return TrangThaiSach.DaMuon;
                case "bao_tri":
                    return TrangThaiSach.BaoTri;
                case "mat":
                    return TrangThaiSach.Mat;
                default:
                    return TrangThaiSach.CoSan;
            }
        }
    }
}
