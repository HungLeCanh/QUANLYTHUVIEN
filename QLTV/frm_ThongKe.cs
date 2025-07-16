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
            LoadMonthAndYear();
            LoadAllData();
        }


        public void LoadAllData()
        {
            LoadChart_MonthlyLoans();
            LoadStatistic();
            LoadChart_BooksByCategory();
            LoadChart_BookStatus();
        }

        public void LoadMonthAndYear()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbb_Thang.Items.Add(i.ToString("D2"));
            }

            int currentYear = DateTime.Now.Year;
            for (int y = currentYear - 5; y <= currentYear; y++)
            {
                cbb_Nam.Items.Add(y.ToString());
            }

            cbb_Thang.SelectedItem = DateTime.Now.Month.ToString("D2");
            cbb_Nam.SelectedItem = currentYear.ToString();
        }


        public void LoadStatistic()
        {
            if (cbb_Thang.SelectedItem == null || cbb_Nam.SelectedItem == null)
                return;

            string selectedMonth = cbb_Thang.SelectedItem.ToString();
            string selectedYear = cbb_Nam.SelectedItem.ToString();

            // Tổng sách
            string tongSachSql = "SELECT COUNT(*) FROM sach";
            lbl_TotalBooksValue.Text = Convert.ToInt32(db.ExecuteScalar(tongSachSql)).ToString();

            // Tổng độc giả
            string tongDocGiaSql = "SELECT COUNT(*) FROM doc_gia";
            lbl_TotalReadersValue.Text = Convert.ToInt32(db.ExecuteScalar(tongDocGiaSql)).ToString();

            // Tổng phiếu đang mượn trong tháng/năm
            string tongPhieuDangMuonSql = $@"
        SELECT COUNT(*) 
        FROM phieu_muon 
        WHERE trang_thai = 'dang_muon'
          AND MONTH(ngay_muon) = {selectedMonth}
          AND YEAR(ngay_muon) = {selectedYear}";
            lbl_ActiveLoansValue.Text = Convert.ToInt32(db.ExecuteScalar(tongPhieuDangMuonSql)).ToString();

            // Tổng phiếu quá hạn trong tháng/năm
            string tongPhieuQuaHanSql = $@"
        SELECT COUNT(*) 
        FROM phieu_muon 
        WHERE trang_thai = 'qua_han'
          AND MONTH(ngay_muon) = {selectedMonth}
          AND YEAR(ngay_muon) = {selectedYear}";
            lbl_OverdueLoansValue.Text = Convert.ToInt32(db.ExecuteScalar(tongPhieuQuaHanSql)).ToString();

            // Tổng hóa đơn đã thanh toán trong tháng/năm
            string tongHoaDonDaThanhToanSql = $@"
        SELECT COUNT(*) 
        FROM hoa_don 
        WHERE trang_thai = 'da_thanh_toan'
          AND MONTH(ngay_thanh_toan) = {selectedMonth}
          AND YEAR(ngay_thanh_toan) = {selectedYear}";
            lbl_PaidInvoicesValue.Text = Convert.ToInt32(db.ExecuteScalar(tongHoaDonDaThanhToanSql)).ToString();

            // Tổng doanh thu từ các hóa đơn đã thanh toán trong tháng/năm
            string tongDoanhThuSql = $@"
        SELECT ISNULL(SUM(tong_thanh_toan), 0) 
        FROM hoa_don 
        WHERE trang_thai = 'da_thanh_toan'
          AND MONTH(ngay_thanh_toan) = {selectedMonth}
          AND YEAR(ngay_thanh_toan) = {selectedYear}";
            decimal tongDoanhThu = Convert.ToDecimal(db.ExecuteScalar(tongDoanhThuSql));
            lbl_RevenueValue.Text = tongDoanhThu.ToString("N0") + " đ";
        }


        public void LoadChart_MonthlyLoans()
        {
            int year = int.Parse(cbb_Nam.SelectedItem.ToString());
            string sql = $@"
        SELECT 
            MONTH(ngay_muon) AS Thang,
            COUNT(*) AS SoLuotMuon
        FROM phieu_muon
        WHERE YEAR(ngay_muon) = '{year}'
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

        private void cbb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Thang.SelectedItem != null && cbb_Nam.SelectedItem != null)
                LoadAllData();
        }

        private void cbb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Thang.SelectedItem != null && cbb_Nam.SelectedItem != null)
                LoadAllData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }
    }
}
