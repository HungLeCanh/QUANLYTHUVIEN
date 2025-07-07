namespace QLTV
{
    partial class frm_DanhSachDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_danhSachDocGia = new System.Windows.Forms.DataGridView();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.grp_ThongTin.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_danhSachDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_danhSachDocGia.ColumnHeadersHeight = 40;
            this.dgv_danhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_danhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SDT,
            this.col_hoTen,
            this.col_email,
            this.col_diaChi,
            this.col_ngayDangKy});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_danhSachDocGia.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.dgv_danhSachDocGia.Size = new System.Drawing.Size(1409, 308);
            this.dgv_danhSachDocGia.TabIndex = 5;
            this.dgv_danhSachDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhSachDocGia_CellClick);
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
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(1082, 15);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(120, 45);
            this.btn_LamMoi.TabIndex = 9;
            this.btn_LamMoi.Text = "🔄 Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(942, 15);
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
            this.btn_Sua.Location = new System.Drawing.Point(802, 15);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 45);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "✏️ Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel_Header.Controls.Add(this.panel_Search);
            this.panel_Header.Controls.Add(this.lbl_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1449, 80);
            this.panel_Header.TabIndex = 10;
            // 
            // panel_Search
            // 
            this.panel_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Search.Controls.Add(this.txt_TimKiem);
            this.panel_Search.Controls.Add(this.btn_TimKiem);
            this.panel_Search.Location = new System.Drawing.Point(950, 20);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(470, 40);
            this.panel_Search.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(370, 31);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.Text = "Số điện thoại";
            this.txt_TimKiem.Enter += new System.EventHandler(this.txt_TimKiem_Enter);
            this.txt_TimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TimKiem_KeyDown);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(376, 0);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 31);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "🔍 Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(25, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(447, 48);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "📚 DANH SÁCH ĐỘC GIẢ";
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_Controls.Controls.Add(this.btn_LamMoi);
            this.panel_Controls.Controls.Add(this.btn_Xoa);
            this.panel_Controls.Controls.Add(this.btn_Sua);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(0, 578);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1449, 67);
            this.panel_Controls.TabIndex = 11;
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_Main.Controls.Add(this.dgv_danhSachDocGia);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 80);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.panel_Main.Size = new System.Drawing.Size(1449, 348);
            this.panel_Main.TabIndex = 12;
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grp_ThongTin.Controls.Add(this.lbl_SDT);
            this.grp_ThongTin.Controls.Add(this.lbl_HoTen);
            this.grp_ThongTin.Controls.Add(this.lbl_Email);
            this.grp_ThongTin.Controls.Add(this.lbl_DiaChi);
            this.grp_ThongTin.Controls.Add(this.txt_SDT);
            this.grp_ThongTin.Controls.Add(this.txt_HoTen);
            this.grp_ThongTin.Controls.Add(this.txt_Email);
            this.grp_ThongTin.Controls.Add(this.txt_DiaChi);
            this.grp_ThongTin.Controls.Add(this.btn_Huy);
            this.grp_ThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_ThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grp_ThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.grp_ThongTin.Location = new System.Drawing.Point(0, 428);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(1449, 150);
            this.grp_ThongTin.TabIndex = 13;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông tin độc giả";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_SDT.Location = new System.Drawing.Point(30, 35);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(121, 25);
            this.lbl_SDT.TabIndex = 0;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_HoTen.Location = new System.Drawing.Point(30, 70);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(70, 25);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ tên:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_Email.Location = new System.Drawing.Point(30, 105);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(58, 25);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbl_DiaChi.Location = new System.Drawing.Point(500, 35);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(69, 25);
            this.lbl_DiaChi.TabIndex = 3;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SDT.Enabled = false;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.Location = new System.Drawing.Point(155, 32);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(320, 31);
            this.txt_SDT.TabIndex = 5;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTen.Location = new System.Drawing.Point(155, 67);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(320, 31);
            this.txt_HoTen.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.Location = new System.Drawing.Point(155, 102);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(320, 31);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.Location = new System.Drawing.Point(630, 32);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(320, 31);
            this.txt_DiaChi.TabIndex = 8;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(1124, 70);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(90, 40);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "❌ Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_DanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 645);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frm_DanhSachDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thư viện - Danh sách Độc giả";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_danhSachDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayDangKy;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Panel panel_Main;

        // New controls
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_Huy;

        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Panel panel_Search;
    }
}