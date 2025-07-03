using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    internal class DocGia
    {
        // Properties tương ứng với các cột trong bảng doc_gia
        private string soDienThoai { get; set; }
        private string hoTen { get; set; }
        private string email { get; set; }
        private string diaChi { get; set; }
        private DateTime ngayDangKy { get; set; }

        // Constructor mặc định
        public DocGia()
        {
            ngayDangKy = DateTime.Now;
        }

        // Constructor có tham số
        public DocGia(string soDienThoai, string hoTen, string email = null, string diaChi = null)
        {
            this.soDienThoai = soDienThoai;
            this.hoTen = hoTen;
            this.email = email;
            this.diaChi = diaChi;
            ngayDangKy = DateTime.Now;
        }

        // Method để kiểm tra tính hợp lệ của số điện thoại
        public bool IsValidPhoneNumber()
        {
            if (string.IsNullOrEmpty(soDienThoai))
                return false;

            // Kiểm tra độ dài và chỉ chứa số
            return soDienThoai.Length >= 10 && soDienThoai.Length <= 15 &&
                   soDienThoai.All(char.IsDigit);
        }

        // Method để kiểm tra tính hợp lệ của email
        public bool IsValidEmail()
        {
            if (string.IsNullOrEmpty(email))
                return true; // Email không bắt buộc

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Method để validate toàn bộ đối tượng
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(soDienThoai) &&
                   !string.IsNullOrEmpty(hoTen) &&
                   IsValidPhoneNumber() &&
                   IsValidEmail();
        }

        // Override ToString để hiển thị thông tin
        public override string ToString()
        {
            return $"{hoTen} - {soDienThoai}";
        }
    }
}
