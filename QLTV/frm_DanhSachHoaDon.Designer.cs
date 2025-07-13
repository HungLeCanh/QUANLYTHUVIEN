using System.Drawing;
using System.Windows.Forms;

namespace QLTV
{
    partial class frm_DanhSachHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_DanhSachPhieuMuon = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_ThongTin = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.txt_NgayThanhToan = new System.Windows.Forms.TextBox();
            this.lbl_NgayThanhToan = new System.Windows.Forms.Label();
            this.txt_NgayTaoHoaDon = new System.Windows.Forms.TextBox();
            this.lbl_NgayTaoHD = new System.Windows.Forms.Label();
            this.txt_TongThanhToan = new System.Windows.Forms.TextBox();
            this.lbl_TongThanhToan = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lbl_CanThanhToan = new System.Windows.Forms.Label();
            this.txt_MaPhieuMuon = new System.Windows.Forms.TextBox();
            this.lnl_MaPhieuMuon = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.lbl_MaHoaDon = new System.Windows.Forms.Label();
            this.pnl_DanhSachHoaDon = new System.Windows.Forms.Panel();
            this.dgv_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.col_MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TongThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayTaoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_ThongTin.SuspendLayout();
            this.pnl_DanhSachHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnl_Header.Controls.Add(this.lbl_DanhSachPhieuMuon);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1924, 80);
            this.pnl_Header.TabIndex = 3;
            // 
            // lbl_DanhSachPhieuMuon
            // 
            this.lbl_DanhSachPhieuMuon.AutoSize = true;
            this.lbl_DanhSachPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_DanhSachPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.lbl_DanhSachPhieuMuon.Location = new System.Drawing.Point(61, 20);
            this.lbl_DanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhSachPhieuMuon.Name = "lbl_DanhSachPhieuMuon";
            this.lbl_DanhSachPhieuMuon.Size = new System.Drawing.Size(297, 41);
            this.lbl_DanhSachPhieuMuon.TabIndex = 0;
            this.lbl_DanhSachPhieuMuon.Text = "Danh Sách Hoá Đơn";
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_ThongTin);
            this.pnl_Main.Controls.Add(this.pnl_DanhSachHoaDon);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 80);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1924, 966);
            this.pnl_Main.TabIndex = 4;
            // 
            // pnl_ThongTin
            // 
            this.pnl_ThongTin.Controls.Add(this.btn_Clear);
            this.pnl_ThongTin.Controls.Add(this.btn_Xoa);
            this.pnl_ThongTin.Controls.Add(this.btn_Sua);
            this.pnl_ThongTin.Controls.Add(this.label8);
            this.pnl_ThongTin.Controls.Add(this.txt_GhiChu);
            this.pnl_ThongTin.Controls.Add(this.lbl_GhiChu);
            this.pnl_ThongTin.Controls.Add(this.txt_NgayThanhToan);
            this.pnl_ThongTin.Controls.Add(this.lbl_NgayThanhToan);
            this.pnl_ThongTin.Controls.Add(this.txt_NgayTaoHoaDon);
            this.pnl_ThongTin.Controls.Add(this.lbl_NgayTaoHD);
            this.pnl_ThongTin.Controls.Add(this.txt_TongThanhToan);
            this.pnl_ThongTin.Controls.Add(this.lbl_TongThanhToan);
            this.pnl_ThongTin.Controls.Add(this.txt_TongTien);
            this.pnl_ThongTin.Controls.Add(this.lbl_CanThanhToan);
            this.pnl_ThongTin.Controls.Add(this.txt_MaPhieuMuon);
            this.pnl_ThongTin.Controls.Add(this.lnl_MaPhieuMuon);
            this.pnl_ThongTin.Controls.Add(this.txt_MaHoaDon);
            this.pnl_ThongTin.Controls.Add(this.lbl_MaHoaDon);
            this.pnl_ThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ThongTin.Location = new System.Drawing.Point(1203, 0);
            this.pnl_ThongTin.Name = "pnl_ThongTin";
            this.pnl_ThongTin.Size = new System.Drawing.Size(721, 966);
            this.pnl_ThongTin.TabIndex = 1;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(357, 396);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(104, 42);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(226, 396);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 42);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(89, 396);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 42);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chi Tiết Hoá Đơn";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GhiChu.Location = new System.Drawing.Point(243, 333);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(219, 30);
            this.txt_GhiChu.TabIndex = 14;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GhiChu.Location = new System.Drawing.Point(31, 337);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(80, 22);
            this.lbl_GhiChu.TabIndex = 13;
            this.lbl_GhiChu.Text = "Ghi Chú:";
            // 
            // txt_NgayThanhToan
            // 
            this.txt_NgayThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayThanhToan.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayThanhToan.Location = new System.Drawing.Point(243, 291);
            this.txt_NgayThanhToan.Name = "txt_NgayThanhToan";
            this.txt_NgayThanhToan.ReadOnly = true;
            this.txt_NgayThanhToan.Size = new System.Drawing.Size(219, 30);
            this.txt_NgayThanhToan.TabIndex = 12;
            // 
            // lbl_NgayThanhToan
            // 
            this.lbl_NgayThanhToan.AutoSize = true;
            this.lbl_NgayThanhToan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThanhToan.Location = new System.Drawing.Point(31, 295);
            this.lbl_NgayThanhToan.Name = "lbl_NgayThanhToan";
            this.lbl_NgayThanhToan.Size = new System.Drawing.Size(161, 22);
            this.lbl_NgayThanhToan.TabIndex = 11;
            this.lbl_NgayThanhToan.Text = "Ngày Thanh Toán:";
            // 
            // txt_NgayTaoHoaDon
            // 
            this.txt_NgayTaoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NgayTaoHoaDon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayTaoHoaDon.Location = new System.Drawing.Point(243, 247);
            this.txt_NgayTaoHoaDon.Name = "txt_NgayTaoHoaDon";
            this.txt_NgayTaoHoaDon.ReadOnly = true;
            this.txt_NgayTaoHoaDon.Size = new System.Drawing.Size(219, 30);
            this.txt_NgayTaoHoaDon.TabIndex = 10;
            // 
            // lbl_NgayTaoHD
            // 
            this.lbl_NgayTaoHD.AutoSize = true;
            this.lbl_NgayTaoHD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTaoHD.Location = new System.Drawing.Point(31, 251);
            this.lbl_NgayTaoHD.Name = "lbl_NgayTaoHD";
            this.lbl_NgayTaoHD.Size = new System.Drawing.Size(123, 22);
            this.lbl_NgayTaoHD.TabIndex = 9;
            this.lbl_NgayTaoHD.Text = "Ngày Tạo HĐ:";
            // 
            // txt_TongThanhToan
            // 
            this.txt_TongThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TongThanhToan.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongThanhToan.Location = new System.Drawing.Point(243, 205);
            this.txt_TongThanhToan.Name = "txt_TongThanhToan";
            this.txt_TongThanhToan.ReadOnly = true;
            this.txt_TongThanhToan.Size = new System.Drawing.Size(219, 30);
            this.txt_TongThanhToan.TabIndex = 8;
            // 
            // lbl_TongThanhToan
            // 
            this.lbl_TongThanhToan.AutoSize = true;
            this.lbl_TongThanhToan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongThanhToan.Location = new System.Drawing.Point(31, 209);
            this.lbl_TongThanhToan.Name = "lbl_TongThanhToan";
            this.lbl_TongThanhToan.Size = new System.Drawing.Size(159, 22);
            this.lbl_TongThanhToan.TabIndex = 7;
            this.lbl_TongThanhToan.Text = "Tổng Thanh Toán:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(243, 159);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(219, 30);
            this.txt_TongTien.TabIndex = 6;
            // 
            // lbl_CanThanhToan
            // 
            this.lbl_CanThanhToan.AutoSize = true;
            this.lbl_CanThanhToan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CanThanhToan.Location = new System.Drawing.Point(31, 163);
            this.lbl_CanThanhToan.Name = "lbl_CanThanhToan";
            this.lbl_CanThanhToan.Size = new System.Drawing.Size(149, 22);
            this.lbl_CanThanhToan.TabIndex = 5;
            this.lbl_CanThanhToan.Text = "Cần Thanh Toán:";
            // 
            // txt_MaPhieuMuon
            // 
            this.txt_MaPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaPhieuMuon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhieuMuon.Location = new System.Drawing.Point(243, 116);
            this.txt_MaPhieuMuon.Name = "txt_MaPhieuMuon";
            this.txt_MaPhieuMuon.ReadOnly = true;
            this.txt_MaPhieuMuon.Size = new System.Drawing.Size(219, 30);
            this.txt_MaPhieuMuon.TabIndex = 4;
            // 
            // lnl_MaPhieuMuon
            // 
            this.lnl_MaPhieuMuon.AutoSize = true;
            this.lnl_MaPhieuMuon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_MaPhieuMuon.Location = new System.Drawing.Point(31, 120);
            this.lnl_MaPhieuMuon.Name = "lnl_MaPhieuMuon";
            this.lnl_MaPhieuMuon.Size = new System.Drawing.Size(145, 22);
            this.lnl_MaPhieuMuon.TabIndex = 3;
            this.lnl_MaPhieuMuon.Text = "Mã Phiếu Mượn:";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHoaDon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHoaDon.Location = new System.Drawing.Point(243, 74);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.ReadOnly = true;
            this.txt_MaHoaDon.Size = new System.Drawing.Size(219, 30);
            this.txt_MaHoaDon.TabIndex = 2;
            // 
            // lbl_MaHoaDon
            // 
            this.lbl_MaHoaDon.AutoSize = true;
            this.lbl_MaHoaDon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHoaDon.Location = new System.Drawing.Point(31, 78);
            this.lbl_MaHoaDon.Name = "lbl_MaHoaDon";
            this.lbl_MaHoaDon.Size = new System.Drawing.Size(117, 22);
            this.lbl_MaHoaDon.TabIndex = 1;
            this.lbl_MaHoaDon.Text = "Mã Hoá Đơn:";
            // 
            // pnl_DanhSachHoaDon
            // 
            this.pnl_DanhSachHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_DanhSachHoaDon.Controls.Add(this.dgv_DanhSachHoaDon);
            this.pnl_DanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_DanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnl_DanhSachHoaDon.Name = "pnl_DanhSachHoaDon";
            this.pnl_DanhSachHoaDon.Size = new System.Drawing.Size(1203, 966);
            this.pnl_DanhSachHoaDon.TabIndex = 0;
            // 
            // dgv_DanhSachHoaDon
            // 
            this.dgv_DanhSachHoaDon.AllowUserToAddRows = false;
            this.dgv_DanhSachHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_DanhSachHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHoaDon,
            this.col_TongTien,
            this.col_MaPhieuMuon,
            this.col_TongThanhToan,
            this.col_NgayTaoHoaDon,
            this.col_NgayThanhToan,
            this.col_GhiChu,
            this.col_TrangThai});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DanhSachHoaDon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_DanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachHoaDon.EnableHeadersVisualStyles = false;
            this.dgv_DanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhSachHoaDon.MultiSelect = false;
            this.dgv_DanhSachHoaDon.Name = "dgv_DanhSachHoaDon";
            this.dgv_DanhSachHoaDon.ReadOnly = true;
            this.dgv_DanhSachHoaDon.RowHeadersVisible = false;
            this.dgv_DanhSachHoaDon.RowHeadersWidth = 51;
            this.dgv_DanhSachHoaDon.Size = new System.Drawing.Size(1203, 966);
            this.dgv_DanhSachHoaDon.TabIndex = 0;
            this.dgv_DanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHoaDon_CellClick);
            // 
            // col_MaHoaDon
            // 
            this.col_MaHoaDon.HeaderText = "Mã HĐ";
            this.col_MaHoaDon.MinimumWidth = 6;
            this.col_MaHoaDon.Name = "col_MaHoaDon";
            this.col_MaHoaDon.ReadOnly = true;
            // 
            // col_TongTien
            // 
            this.col_TongTien.HeaderText = "Cần Thanh Toán";
            this.col_TongTien.MinimumWidth = 6;
            this.col_TongTien.Name = "col_TongTien";
            this.col_TongTien.ReadOnly = true;
            this.col_TongTien.Visible = false;
            // 
            // col_MaPhieuMuon
            // 
            this.col_MaPhieuMuon.HeaderText = "Mã PM";
            this.col_MaPhieuMuon.MinimumWidth = 6;
            this.col_MaPhieuMuon.Name = "col_MaPhieuMuon";
            this.col_MaPhieuMuon.ReadOnly = true;
            // 
            // col_TongThanhToan
            // 
            this.col_TongThanhToan.HeaderText = "Tổng Thanh Toán";
            this.col_TongThanhToan.MinimumWidth = 6;
            this.col_TongThanhToan.Name = "col_TongThanhToan";
            this.col_TongThanhToan.ReadOnly = true;
            // 
            // col_NgayTaoHoaDon
            // 
            this.col_NgayTaoHoaDon.HeaderText = "Ngày Tạo HĐ";
            this.col_NgayTaoHoaDon.MinimumWidth = 6;
            this.col_NgayTaoHoaDon.Name = "col_NgayTaoHoaDon";
            this.col_NgayTaoHoaDon.ReadOnly = true;
            // 
            // col_NgayThanhToan
            // 
            this.col_NgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.col_NgayThanhToan.MinimumWidth = 6;
            this.col_NgayThanhToan.Name = "col_NgayThanhToan";
            this.col_NgayThanhToan.ReadOnly = true;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.HeaderText = "Ghi Chú";
            this.col_GhiChu.MinimumWidth = 6;
            this.col_GhiChu.Name = "col_GhiChu";
            this.col_GhiChu.ReadOnly = true;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng Thái";
            this.col_TrangThai.MinimumWidth = 6;
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.ReadOnly = true;
            // 
            // frm_DanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1046);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_DanhSachHoaDon";
            this.Text = "frm_DanhSachHoaDon";
            this.Load += new System.EventHandler(this.frm_DanhSachHoaDon_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_ThongTin.ResumeLayout(false);
            this.pnl_ThongTin.PerformLayout();
            this.pnl_DanhSachHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_DanhSachPhieuMuon;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_ThongTin;
        private System.Windows.Forms.Panel pnl_DanhSachHoaDon;
        private System.Windows.Forms.DataGridView dgv_DanhSachHoaDon;
        private System.Windows.Forms.Label label8;
        private Button btn_Clear;
        private Button btn_Xoa;
        private Button btn_Sua;
        private TextBox txt_GhiChu;
        private Label lbl_GhiChu;
        private TextBox txt_NgayThanhToan;
        private Label lbl_NgayThanhToan;
        private TextBox txt_NgayTaoHoaDon;
        private Label lbl_NgayTaoHD;
        private TextBox txt_TongThanhToan;
        private Label lbl_TongThanhToan;
        private TextBox txt_TongTien;
        private Label lbl_CanThanhToan;
        private TextBox txt_MaPhieuMuon;
        private Label lnl_MaPhieuMuon;
        private TextBox txt_MaHoaDon;
        private Label lbl_MaHoaDon;
        private DataGridViewTextBoxColumn col_MaHoaDon;
        private DataGridViewTextBoxColumn col_TongTien;
        private DataGridViewTextBoxColumn col_MaPhieuMuon;
        private DataGridViewTextBoxColumn col_TongThanhToan;
        private DataGridViewTextBoxColumn col_NgayTaoHoaDon;
        private DataGridViewTextBoxColumn col_NgayThanhToan;
        private DataGridViewTextBoxColumn col_GhiChu;
        private DataGridViewTextBoxColumn col_TrangThai;
    }
}