using System.Drawing;
using System.Windows.Forms;

namespace QLTV
{
    partial class frm_XuatHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_TimKiem = new System.Windows.Forms.Panel();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_PhieuMuon = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.col_MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDienThoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayTraDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayTraThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThaiPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_DanhSachPhieuMuon = new System.Windows.Forms.Label();
            this.pnl_ThongTin = new System.Windows.Forms.Panel();
            this.btn_HomNay = new System.Windows.Forms.Button();
            this.btn_TinhLaiThanhTien = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaPhieuMuon = new System.Windows.Forms.TextBox();
            this.lbl_ThongTinPhieu = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.txt_NgayMuon = new System.Windows.Forms.TextBox();
            this.lbl_NgayTraDuKien = new System.Windows.Forms.Label();
            this.txt_NgayTraDuKien = new System.Windows.Forms.TextBox();
            this.lbl_NgayTraThucTe = new System.Windows.Forms.Label();
            this.txt_NgayTraThucTe = new System.Windows.Forms.TextBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_ChiTietPhieuMuon = new System.Windows.Forms.Panel();
            this.lbl_ChiTietPhieuMuon = new System.Windows.Forms.Label();
            this.dgv_ChiTietPhieuMuon = new System.Windows.Forms.DataGridView();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_TimKiem.SuspendLayout();
            this.pnl_PhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.pnl_ThongTin.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_ChiTietPhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuMuon)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TimKiem
            // 
            this.pnl_TimKiem.Controls.Add(this.lbl_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.btn_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.btn_Refresh);
            this.pnl_TimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TimKiem.Location = new System.Drawing.Point(983, 0);
            this.pnl_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TimKiem.Name = "pnl_TimKiem";
            this.pnl_TimKiem.Size = new System.Drawing.Size(941, 66);
            this.pnl_TimKiem.TabIndex = 0;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(8, 18);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(245, 29);
            this.lbl_TimKiem.TabIndex = 0;
            this.lbl_TimKiem.Text = "Tìm kiếm theo SĐT:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(269, 21);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(265, 26);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(546, 18);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(107, 37);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(661, 18);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(107, 37);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pnl_PhieuMuon
            // 
            this.pnl_PhieuMuon.Controls.Add(this.label4);
            this.pnl_PhieuMuon.Controls.Add(this.dgv_PhieuMuon);
            this.pnl_PhieuMuon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_PhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.pnl_PhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_PhieuMuon.Name = "pnl_PhieuMuon";
            this.pnl_PhieuMuon.Size = new System.Drawing.Size(983, 813);
            this.pnl_PhieuMuon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách phiếu mượn";
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.AllowUserToAddRows = false;
            this.dgv_PhieuMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_PhieuMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PhieuMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaPhieuMuon,
            this.col_SoDienThoaiDocGia,
            this.col_NgayMuon,
            this.col_NgayTraDuKien,
            this.col_NgayTraThucTe,
            this.col_TrangThaiPhieu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PhieuMuon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PhieuMuon.EnableHeadersVisualStyles = false;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(16, 41);
            this.dgv_PhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PhieuMuon.MultiSelect = false;
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.ReadOnly = true;
            this.dgv_PhieuMuon.RowHeadersVisible = false;
            this.dgv_PhieuMuon.RowHeadersWidth = 51;
            this.dgv_PhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(959, 931);
            this.dgv_PhieuMuon.TabIndex = 1;
            this.dgv_PhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuMuon_CellClick);
            // 
            // col_MaPhieuMuon
            // 
            this.col_MaPhieuMuon.DataPropertyName = "ma_phieu_muon";
            this.col_MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.col_MaPhieuMuon.MinimumWidth = 6;
            this.col_MaPhieuMuon.Name = "col_MaPhieuMuon";
            this.col_MaPhieuMuon.ReadOnly = true;
            // 
            // col_SoDienThoaiDocGia
            // 
            this.col_SoDienThoaiDocGia.DataPropertyName = "so_dien_thoai_doc_gia";
            this.col_SoDienThoaiDocGia.HeaderText = "Số điện thoại";
            this.col_SoDienThoaiDocGia.MinimumWidth = 6;
            this.col_SoDienThoaiDocGia.Name = "col_SoDienThoaiDocGia";
            this.col_SoDienThoaiDocGia.ReadOnly = true;
            // 
            // col_NgayMuon
            // 
            this.col_NgayMuon.DataPropertyName = "ngay_muon";
            this.col_NgayMuon.HeaderText = "Ngày mượn";
            this.col_NgayMuon.MinimumWidth = 6;
            this.col_NgayMuon.Name = "col_NgayMuon";
            this.col_NgayMuon.ReadOnly = true;
            // 
            // col_NgayTraDuKien
            // 
            this.col_NgayTraDuKien.DataPropertyName = "ngay_tra_du_kien";
            this.col_NgayTraDuKien.HeaderText = "Ngày trả dự kiến";
            this.col_NgayTraDuKien.MinimumWidth = 6;
            this.col_NgayTraDuKien.Name = "col_NgayTraDuKien";
            this.col_NgayTraDuKien.ReadOnly = true;
            // 
            // col_NgayTraThucTe
            // 
            this.col_NgayTraThucTe.DataPropertyName = "ngay_tra_thuc_te";
            this.col_NgayTraThucTe.HeaderText = "Ngày trả thực tế";
            this.col_NgayTraThucTe.MinimumWidth = 6;
            this.col_NgayTraThucTe.Name = "col_NgayTraThucTe";
            this.col_NgayTraThucTe.ReadOnly = true;
            // 
            // col_TrangThaiPhieu
            // 
            this.col_TrangThaiPhieu.DataPropertyName = "trang_thai";
            this.col_TrangThaiPhieu.HeaderText = "Trạng thái";
            this.col_TrangThaiPhieu.MinimumWidth = 6;
            this.col_TrangThaiPhieu.Name = "col_TrangThaiPhieu";
            this.col_TrangThaiPhieu.ReadOnly = true;
            // 
            // lbl_DanhSachPhieuMuon
            // 
            this.lbl_DanhSachPhieuMuon.AutoSize = true;
            this.lbl_DanhSachPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_DanhSachPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.lbl_DanhSachPhieuMuon.Location = new System.Drawing.Point(61, 20);
            this.lbl_DanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhSachPhieuMuon.Name = "lbl_DanhSachPhieuMuon";
            this.lbl_DanhSachPhieuMuon.Size = new System.Drawing.Size(216, 41);
            this.lbl_DanhSachPhieuMuon.TabIndex = 0;
            this.lbl_DanhSachPhieuMuon.Text = "Xuất Hoá Đơn";
            // 
            // pnl_ThongTin
            // 
            this.pnl_ThongTin.Controls.Add(this.btn_HomNay);
            this.pnl_ThongTin.Controls.Add(this.btn_TinhLaiThanhTien);
            this.pnl_ThongTin.Controls.Add(this.btn_ThanhToan);
            this.pnl_ThongTin.Controls.Add(this.label3);
            this.pnl_ThongTin.Controls.Add(this.label2);
            this.pnl_ThongTin.Controls.Add(this.txt_ThanhTien);
            this.pnl_ThongTin.Controls.Add(this.label1);
            this.pnl_ThongTin.Controls.Add(this.txt_MaPhieuMuon);
            this.pnl_ThongTin.Controls.Add(this.lbl_ThongTinPhieu);
            this.pnl_ThongTin.Controls.Add(this.lbl_SoDienThoai);
            this.pnl_ThongTin.Controls.Add(this.txt_SoDienThoai);
            this.pnl_ThongTin.Controls.Add(this.lbl_NgayMuon);
            this.pnl_ThongTin.Controls.Add(this.txt_NgayMuon);
            this.pnl_ThongTin.Controls.Add(this.lbl_NgayTraDuKien);
            this.pnl_ThongTin.Controls.Add(this.txt_NgayTraDuKien);
            this.pnl_ThongTin.Controls.Add(this.lbl_NgayTraThucTe);
            this.pnl_ThongTin.Controls.Add(this.txt_NgayTraThucTe);
            this.pnl_ThongTin.Controls.Add(this.lbl_TrangThai);
            this.pnl_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.pnl_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ThongTin.Location = new System.Drawing.Point(983, 66);
            this.pnl_ThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ThongTin.Name = "pnl_ThongTin";
            this.pnl_ThongTin.Size = new System.Drawing.Size(941, 349);
            this.pnl_ThongTin.TabIndex = 3;
            // 
            // btn_HomNay
            // 
            this.btn_HomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomNay.Location = new System.Drawing.Point(518, 264);
            this.btn_HomNay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HomNay.Name = "btn_HomNay";
            this.btn_HomNay.Size = new System.Drawing.Size(107, 34);
            this.btn_HomNay.TabIndex = 5;
            this.btn_HomNay.Text = "Hôm nay";
            this.btn_HomNay.UseVisualStyleBackColor = true;
            this.btn_HomNay.Click += new System.EventHandler(this.btn_HomNay_Click);
            // 
            // btn_TinhLaiThanhTien
            // 
            this.btn_TinhLaiThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_TinhLaiThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhLaiThanhTien.Location = new System.Drawing.Point(577, 112);
            this.btn_TinhLaiThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TinhLaiThanhTien.Name = "btn_TinhLaiThanhTien";
            this.btn_TinhLaiThanhTien.Size = new System.Drawing.Size(222, 34);
            this.btn_TinhLaiThanhTien.TabIndex = 5;
            this.btn_TinhLaiThanhTien.Text = "Tính thành tiền";
            this.btn_TinhLaiThanhTien.UseVisualStyleBackColor = false;
            this.btn_TinhLaiThanhTien.Click += new System.EventHandler(this.btn_TinhLaiThanhTien_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(816, 113);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(139, 34);
            this.btn_ThanhToan.TabIndex = 6;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(242, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "(dd-MM-yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thành tiền:";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(690, 65);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(265, 26);
            this.txt_ThanhTien.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // txt_MaPhieuMuon
            // 
            this.txt_MaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhieuMuon.Location = new System.Drawing.Point(245, 71);
            this.txt_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaPhieuMuon.Name = "txt_MaPhieuMuon";
            this.txt_MaPhieuMuon.ReadOnly = true;
            this.txt_MaPhieuMuon.Size = new System.Drawing.Size(265, 26);
            this.txt_MaPhieuMuon.TabIndex = 12;
            // 
            // lbl_ThongTinPhieu
            // 
            this.lbl_ThongTinPhieu.AutoSize = true;
            this.lbl_ThongTinPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinPhieu.Location = new System.Drawing.Point(16, 12);
            this.lbl_ThongTinPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThongTinPhieu.Name = "lbl_ThongTinPhieu";
            this.lbl_ThongTinPhieu.Size = new System.Drawing.Size(377, 25);
            this.lbl_ThongTinPhieu.TabIndex = 0;
            this.lbl_ThongTinPhieu.Text = "Thông tin phiếu mượn cần thanh toán:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(16, 120);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(174, 29);
            this.lbl_SoDienThoai.TabIndex = 1;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(245, 120);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.ReadOnly = true;
            this.txt_SoDienThoai.Size = new System.Drawing.Size(265, 26);
            this.txt_SoDienThoai.TabIndex = 2;
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuon.Location = new System.Drawing.Point(16, 169);
            this.lbl_NgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(151, 29);
            this.lbl_NgayMuon.TabIndex = 3;
            this.lbl_NgayMuon.Text = "Ngày mượn:";
            // 
            // txt_NgayMuon
            // 
            this.txt_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayMuon.Location = new System.Drawing.Point(245, 169);
            this.txt_NgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayMuon.Name = "txt_NgayMuon";
            this.txt_NgayMuon.ReadOnly = true;
            this.txt_NgayMuon.Size = new System.Drawing.Size(265, 26);
            this.txt_NgayMuon.TabIndex = 4;
            // 
            // lbl_NgayTraDuKien
            // 
            this.lbl_NgayTraDuKien.AutoSize = true;
            this.lbl_NgayTraDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTraDuKien.Location = new System.Drawing.Point(16, 218);
            this.lbl_NgayTraDuKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayTraDuKien.Name = "lbl_NgayTraDuKien";
            this.lbl_NgayTraDuKien.Size = new System.Drawing.Size(209, 29);
            this.lbl_NgayTraDuKien.TabIndex = 5;
            this.lbl_NgayTraDuKien.Text = "Ngày trả dự kiến:";
            // 
            // txt_NgayTraDuKien
            // 
            this.txt_NgayTraDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayTraDuKien.Location = new System.Drawing.Point(245, 218);
            this.txt_NgayTraDuKien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayTraDuKien.Name = "txt_NgayTraDuKien";
            this.txt_NgayTraDuKien.ReadOnly = true;
            this.txt_NgayTraDuKien.Size = new System.Drawing.Size(265, 26);
            this.txt_NgayTraDuKien.TabIndex = 6;
            // 
            // lbl_NgayTraThucTe
            // 
            this.lbl_NgayTraThucTe.AutoSize = true;
            this.lbl_NgayTraThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTraThucTe.Location = new System.Drawing.Point(16, 267);
            this.lbl_NgayTraThucTe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayTraThucTe.Name = "lbl_NgayTraThucTe";
            this.lbl_NgayTraThucTe.Size = new System.Drawing.Size(201, 29);
            this.lbl_NgayTraThucTe.TabIndex = 7;
            this.lbl_NgayTraThucTe.Text = "Ngày trả thực tế:";
            // 
            // txt_NgayTraThucTe
            // 
            this.txt_NgayTraThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayTraThucTe.Location = new System.Drawing.Point(245, 268);
            this.txt_NgayTraThucTe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayTraThucTe.Name = "txt_NgayTraThucTe";
            this.txt_NgayTraThucTe.Size = new System.Drawing.Size(265, 26);
            this.txt_NgayTraThucTe.TabIndex = 8;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.Location = new System.Drawing.Point(16, 316);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(138, 29);
            this.lbl_TrangThai.TabIndex = 9;
            this.lbl_TrangThai.Text = "Trạng thái:";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "dang_muon",
            "da_tra",
            "qua_han"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(245, 317);
            this.cbo_TrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(265, 28);
            this.cbo_TrangThai.TabIndex = 10;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_ThongTin);
            this.pnl_Main.Controls.Add(this.pnl_ChiTietPhieuMuon);
            this.pnl_Main.Controls.Add(this.pnl_TimKiem);
            this.pnl_Main.Controls.Add(this.pnl_PhieuMuon);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 80);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1924, 813);
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_ChiTietPhieuMuon
            // 
            this.pnl_ChiTietPhieuMuon.Controls.Add(this.lbl_ChiTietPhieuMuon);
            this.pnl_ChiTietPhieuMuon.Controls.Add(this.dgv_ChiTietPhieuMuon);
            this.pnl_ChiTietPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ChiTietPhieuMuon.Location = new System.Drawing.Point(983, 415);
            this.pnl_ChiTietPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ChiTietPhieuMuon.Name = "pnl_ChiTietPhieuMuon";
            this.pnl_ChiTietPhieuMuon.Size = new System.Drawing.Size(941, 398);
            this.pnl_ChiTietPhieuMuon.TabIndex = 2;
            // 
            // lbl_ChiTietPhieuMuon
            // 
            this.lbl_ChiTietPhieuMuon.AutoSize = true;
            this.lbl_ChiTietPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChiTietPhieuMuon.Location = new System.Drawing.Point(16, 12);
            this.lbl_ChiTietPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChiTietPhieuMuon.Name = "lbl_ChiTietPhieuMuon";
            this.lbl_ChiTietPhieuMuon.Size = new System.Drawing.Size(246, 25);
            this.lbl_ChiTietPhieuMuon.TabIndex = 0;
            this.lbl_ChiTietPhieuMuon.Text = "Chi tiết sách trong phiếu";
            // 
            // dgv_ChiTietPhieuMuon
            // 
            this.dgv_ChiTietPhieuMuon.AllowUserToAddRows = false;
            this.dgv_ChiTietPhieuMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_ChiTietPhieuMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ChiTietPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ChiTietPhieuMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTietPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ChiTietPhieuMuon.ColumnHeadersHeight = 29;
            this.dgv_ChiTietPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.col_TenSach,
            this.col_TacGia,
            this.col_DonGiaMuon,
            this.col_ThanhTien,
            this.col_TrangThaiSach});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChiTietPhieuMuon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ChiTietPhieuMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ChiTietPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgv_ChiTietPhieuMuon.Location = new System.Drawing.Point(0, 40);
            this.dgv_ChiTietPhieuMuon.MultiSelect = false;
            this.dgv_ChiTietPhieuMuon.Name = "dgv_ChiTietPhieuMuon";
            this.dgv_ChiTietPhieuMuon.ReadOnly = true;
            this.dgv_ChiTietPhieuMuon.RowHeadersVisible = false;
            this.dgv_ChiTietPhieuMuon.RowHeadersWidth = 51;
            this.dgv_ChiTietPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTietPhieuMuon.Size = new System.Drawing.Size(941, 358);
            this.dgv_ChiTietPhieuMuon.TabIndex = 1;
            // 
            // col_MaSach
            // 
            this.col_MaSach.DataPropertyName = "ma_sach";
            this.col_MaSach.HeaderText = "Mã sách";
            this.col_MaSach.MinimumWidth = 6;
            this.col_MaSach.Name = "col_MaSach";
            this.col_MaSach.ReadOnly = true;
            // 
            // col_TenSach
            // 
            this.col_TenSach.DataPropertyName = "ten_sach";
            this.col_TenSach.HeaderText = "Tên sách";
            this.col_TenSach.MinimumWidth = 6;
            this.col_TenSach.Name = "col_TenSach";
            this.col_TenSach.ReadOnly = true;
            // 
            // col_TacGia
            // 
            this.col_TacGia.DataPropertyName = "tac_gia";
            this.col_TacGia.HeaderText = "Tác giả";
            this.col_TacGia.MinimumWidth = 6;
            this.col_TacGia.Name = "col_TacGia";
            this.col_TacGia.ReadOnly = true;
            // 
            // col_DonGiaMuon
            // 
            this.col_DonGiaMuon.DataPropertyName = "don_gia_muon";
            this.col_DonGiaMuon.HeaderText = "Đơn giá";
            this.col_DonGiaMuon.MinimumWidth = 6;
            this.col_DonGiaMuon.Name = "col_DonGiaMuon";
            this.col_DonGiaMuon.ReadOnly = true;
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.DataPropertyName = "thanh_tien";
            this.col_ThanhTien.HeaderText = "Thành tiền";
            this.col_ThanhTien.MinimumWidth = 6;
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // col_TrangThaiSach
            // 
            this.col_TrangThaiSach.DataPropertyName = "trang_thai";
            this.col_TrangThaiSach.HeaderText = "Trạng thái";
            this.col_TrangThaiSach.MinimumWidth = 6;
            this.col_TrangThaiSach.Name = "col_TrangThaiSach";
            this.col_TrangThaiSach.ReadOnly = true;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnl_Header.Controls.Add(this.lbl_DanhSachPhieuMuon);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1924, 80);
            this.pnl_Header.TabIndex = 2;
            // 
            // frm_XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 893);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_XuatHoaDon";
            this.Text = "Xuất Hoá Đơn";
            this.Load += new System.EventHandler(this.frm_XuatHoaDon_Load);
            this.pnl_TimKiem.ResumeLayout(false);
            this.pnl_TimKiem.PerformLayout();
            this.pnl_PhieuMuon.ResumeLayout(false);
            this.pnl_PhieuMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.pnl_ThongTin.ResumeLayout(false);
            this.pnl_ThongTin.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_ChiTietPhieuMuon.ResumeLayout(false);
            this.pnl_ChiTietPhieuMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuMuon)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_PhieuMuon;
        private System.Windows.Forms.Label lbl_DanhSachPhieuMuon;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDienThoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayTraDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayTraThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThaiPhieu;
        private System.Windows.Forms.Panel pnl_ThongTin;
        private System.Windows.Forms.Label lbl_ThongTinPhieu;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.TextBox txt_NgayMuon;
        private System.Windows.Forms.Label lbl_NgayTraDuKien;
        private System.Windows.Forms.TextBox txt_NgayTraDuKien;
        private System.Windows.Forms.Label lbl_NgayTraThucTe;
        private System.Windows.Forms.TextBox txt_NgayTraThucTe;
        private System.Windows.Forms.Label lbl_TrangThai;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_ChiTietPhieuMuon;
        private System.Windows.Forms.Label lbl_ChiTietPhieuMuon;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaPhieuMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TinhLaiThanhTien;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_HomNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThaiSach;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label4;
    }
}