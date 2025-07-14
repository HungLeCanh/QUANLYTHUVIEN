namespace QLTV
{
    partial class frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Statistics = new System.Windows.Forms.Panel();
            this.pnl_StatCard1 = new System.Windows.Forms.Panel();
            this.lbl_TotalBooks = new System.Windows.Forms.Label();
            this.lbl_TotalBooksValue = new System.Windows.Forms.Label();
            this.pnl_StatCard2 = new System.Windows.Forms.Panel();
            this.lbl_TotalReaders = new System.Windows.Forms.Label();
            this.lbl_TotalReadersValue = new System.Windows.Forms.Label();
            this.pnl_StatCard3 = new System.Windows.Forms.Panel();
            this.lbl_ActiveLoans = new System.Windows.Forms.Label();
            this.lbl_ActiveLoansValue = new System.Windows.Forms.Label();
            this.pnl_StatCard4 = new System.Windows.Forms.Panel();
            this.lbl_OverdueLoans = new System.Windows.Forms.Label();
            this.lbl_OverdueLoansValue = new System.Windows.Forms.Label();
            this.pnl_StatCard5 = new System.Windows.Forms.Panel();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.lbl_RevenueValue = new System.Windows.Forms.Label();
            this.pnl_StatCard6 = new System.Windows.Forms.Panel();
            this.lbl_PaidInvoices = new System.Windows.Forms.Label();
            this.lbl_PaidInvoicesValue = new System.Windows.Forms.Label();
            this.pnl_Charts = new System.Windows.Forms.Panel();
            this.chart_BooksByCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MonthlyLoans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_BookStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_BooksByCategoryTitle = new System.Windows.Forms.Label();
            this.lbl_MonthlyLoansTitle = new System.Windows.Forms.Label();
            this.lbl_BookStatusTitle = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_Statistics.SuspendLayout();
            this.pnl_StatCard1.SuspendLayout();
            this.pnl_StatCard2.SuspendLayout();
            this.pnl_StatCard3.SuspendLayout();
            this.pnl_StatCard4.SuspendLayout();
            this.pnl_StatCard5.SuspendLayout();
            this.pnl_StatCard6.SuspendLayout();
            this.pnl_Charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BooksByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MonthlyLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BookStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.btn_Refresh);
            this.pnl_Header.Controls.Add(this.btn_Filter);
            this.pnl_Header.Controls.Add(this.btn_Export);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1731, 80);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(20, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(287, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THỐNG KÊ THƯ VIỆN";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(705, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(100, 55);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(585, 13);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 55);
            this.btn_Filter.TabIndex = 5;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = false;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(825, 13);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(100, 55);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Xuất Excel";
            this.btn_Export.UseVisualStyleBackColor = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Main.Controls.Add(this.pnl_Charts);
            this.pnl_Main.Controls.Add(this.pnl_Statistics);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 80);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_Main.Size = new System.Drawing.Size(1731, 747);
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_Statistics
            // 
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard1);
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard2);
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard3);
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard4);
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard5);
            this.pnl_Statistics.Controls.Add(this.pnl_StatCard6);
            this.pnl_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Statistics.Location = new System.Drawing.Point(20, 20);
            this.pnl_Statistics.Name = "pnl_Statistics";
            this.pnl_Statistics.Size = new System.Drawing.Size(1691, 120);
            this.pnl_Statistics.TabIndex = 0;
            // 
            // pnl_StatCard1
            // 
            this.pnl_StatCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnl_StatCard1.Controls.Add(this.lbl_TotalBooks);
            this.pnl_StatCard1.Controls.Add(this.lbl_TotalBooksValue);
            this.pnl_StatCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_StatCard1.Location = new System.Drawing.Point(0, 0);
            this.pnl_StatCard1.Name = "pnl_StatCard1";
            this.pnl_StatCard1.Size = new System.Drawing.Size(559, 120);
            this.pnl_StatCard1.TabIndex = 0;
            // 
            // lbl_TotalBooks
            // 
            this.lbl_TotalBooks.AutoSize = true;
            this.lbl_TotalBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_TotalBooks.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalBooks.Location = new System.Drawing.Point(15, 15);
            this.lbl_TotalBooks.Name = "lbl_TotalBooks";
            this.lbl_TotalBooks.Size = new System.Drawing.Size(92, 23);
            this.lbl_TotalBooks.TabIndex = 0;
            this.lbl_TotalBooks.Text = "Tổng sách:";
            // 
            // lbl_TotalBooksValue
            // 
            this.lbl_TotalBooksValue.AutoSize = true;
            this.lbl_TotalBooksValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalBooksValue.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalBooksValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_TotalBooksValue.Name = "lbl_TotalBooksValue";
            this.lbl_TotalBooksValue.Size = new System.Drawing.Size(46, 54);
            this.lbl_TotalBooksValue.TabIndex = 1;
            this.lbl_TotalBooksValue.Text = "0";
            // 
            // pnl_StatCard2
            // 
            this.pnl_StatCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnl_StatCard2.Controls.Add(this.lbl_TotalReaders);
            this.pnl_StatCard2.Controls.Add(this.lbl_TotalReadersValue);
            this.pnl_StatCard2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_StatCard2.Location = new System.Drawing.Point(559, 0);
            this.pnl_StatCard2.Name = "pnl_StatCard2";
            this.pnl_StatCard2.Size = new System.Drawing.Size(180, 120);
            this.pnl_StatCard2.TabIndex = 1;
            // 
            // lbl_TotalReaders
            // 
            this.lbl_TotalReaders.AutoSize = true;
            this.lbl_TotalReaders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_TotalReaders.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalReaders.Location = new System.Drawing.Point(15, 15);
            this.lbl_TotalReaders.Name = "lbl_TotalReaders";
            this.lbl_TotalReaders.Size = new System.Drawing.Size(114, 23);
            this.lbl_TotalReaders.TabIndex = 0;
            this.lbl_TotalReaders.Text = "Tổng độc giả:";
            // 
            // lbl_TotalReadersValue
            // 
            this.lbl_TotalReadersValue.AutoSize = true;
            this.lbl_TotalReadersValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalReadersValue.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalReadersValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_TotalReadersValue.Name = "lbl_TotalReadersValue";
            this.lbl_TotalReadersValue.Size = new System.Drawing.Size(46, 54);
            this.lbl_TotalReadersValue.TabIndex = 1;
            this.lbl_TotalReadersValue.Text = "0";
            // 
            // pnl_StatCard3
            // 
            this.pnl_StatCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnl_StatCard3.Controls.Add(this.lbl_ActiveLoans);
            this.pnl_StatCard3.Controls.Add(this.lbl_ActiveLoansValue);
            this.pnl_StatCard3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_StatCard3.Location = new System.Drawing.Point(739, 0);
            this.pnl_StatCard3.Name = "pnl_StatCard3";
            this.pnl_StatCard3.Size = new System.Drawing.Size(180, 120);
            this.pnl_StatCard3.TabIndex = 2;
            // 
            // lbl_ActiveLoans
            // 
            this.lbl_ActiveLoans.AutoSize = true;
            this.lbl_ActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_ActiveLoans.ForeColor = System.Drawing.Color.White;
            this.lbl_ActiveLoans.Location = new System.Drawing.Point(15, 15);
            this.lbl_ActiveLoans.Name = "lbl_ActiveLoans";
            this.lbl_ActiveLoans.Size = new System.Drawing.Size(151, 23);
            this.lbl_ActiveLoans.TabIndex = 0;
            this.lbl_ActiveLoans.Text = "Phiếu đang mượn:";
            // 
            // lbl_ActiveLoansValue
            // 
            this.lbl_ActiveLoansValue.AutoSize = true;
            this.lbl_ActiveLoansValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ActiveLoansValue.ForeColor = System.Drawing.Color.White;
            this.lbl_ActiveLoansValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_ActiveLoansValue.Name = "lbl_ActiveLoansValue";
            this.lbl_ActiveLoansValue.Size = new System.Drawing.Size(46, 54);
            this.lbl_ActiveLoansValue.TabIndex = 1;
            this.lbl_ActiveLoansValue.Text = "0";
            // 
            // pnl_StatCard4
            // 
            this.pnl_StatCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnl_StatCard4.Controls.Add(this.lbl_OverdueLoans);
            this.pnl_StatCard4.Controls.Add(this.lbl_OverdueLoansValue);
            this.pnl_StatCard4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_StatCard4.Location = new System.Drawing.Point(919, 0);
            this.pnl_StatCard4.Name = "pnl_StatCard4";
            this.pnl_StatCard4.Size = new System.Drawing.Size(180, 120);
            this.pnl_StatCard4.TabIndex = 3;
            // 
            // lbl_OverdueLoans
            // 
            this.lbl_OverdueLoans.AutoSize = true;
            this.lbl_OverdueLoans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_OverdueLoans.ForeColor = System.Drawing.Color.White;
            this.lbl_OverdueLoans.Location = new System.Drawing.Point(15, 15);
            this.lbl_OverdueLoans.Name = "lbl_OverdueLoans";
            this.lbl_OverdueLoans.Size = new System.Drawing.Size(125, 23);
            this.lbl_OverdueLoans.TabIndex = 0;
            this.lbl_OverdueLoans.Text = "Phiếu quá hạn:";
            // 
            // lbl_OverdueLoansValue
            // 
            this.lbl_OverdueLoansValue.AutoSize = true;
            this.lbl_OverdueLoansValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_OverdueLoansValue.ForeColor = System.Drawing.Color.White;
            this.lbl_OverdueLoansValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_OverdueLoansValue.Name = "lbl_OverdueLoansValue";
            this.lbl_OverdueLoansValue.Size = new System.Drawing.Size(46, 54);
            this.lbl_OverdueLoansValue.TabIndex = 1;
            this.lbl_OverdueLoansValue.Text = "0";
            // 
            // pnl_StatCard5
            // 
            this.pnl_StatCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnl_StatCard5.Controls.Add(this.lbl_Revenue);
            this.pnl_StatCard5.Controls.Add(this.lbl_RevenueValue);
            this.pnl_StatCard5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_StatCard5.Location = new System.Drawing.Point(1099, 0);
            this.pnl_StatCard5.Name = "pnl_StatCard5";
            this.pnl_StatCard5.Size = new System.Drawing.Size(344, 120);
            this.pnl_StatCard5.TabIndex = 4;
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Revenue.ForeColor = System.Drawing.Color.White;
            this.lbl_Revenue.Location = new System.Drawing.Point(15, 15);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(96, 23);
            this.lbl_Revenue.TabIndex = 0;
            this.lbl_Revenue.Text = "Doanh thu:";
            // 
            // lbl_RevenueValue
            // 
            this.lbl_RevenueValue.AutoSize = true;
            this.lbl_RevenueValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_RevenueValue.ForeColor = System.Drawing.Color.White;
            this.lbl_RevenueValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_RevenueValue.Name = "lbl_RevenueValue";
            this.lbl_RevenueValue.Size = new System.Drawing.Size(33, 37);
            this.lbl_RevenueValue.TabIndex = 1;
            this.lbl_RevenueValue.Text = "0";
            // 
            // pnl_StatCard6
            // 
            this.pnl_StatCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.pnl_StatCard6.Controls.Add(this.lbl_PaidInvoices);
            this.pnl_StatCard6.Controls.Add(this.lbl_PaidInvoicesValue);
            this.pnl_StatCard6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_StatCard6.Location = new System.Drawing.Point(1443, 0);
            this.pnl_StatCard6.Name = "pnl_StatCard6";
            this.pnl_StatCard6.Size = new System.Drawing.Size(248, 120);
            this.pnl_StatCard6.TabIndex = 5;
            // 
            // lbl_PaidInvoices
            // 
            this.lbl_PaidInvoices.AutoSize = true;
            this.lbl_PaidInvoices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_PaidInvoices.ForeColor = System.Drawing.Color.White;
            this.lbl_PaidInvoices.Location = new System.Drawing.Point(15, 15);
            this.lbl_PaidInvoices.Name = "lbl_PaidInvoices";
            this.lbl_PaidInvoices.Size = new System.Drawing.Size(194, 23);
            this.lbl_PaidInvoices.TabIndex = 0;
            this.lbl_PaidInvoices.Text = "Hóa đơn đã thanh toán:";
            // 
            // lbl_PaidInvoicesValue
            // 
            this.lbl_PaidInvoicesValue.AutoSize = true;
            this.lbl_PaidInvoicesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_PaidInvoicesValue.ForeColor = System.Drawing.Color.White;
            this.lbl_PaidInvoicesValue.Location = new System.Drawing.Point(15, 35);
            this.lbl_PaidInvoicesValue.Name = "lbl_PaidInvoicesValue";
            this.lbl_PaidInvoicesValue.Size = new System.Drawing.Size(46, 54);
            this.lbl_PaidInvoicesValue.TabIndex = 1;
            this.lbl_PaidInvoicesValue.Text = "0";
            // 
            // pnl_Charts
            // 
            this.pnl_Charts.Controls.Add(this.chart_BooksByCategory);
            this.pnl_Charts.Controls.Add(this.chart_MonthlyLoans);
            this.pnl_Charts.Controls.Add(this.chart_BookStatus);
            this.pnl_Charts.Controls.Add(this.lbl_BooksByCategoryTitle);
            this.pnl_Charts.Controls.Add(this.lbl_MonthlyLoansTitle);
            this.pnl_Charts.Controls.Add(this.lbl_BookStatusTitle);
            this.pnl_Charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Charts.Location = new System.Drawing.Point(20, 140);
            this.pnl_Charts.Name = "pnl_Charts";
            this.pnl_Charts.Size = new System.Drawing.Size(1691, 587);
            this.pnl_Charts.TabIndex = 2;
            // 
            // chart_BooksByCategory
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_BooksByCategory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_BooksByCategory.Legends.Add(legend1);
            this.chart_BooksByCategory.Location = new System.Drawing.Point(20, 50);
            this.chart_BooksByCategory.Name = "chart_BooksByCategory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng sách";
            this.chart_BooksByCategory.Series.Add(series1);
            this.chart_BooksByCategory.Size = new System.Drawing.Size(550, 200);
            this.chart_BooksByCategory.TabIndex = 1;
            this.chart_BooksByCategory.Text = "chart_BooksByCategory";
            // 
            // chart_MonthlyLoans
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_MonthlyLoans.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_MonthlyLoans.Legends.Add(legend2);
            this.chart_MonthlyLoans.Location = new System.Drawing.Point(902, 50);
            this.chart_MonthlyLoans.Name = "chart_MonthlyLoans";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số lượt mượn";
            this.chart_MonthlyLoans.Series.Add(series2);
            this.chart_MonthlyLoans.Size = new System.Drawing.Size(550, 450);
            this.chart_MonthlyLoans.TabIndex = 3;
            this.chart_MonthlyLoans.Text = "chart_MonthlyLoans";
            // 
            // chart_BookStatus
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_BookStatus.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_BookStatus.Legends.Add(legend3);
            this.chart_BookStatus.Location = new System.Drawing.Point(20, 300);
            this.chart_BookStatus.Name = "chart_BookStatus";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Trạng thái";
            this.chart_BookStatus.Series.Add(series3);
            this.chart_BookStatus.Size = new System.Drawing.Size(550, 200);
            this.chart_BookStatus.TabIndex = 5;
            this.chart_BookStatus.Text = "chart_BookStatus";
            // 
            // lbl_BooksByCategoryTitle
            // 
            this.lbl_BooksByCategoryTitle.AutoSize = true;
            this.lbl_BooksByCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_BooksByCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_BooksByCategoryTitle.Location = new System.Drawing.Point(20, 20);
            this.lbl_BooksByCategoryTitle.Name = "lbl_BooksByCategoryTitle";
            this.lbl_BooksByCategoryTitle.Size = new System.Drawing.Size(389, 32);
            this.lbl_BooksByCategoryTitle.TabIndex = 0;
            this.lbl_BooksByCategoryTitle.Text = "THỐNG KÊ SÁCH THEO THỂ LOẠI";
            // 
            // lbl_MonthlyLoansTitle
            // 
            this.lbl_MonthlyLoansTitle.AutoSize = true;
            this.lbl_MonthlyLoansTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_MonthlyLoansTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_MonthlyLoansTitle.Location = new System.Drawing.Point(902, 20);
            this.lbl_MonthlyLoansTitle.Name = "lbl_MonthlyLoansTitle";
            this.lbl_MonthlyLoansTitle.Size = new System.Drawing.Size(455, 32);
            this.lbl_MonthlyLoansTitle.TabIndex = 2;
            this.lbl_MonthlyLoansTitle.Text = "THỐNG KÊ MƯỢN SÁCH THEO THÁNG";
            // 
            // lbl_BookStatusTitle
            // 
            this.lbl_BookStatusTitle.AutoSize = true;
            this.lbl_BookStatusTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_BookStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_BookStatusTitle.Location = new System.Drawing.Point(20, 270);
            this.lbl_BookStatusTitle.Name = "lbl_BookStatusTitle";
            this.lbl_BookStatusTitle.Size = new System.Drawing.Size(360, 32);
            this.lbl_BookStatusTitle.TabIndex = 4;
            this.lbl_BookStatusTitle.Text = "THỐNG KÊ TRẠNG THÁI SÁCH";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 827);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Statistics.ResumeLayout(false);
            this.pnl_StatCard1.ResumeLayout(false);
            this.pnl_StatCard1.PerformLayout();
            this.pnl_StatCard2.ResumeLayout(false);
            this.pnl_StatCard2.PerformLayout();
            this.pnl_StatCard3.ResumeLayout(false);
            this.pnl_StatCard3.PerformLayout();
            this.pnl_StatCard4.ResumeLayout(false);
            this.pnl_StatCard4.PerformLayout();
            this.pnl_StatCard5.ResumeLayout(false);
            this.pnl_StatCard5.PerformLayout();
            this.pnl_StatCard6.ResumeLayout(false);
            this.pnl_StatCard6.PerformLayout();
            this.pnl_Charts.ResumeLayout(false);
            this.pnl_Charts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BooksByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MonthlyLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BookStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Export;

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Statistics;
        private System.Windows.Forms.Panel pnl_StatCard1;
        private System.Windows.Forms.Label lbl_TotalBooks;
        private System.Windows.Forms.Label lbl_TotalBooksValue;
        private System.Windows.Forms.Panel pnl_StatCard2;
        private System.Windows.Forms.Label lbl_TotalReaders;
        private System.Windows.Forms.Label lbl_TotalReadersValue;
        private System.Windows.Forms.Panel pnl_StatCard3;
        private System.Windows.Forms.Label lbl_ActiveLoans;
        private System.Windows.Forms.Label lbl_ActiveLoansValue;
        private System.Windows.Forms.Panel pnl_StatCard4;
        private System.Windows.Forms.Label lbl_OverdueLoans;
        private System.Windows.Forms.Label lbl_OverdueLoansValue;
        private System.Windows.Forms.Panel pnl_StatCard5;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.Label lbl_RevenueValue;
        private System.Windows.Forms.Panel pnl_StatCard6;
        private System.Windows.Forms.Label lbl_PaidInvoices;
        private System.Windows.Forms.Label lbl_PaidInvoicesValue;
        private System.Windows.Forms.Panel pnl_Charts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BooksByCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MonthlyLoans;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BookStatus;
        private System.Windows.Forms.Label lbl_BooksByCategoryTitle;
        private System.Windows.Forms.Label lbl_MonthlyLoansTitle;
        private System.Windows.Forms.Label lbl_BookStatusTitle;
    }
}