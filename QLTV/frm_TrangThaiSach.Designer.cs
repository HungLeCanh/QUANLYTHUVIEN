using System.Drawing;

namespace QLTV
{
    partial class frm_TrangThaiSach
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dgv_danhSachDocGia = new System.Windows.Forms.DataGridView();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.cbb_TheLoai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DonGiaMuon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamXuatBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).BeginInit();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel_Header.Controls.Add(this.lbl_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1477, 80);
            this.panel_Header.TabIndex = 13;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(25, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(272, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "📚 TRẠNG THÁI SÁCH";
            // 
            // dgv_danhSachDocGia
            // 
            this.dgv_danhSachDocGia.AllowUserToAddRows = false;
            this.dgv_danhSachDocGia.AllowUserToDeleteRows = false;
            this.dgv_danhSachDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhSachDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhSachDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_danhSachDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_danhSachDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_danhSachDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_danhSachDocGia.ColumnHeadersHeight = 40;
            this.dgv_danhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_danhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SDT,
            this.col_hoTen,
            this.col_email,
            this.col_diaChi,
            this.col_ngayDangKy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_danhSachDocGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_danhSachDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhSachDocGia.EnableHeadersVisualStyles = false;
            this.dgv_danhSachDocGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgv_danhSachDocGia.Location = new System.Drawing.Point(20, 20);
            this.dgv_danhSachDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhSachDocGia.MultiSelect = false;
            this.dgv_danhSachDocGia.Name = "dgv_danhSachDocGia";
            this.dgv_danhSachDocGia.RowHeadersVisible = false;
            this.dgv_danhSachDocGia.RowHeadersWidth = 62;
            this.dgv_danhSachDocGia.RowTemplate.Height = 35;
            this.dgv_danhSachDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhSachDocGia.Size = new System.Drawing.Size(1437, 652);
            this.dgv_danhSachDocGia.TabIndex = 5;
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "Số Điện thoại";
            this.col_SDT.MinimumWidth = 8;
            this.col_SDT.Name = "col_SDT";
            // 
            // col_hoTen
            // 
            this.col_hoTen.HeaderText = "Họ tên";
            this.col_hoTen.MinimumWidth = 8;
            this.col_hoTen.Name = "col_hoTen";
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 8;
            this.col_email.Name = "col_email";
            // 
            // col_diaChi
            // 
            this.col_diaChi.HeaderText = "Địa chỉ";
            this.col_diaChi.MinimumWidth = 8;
            this.col_diaChi.Name = "col_diaChi";
            // 
            // col_ngayDangKy
            // 
            this.col_ngayDangKy.HeaderText = "Ngày đăng ký";
            this.col_ngayDangKy.MinimumWidth = 8;
            this.col_ngayDangKy.Name = "col_ngayDangKy";
            this.col_ngayDangKy.ReadOnly = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(970, 15);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 45);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "🗑️ Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(830, 15);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 45);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "✏️ Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_Main.Controls.Add(this.cbb_TheLoai);
            this.panel_Main.Controls.Add(this.label6);
            this.panel_Main.Controls.Add(this.txt_DonGiaMuon);
            this.panel_Main.Controls.Add(this.label7);
            this.panel_Main.Controls.Add(this.label5);
            this.panel_Main.Controls.Add(this.txt_TenSach);
            this.panel_Main.Controls.Add(this.label1);
            this.panel_Main.Controls.Add(this.txt_TenTacGia);
            this.panel_Main.Controls.Add(this.label2);
            this.panel_Main.Controls.Add(this.txt_NhaXuatBan);
            this.panel_Main.Controls.Add(this.label3);
            this.panel_Main.Controls.Add(this.txt_NamXuatBan);
            this.panel_Main.Controls.Add(this.label4);
            this.panel_Main.Controls.Add(this.dataGridView1);
            this.panel_Main.Controls.Add(this.dgv_danhSachDocGia);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.panel_Main.Size = new System.Drawing.Size(1477, 692);
            this.panel_Main.TabIndex = 15;
            // 
            // cbb_TheLoai
            // 
            this.cbb_TheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TheLoai.FormattingEnabled = true;
            this.cbb_TheLoai.Items.AddRange(new object[] {
            "Văn học",
            "Khoa học - Kỹ thuật",
            "Tâm lý - Kỹ năng sống",
            "Kinh tế - Quản trị",
            "Lịch sử - Địa lý",
            "Thiếu nhi - Truyện tranh",
            "Ngoại ngữ",
            "Y học - Sức khỏe"});
            this.cbb_TheLoai.Location = new System.Drawing.Point(1033, 373);
            this.cbb_TheLoai.Name = "cbb_TheLoai";
            this.cbb_TheLoai.Size = new System.Drawing.Size(280, 28);
            this.cbb_TheLoai.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(1030, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thể loại";
            // 
            // txt_DonGiaMuon
            // 
            this.txt_DonGiaMuon.BackColor = System.Drawing.Color.White;
            this.txt_DonGiaMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGiaMuon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_DonGiaMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_DonGiaMuon.Location = new System.Drawing.Point(1032, 544);
            this.txt_DonGiaMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGiaMuon.Name = "txt_DonGiaMuon";
            this.txt_DonGiaMuon.Size = new System.Drawing.Size(280, 27);
            this.txt_DonGiaMuon.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(1028, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Đơn giá mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(1030, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tên sách";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.BackColor = System.Drawing.Color.White;
            this.txt_TenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_TenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_TenSach.Location = new System.Drawing.Point(1034, 155);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(280, 27);
            this.txt_TenSach.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(1030, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 14;
            // 
            // txt_TenTacGia
            // 
            this.txt_TenTacGia.BackColor = System.Drawing.Color.White;
            this.txt_TenTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTacGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_TenTacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_TenTacGia.Location = new System.Drawing.Point(1034, 215);
            this.txt_TenTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenTacGia.Name = "txt_TenTacGia";
            this.txt_TenTacGia.Size = new System.Drawing.Size(280, 27);
            this.txt_TenTacGia.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(1030, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên tác giả";
            // 
            // txt_NhaXuatBan
            // 
            this.txt_NhaXuatBan.BackColor = System.Drawing.Color.White;
            this.txt_NhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NhaXuatBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_NhaXuatBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_NhaXuatBan.Location = new System.Drawing.Point(1034, 284);
            this.txt_NhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NhaXuatBan.Name = "txt_NhaXuatBan";
            this.txt_NhaXuatBan.Size = new System.Drawing.Size(280, 27);
            this.txt_NhaXuatBan.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(1030, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhà xuất bản";
            // 
            // txt_NamXuatBan
            // 
            this.txt_NamXuatBan.BackColor = System.Drawing.Color.White;
            this.txt_NamXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NamXuatBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_NamXuatBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_NamXuatBan.Location = new System.Drawing.Point(1032, 456);
            this.txt_NamXuatBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NamXuatBan.Name = "txt_NamXuatBan";
            this.txt_NamXuatBan.Size = new System.Drawing.Size(280, 27);
            this.txt_NamXuatBan.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(1030, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Năm xuất bản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.col_TenSach,
            this.col_TenTacGia,
            this.col_TheLoai,
            this.col_NhaXuatBan,
            this.col_NamXuatBan,
            this.col_DonGia,
            this.col_TrangThai});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 536);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_Controls.Controls.Add(this.btn_Xoa);
            this.panel_Controls.Controls.Add(this.btn_Sua);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(0, 692);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1477, 80);
            this.panel_Controls.TabIndex = 14;
            // 
            // col_MaSach
            // 
            this.col_MaSach.FillWeight = 9.53179F;
            this.col_MaSach.HeaderText = "Mã Sách";
            this.col_MaSach.MinimumWidth = 8;
            this.col_MaSach.Name = "col_MaSach";
            this.col_MaSach.ReadOnly = true;
            // 
            // col_TenSach
            // 
            this.col_TenSach.FillWeight = 4.765895F;
            this.col_TenSach.HeaderText = "Tên Sách";
            this.col_TenSach.Name = "col_TenSach";
            this.col_TenSach.ReadOnly = true;
            // 
            // col_TenTacGia
            // 
            this.col_TenTacGia.FillWeight = 4.765895F;
            this.col_TenTacGia.HeaderText = "Tên Tác giả";
            this.col_TenTacGia.Name = "col_TenTacGia";
            this.col_TenTacGia.ReadOnly = true;
            // 
            // col_TheLoai
            // 
            this.col_TheLoai.FillWeight = 4.765895F;
            this.col_TheLoai.HeaderText = "Thể Loại";
            this.col_TheLoai.Name = "col_TheLoai";
            this.col_TheLoai.ReadOnly = true;
            // 
            // col_NhaXuatBan
            // 
            this.col_NhaXuatBan.FillWeight = 4.765895F;
            this.col_NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.col_NhaXuatBan.Name = "col_NhaXuatBan";
            this.col_NhaXuatBan.ReadOnly = true;
            // 
            // col_NamXuatBan
            // 
            this.col_NamXuatBan.FillWeight = 159.5321F;
            this.col_NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.col_NamXuatBan.Name = "col_NamXuatBan";
            this.col_NamXuatBan.ReadOnly = true;
            // 
            // col_DonGia
            // 
            this.col_DonGia.FillWeight = 4.765895F;
            this.col_DonGia.HeaderText = "Đơn Giá";
            this.col_DonGia.Name = "col_DonGia";
            this.col_DonGia.ReadOnly = true;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.FillWeight = 807.1067F;
            this.col_TrangThai.HeaderText = "Trạng Thái";
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.ReadOnly = true;
            // 
            // frm_TrangThaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 772);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Controls);
            this.Name = "frm_TrangThaiSach";
            this.Text = "frm_TrangThaiSach";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).EndInit();
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView dgv_danhSachDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayDangKy;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.ComboBox cbb_TheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DonGiaMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NhaXuatBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NamXuatBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
    }
}