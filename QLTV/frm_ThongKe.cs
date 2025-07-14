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
    public partial class frm_ThongKe : Form
    {
        Database db;
        public frm_ThongKe()
        {
            InitializeComponent();
            db = new Database();
            LoadStatistic();
            LoadChart_MonthlyLoans();
            LoadChart_BooksByCategory();
            LoadChart_BookStatus();
        }

        public void LoadStatistic()
        {
            // Tổng sách
            string tongSachSql = "SELECT COUNT(*) FROM sach";
            int tongSach = Convert.ToInt32(db.ExecuteScalar(tongSachSql));
            lbl_TotalBooksValue.Text = tongSach.ToString();

            // Tổng độc giả
            string tongDocGiaSql = "SELECT COUNT(*) FROM doc_gia";
            int tongDocGia = Convert.ToInt32(db.ExecuteScalar(tongDocGiaSql));
            lbl_TotalReadersValue.Text = tongDocGia.ToString();

            // Tổng phiếu đang mượn
            string tongPhieuDangMuonSql = "SELECT COUNT(*) FROM phieu_muon WHERE trang_thai = 'dang_muon'";
            int tongPhieuDangMuon = Convert.ToInt32(db.ExecuteScalar(tongPhieuDangMuonSql));
            lbl_ActiveLoansValue.Text = tongPhieuDangMuon.ToString();

            // Tổng phiếu quá hạn
            string tongPhieuQuaHanSql = "SELECT COUNT(*) FROM phieu_muon WHERE trang_thai = 'qua_han'";
            int tongPhieuQuaHan = Convert.ToInt32(db.ExecuteScalar(tongPhieuQuaHanSql));
            lbl_OverdueLoansValue.Text = tongPhieuQuaHan.ToString();

            // Tổng hóa đơn đã thanh toán
            string tongHoaDonDaThanhToanSql = "SELECT COUNT(*) FROM hoa_don WHERE trang_thai = 'da_thanh_toan'";
            int tongHoaDonDaThanhToan = Convert.ToInt32(db.ExecuteScalar(tongHoaDonDaThanhToanSql));
            lbl_PaidInvoicesValue.Text = tongHoaDonDaThanhToan.ToString();

            // Tổng doanh thu từ các hóa đơn đã thanh toán
            string tongDoanhThuSql = "SELECT ISNULL(SUM(tong_thanh_toan), 0) FROM hoa_don WHERE trang_thai = 'da_thanh_toan'";
            decimal tongDoanhThu = Convert.ToDecimal(db.ExecuteScalar(tongDoanhThuSql));
            lbl_RevenueValue.Text = tongDoanhThu.ToString("N0") + " đ"; // Định dạng tiền
        }

        public void LoadChart_MonthlyLoans()
        {
            string sql = @"
        SELECT 
            MONTH(ngay_muon) AS Thang,
            COUNT(*) AS SoLuotMuon
        FROM phieu_muon
        WHERE YEAR(ngay_muon) = YEAR(GETDATE())
        GROUP BY MONTH(ngay_muon)
        ORDER BY Thang";

            DataTable dt = db.ExecuteQuery(sql);

            // Xóa dữ liệu cũ nếu có
            chart_MonthlyLoans.Series["Số lượt mượn"].Points.Clear();

            // Thêm dữ liệu mới
            foreach (DataRow row in dt.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                int soLuotMuon = Convert.ToInt32(row["SoLuotMuon"]);

                chart_MonthlyLoans.Series["Số lượt mượn"].Points.AddXY("Tháng " + thang, soLuotMuon);
            }

            // Tùy chọn định dạng hiển thị đẹp hơn
            chart_MonthlyLoans.ChartAreas[0].AxisX.Title = "Tháng";
            chart_MonthlyLoans.ChartAreas[0].AxisY.Title = "Số lượt mượn";
            chart_MonthlyLoans.ChartAreas[0].AxisX.Interval = 1;
        }

        public void LoadChart_BooksByCategory()
        {
            string sql = @"
        SELECT the_loai, COUNT(*) AS SoLuong
        FROM sach
        GROUP BY the_loai
        ORDER BY the_loai";

            DataTable dt = db.ExecuteQuery(sql);

            // Xóa dữ liệu cũ nếu có
            chart_BooksByCategory.Series["Số lượng sách"].Points.Clear();

            // Thêm dữ liệu mới vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string theLoai = row["the_loai"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                chart_BooksByCategory.Series["Số lượng sách"].Points.AddXY(theLoai, soLuong);
            }

            // Cấu hình thêm cho đẹp hơn
            chart_BooksByCategory.ChartAreas[0].AxisX.Title = "Thể loại";
            chart_BooksByCategory.ChartAreas[0].AxisY.Title = "Số lượng sách";
            chart_BooksByCategory.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // nghiêng nhãn thể loại nếu dài
            chart_BooksByCategory.ChartAreas[0].AxisX.Interval = 1;
        }

        public void LoadChart_BookStatus()
        {
            string sql = @"
        SELECT trang_thai, COUNT(*) AS SoLuong
        FROM sach
        GROUP BY trang_thai";

            DataTable dt = db.ExecuteQuery(sql);

            // Xóa dữ liệu cũ nếu có
            chart_BookStatus.Series["Trạng thái"].Points.Clear();

            // Thêm dữ liệu mới vào Pie chart
            foreach (DataRow row in dt.Rows)
            {
                string trangThai = row["trang_thai"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                chart_BookStatus.Series["Trạng thái"].Points.AddXY(trangThai, soLuong);
            }

            // Cấu hình Pie chart cho rõ ràng hơn
            chart_BookStatus.Series["Trạng thái"].IsValueShownAsLabel = true;
            chart_BookStatus.Series["Trạng thái"].Label = "#VALX: #PERCENT";
            chart_BookStatus.Series["Trạng thái"].ToolTip = "#VALX: #VAL (#PERCENT)";
        }

    }
}
