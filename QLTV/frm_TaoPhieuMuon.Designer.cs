namespace QLTV
{
    partial class frm_TaoPhieuMuon
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grp_ThongTinDocGia = new System.Windows.Forms.GroupBox();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.btn_TimDocGia = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.grp_ThongTinPhieuMuon = new System.Windows.Forms.GroupBox();
            this.lbl_NgayMuon = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayTraDuKien = new System.Windows.Forms.Label();
            this.dtp_NgayTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.grp_DanhSachSach = new System.Windows.Forms.GroupBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_Sach = new System.Windows.Forms.DataGridView();
            this.col_Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_SachDaChon = new System.Windows.Forms.GroupBox();
            this.dgv_SachDaChon = new System.Windows.Forms.DataGridView();
            this.col_MaSachDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSachDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaMuonDaChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.btn_TaoPhieuMuon = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.grp_ThongTinDocGia.SuspendLayout();
            this.grp_ThongTinPhieuMuon.SuspendLayout();
            this.grp_DanhSachSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).BeginInit();
            this.grp_SachDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SachDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(533, 25);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(265, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "TẠO PHIẾU MƯỢN";
            // 
            // grp_ThongTinDocGia
            // 
            this.grp_ThongTinDocGia.Controls.Add(this.lbl_SoDienThoai);
            this.grp_ThongTinDocGia.Controls.Add(this.txt_SoDienThoai);
            this.grp_ThongTinDocGia.Controls.Add(this.btn_TimDocGia);
            this.grp_ThongTinDocGia.Controls.Add(this.lblHoTen);
            this.grp_ThongTinDocGia.Controls.Add(this.txtHoTen);
            this.grp_ThongTinDocGia.Controls.Add(this.lbl_Email);
            this.grp_ThongTinDocGia.Controls.Add(this.txt_Email);
            this.grp_ThongTinDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinDocGia.Location = new System.Drawing.Point(27, 74);
            this.grp_ThongTinDocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_ThongTinDocGia.Name = "grp_ThongTinDocGia";
            this.grp_ThongTinDocGia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_ThongTinDocGia.Size = new System.Drawing.Size(640, 185);
            this.grp_ThongTinDocGia.TabIndex = 1;
            this.grp_ThongTinDocGia.TabStop = false;
            this.grp_ThongTinDocGia.Text = "Thông tin độc giả";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(27, 37);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(98, 18);
            this.lbl_SoDienThoai.TabIndex = 0;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(160, 33);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(199, 24);
            this.txt_SoDienThoai.TabIndex = 1;
            // 
            // btn_TimDocGia
            // 
            this.btn_TimDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimDocGia.Location = new System.Drawing.Point(387, 31);
            this.btn_TimDocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimDocGia.Name = "btn_TimDocGia";
            this.btn_TimDocGia.Size = new System.Drawing.Size(107, 31);
            this.btn_TimDocGia.TabIndex = 2;
            this.btn_TimDocGia.Text = "Tìm";
            this.btn_TimDocGia.UseVisualStyleBackColor = true;
            this.btn_TimDocGia.Click += new System.EventHandler(this.btn_TimDocGia_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(27, 86);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(56, 18);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(160, 82);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(265, 24);
            this.txtHoTen.TabIndex = 4;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(27, 135);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 18);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(160, 132);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(265, 24);
            this.txt_Email.TabIndex = 6;
            // 
            // grp_ThongTinPhieuMuon
            // 
            this.grp_ThongTinPhieuMuon.Controls.Add(this.lbl_NgayMuon);
            this.grp_ThongTinPhieuMuon.Controls.Add(this.dtp_NgayMuon);
            this.grp_ThongTinPhieuMuon.Controls.Add(this.lbl_NgayTraDuKien);
            this.grp_ThongTinPhieuMuon.Controls.Add(this.dtp_NgayTraDuKien);
            this.grp_ThongTinPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinPhieuMuon.Location = new System.Drawing.Point(693, 74);
            this.grp_ThongTinPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_ThongTinPhieuMuon.Name = "grp_ThongTinPhieuMuon";
            this.grp_ThongTinPhieuMuon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_ThongTinPhieuMuon.Size = new System.Drawing.Size(533, 185);
            this.grp_ThongTinPhieuMuon.TabIndex = 2;
            this.grp_ThongTinPhieuMuon.TabStop = false;
            this.grp_ThongTinPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // lbl_NgayMuon
            // 
            this.lbl_NgayMuon.AutoSize = true;
            this.lbl_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayMuon.Location = new System.Drawing.Point(27, 62);
            this.lbl_NgayMuon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayMuon.Name = "lbl_NgayMuon";
            this.lbl_NgayMuon.Size = new System.Drawing.Size(88, 18);
            this.lbl_NgayMuon.TabIndex = 0;
            this.lbl_NgayMuon.Text = "Ngày mượn:";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(187, 58);
            this.dtp_NgayMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(199, 24);
            this.dtp_NgayMuon.TabIndex = 1;
            // 
            // lbl_NgayTraDuKien
            // 
            this.lbl_NgayTraDuKien.AutoSize = true;
            this.lbl_NgayTraDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTraDuKien.Location = new System.Drawing.Point(27, 111);
            this.lbl_NgayTraDuKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayTraDuKien.Name = "lbl_NgayTraDuKien";
            this.lbl_NgayTraDuKien.Size = new System.Drawing.Size(118, 18);
            this.lbl_NgayTraDuKien.TabIndex = 2;
            this.lbl_NgayTraDuKien.Text = "Ngày trả dự kiến:";
            // 
            // dtp_NgayTraDuKien
            // 
            this.dtp_NgayTraDuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTraDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTraDuKien.Location = new System.Drawing.Point(187, 107);
            this.dtp_NgayTraDuKien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayTraDuKien.Name = "dtp_NgayTraDuKien";
            this.dtp_NgayTraDuKien.Size = new System.Drawing.Size(199, 24);
            this.dtp_NgayTraDuKien.TabIndex = 3;
            // 
            // grp_DanhSachSach
            // 
            this.grp_DanhSachSach.Controls.Add(this.lbl_TimKiem);
            this.grp_DanhSachSach.Controls.Add(this.txt_TimKiem);
            this.grp_DanhSachSach.Controls.Add(this.btn_TimKiem);
            this.grp_DanhSachSach.Controls.Add(this.dgv_Sach);
            this.grp_DanhSachSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DanhSachSach.Location = new System.Drawing.Point(27, 283);
            this.grp_DanhSachSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_DanhSachSach.Name = "grp_DanhSachSach";
            this.grp_DanhSachSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_DanhSachSach.Size = new System.Drawing.Size(1200, 369);
            this.grp_DanhSachSach.TabIndex = 3;
            this.grp_DanhSachSach.TabStop = false;
            this.grp_DanhSachSach.Text = "Danh sách sách có thể mượn";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(27, 37);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(173, 18);
            this.lbl_TimKiem.TabIndex = 0;
            this.lbl_TimKiem.Text = "Tìm kiếm (Tên/Mã sách):";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(227, 33);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(332, 24);
            this.txt_TimKiem.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(587, 31);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(107, 31);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_Sach
            // 
            this.dgv_Sach.AllowUserToAddRows = false;
            this.dgv_Sach.AllowUserToDeleteRows = false;
            this.dgv_Sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Chon,
            this.col_MaSach,
            this.col_TenSach,
            this.col_TacGia,
            this.col_NhaXuatBan,
            this.col_NamXuatBan,
            this.col_TheLoai,
            this.col_DonGiaMuon,
            this.col_TrangThai});
            this.dgv_Sach.Location = new System.Drawing.Point(27, 74);
            this.dgv_Sach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Sach.Name = "dgv_Sach";
            this.dgv_Sach.RowHeadersWidth = 51;
            this.dgv_Sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sach.Size = new System.Drawing.Size(1147, 271);
            this.dgv_Sach.TabIndex = 3;
            this.dgv_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sach_CellContentClick);
            // 
            // col_Chon
            // 
            this.col_Chon.HeaderText = "Chọn";
            this.col_Chon.MinimumWidth = 6;
            this.col_Chon.Name = "col_Chon";
            // 
            // col_MaSach
            // 
            this.col_MaSach.HeaderText = "Mã sách";
            this.col_MaSach.MinimumWidth = 6;
            this.col_MaSach.Name = "col_MaSach";
            this.col_MaSach.ReadOnly = true;
            // 
            // col_TenSach
            // 
            this.col_TenSach.HeaderText = "Tên sách";
            this.col_TenSach.MinimumWidth = 6;
            this.col_TenSach.Name = "col_TenSach";
            this.col_TenSach.ReadOnly = true;
            // 
            // col_TacGia
            // 
            this.col_TacGia.HeaderText = "Tác giả";
            this.col_TacGia.MinimumWidth = 6;
            this.col_TacGia.Name = "col_TacGia";
            this.col_TacGia.ReadOnly = true;
            // 
            // col_NhaXuatBan
            // 
            this.col_NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.col_NhaXuatBan.MinimumWidth = 6;
            this.col_NhaXuatBan.Name = "col_NhaXuatBan";
            this.col_NhaXuatBan.ReadOnly = true;
            // 
            // col_NamXuatBan
            // 
            this.col_NamXuatBan.HeaderText = "Năm XB";
            this.col_NamXuatBan.MinimumWidth = 6;
            this.col_NamXuatBan.Name = "col_NamXuatBan";
            this.col_NamXuatBan.ReadOnly = true;
            // 
            // col_TheLoai
            // 
            this.col_TheLoai.HeaderText = "Thể loại";
            this.col_TheLoai.MinimumWidth = 6;
            this.col_TheLoai.Name = "col_TheLoai";
            this.col_TheLoai.ReadOnly = true;
            // 
            // col_DonGiaMuon
            // 
            this.col_DonGiaMuon.HeaderText = "Đơn giá mượn";
            this.col_DonGiaMuon.MinimumWidth = 6;
            this.col_DonGiaMuon.Name = "col_DonGiaMuon";
            this.col_DonGiaMuon.ReadOnly = true;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng thái";
            this.col_TrangThai.MinimumWidth = 6;
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.ReadOnly = true;
            // 
            // grp_SachDaChon
            // 
            this.grp_SachDaChon.Controls.Add(this.dgv_SachDaChon);
            this.grp_SachDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_SachDaChon.Location = new System.Drawing.Point(27, 677);
            this.grp_SachDaChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_SachDaChon.Name = "grp_SachDaChon";
            this.grp_SachDaChon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_SachDaChon.Size = new System.Drawing.Size(1200, 246);
            this.grp_SachDaChon.TabIndex = 4;
            this.grp_SachDaChon.TabStop = false;
            this.grp_SachDaChon.Text = "Sách đã chọn";
            // 
            // dgv_SachDaChon
            // 
            this.dgv_SachDaChon.AllowUserToAddRows = false;
            this.dgv_SachDaChon.AllowUserToDeleteRows = false;
            this.dgv_SachDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SachDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SachDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSachDaChon,
            this.col_TenSachDaChon,
            this.col_DonGiaMuonDaChon,
            this.col_ThanhTien,
            this.col_Xoa});
            this.dgv_SachDaChon.Location = new System.Drawing.Point(27, 37);
            this.dgv_SachDaChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_SachDaChon.Name = "dgv_SachDaChon";
            this.dgv_SachDaChon.ReadOnly = true;
            this.dgv_SachDaChon.RowHeadersWidth = 51;
            this.dgv_SachDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SachDaChon.Size = new System.Drawing.Size(1147, 185);
            this.dgv_SachDaChon.TabIndex = 0;
            this.dgv_SachDaChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SachDaChon_CellContentClick);
            // 
            // col_MaSachDaChon
            // 
            this.col_MaSachDaChon.HeaderText = "Mã sách";
            this.col_MaSachDaChon.MinimumWidth = 6;
            this.col_MaSachDaChon.Name = "col_MaSachDaChon";
            this.col_MaSachDaChon.ReadOnly = true;
            // 
            // col_TenSachDaChon
            // 
            this.col_TenSachDaChon.HeaderText = "Tên sách";
            this.col_TenSachDaChon.MinimumWidth = 6;
            this.col_TenSachDaChon.Name = "col_TenSachDaChon";
            this.col_TenSachDaChon.ReadOnly = true;
            // 
            // col_DonGiaMuonDaChon
            // 
            this.col_DonGiaMuonDaChon.HeaderText = "Đơn giá mượn";
            this.col_DonGiaMuonDaChon.MinimumWidth = 6;
            this.col_DonGiaMuonDaChon.Name = "col_DonGiaMuonDaChon";
            this.col_DonGiaMuonDaChon.ReadOnly = true;
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.HeaderText = "Thành tiền";
            this.col_ThanhTien.MinimumWidth = 6;
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // col_Xoa
            // 
            this.col_Xoa.HeaderText = "Xóa";
            this.col_Xoa.MinimumWidth = 6;
            this.col_Xoa.Name = "col_Xoa";
            this.col_Xoa.ReadOnly = true;
            this.col_Xoa.Text = "Xóa";
            this.col_Xoa.UseColumnTextForButtonValue = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(867, 948);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(110, 25);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(1000, 944);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(199, 30);
            this.txt_TongTien.TabIndex = 6;
            this.txt_TongTien.Text = "0";
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_TaoPhieuMuon
            // 
            this.btn_TaoPhieuMuon.BackColor = System.Drawing.Color.LightGreen;
            this.btn_TaoPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuMuon.Location = new System.Drawing.Point(400, 997);
            this.btn_TaoPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TaoPhieuMuon.Name = "btn_TaoPhieuMuon";
            this.btn_TaoPhieuMuon.Size = new System.Drawing.Size(187, 43);
            this.btn_TaoPhieuMuon.TabIndex = 7;
            this.btn_TaoPhieuMuon.Text = "Tạo phiếu mượn";
            this.btn_TaoPhieuMuon.UseVisualStyleBackColor = false;
            this.btn_TaoPhieuMuon.Click += new System.EventHandler(this.btn_TaoPhieuMuon_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(613, 997);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(133, 43);
            this.btn_Huy.TabIndex = 8;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.LightBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(773, 997);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(133, 43);
            this.btn_LamMoi.TabIndex = 9;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // frm_TaoPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1267, 1071);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_TaoPhieuMuon);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.grp_SachDaChon);
            this.Controls.Add(this.grp_DanhSachSach);
            this.Controls.Add(this.grp_ThongTinPhieuMuon);
            this.Controls.Add(this.grp_ThongTinDocGia);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_TaoPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Phiếu Mượn";
            this.Load += new System.EventHandler(this.frm_TaoPhieuMuon_Load);
            this.grp_ThongTinDocGia.ResumeLayout(false);
            this.grp_ThongTinDocGia.PerformLayout();
            this.grp_ThongTinPhieuMuon.ResumeLayout(false);
            this.grp_ThongTinPhieuMuon.PerformLayout();
            this.grp_DanhSachSach.ResumeLayout(false);
            this.grp_DanhSachSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sach)).EndInit();
            this.grp_SachDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SachDaChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grp_ThongTinDocGia;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Button btn_TimDocGia;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.GroupBox grp_ThongTinPhieuMuon;
        private System.Windows.Forms.Label lbl_NgayMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label lbl_NgayTraDuKien;
        private System.Windows.Forms.DateTimePicker dtp_NgayTraDuKien;
        private System.Windows.Forms.GroupBox grp_DanhSachSach;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_Sach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
        private System.Windows.Forms.GroupBox grp_SachDaChon;
        private System.Windows.Forms.DataGridView dgv_SachDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSachDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSachDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaMuonDaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn col_Xoa;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_TaoPhieuMuon;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}