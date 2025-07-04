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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            this.panel_Main.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
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
            this.dgv_danhSachDocGia.ReadOnly = false;
            this.dgv_danhSachDocGia.RowHeadersVisible = false;
            this.dgv_danhSachDocGia.RowHeadersWidth = 62;
            this.dgv_danhSachDocGia.RowTemplate.Height = 35;
            this.dgv_danhSachDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhSachDocGia.Size = new System.Drawing.Size(1058, 451);
            this.dgv_danhSachDocGia.TabIndex = 5;
            this.dgv_danhSachDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhSachDocGia_CellContentClick);
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "Số Điện thoại";
            this.col_SDT.MinimumWidth = 8;
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = false;
            // 
            // col_hoTen
            // 
            this.col_hoTen.HeaderText = "Họ tên";
            this.col_hoTen.MinimumWidth = 8;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.ReadOnly = false;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 8;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = false;
            // 
            // col_diaChi
            // 
            this.col_diaChi.HeaderText = "Địa chỉ";
            this.col_diaChi.MinimumWidth = 8;
            this.col_diaChi.Name = "col_diaChi";
            this.col_diaChi.ReadOnly = false;
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
            this.btn_LamMoi.Location = new System.Drawing.Point(731, 15);
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
            this.btn_Xoa.Location = new System.Drawing.Point(591, 15);
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
            this.btn_Sua.Location = new System.Drawing.Point(451, 15);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 45);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "✏️ Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel_Header.Controls.Add(this.lbl_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1098, 80);
            this.panel_Header.TabIndex = 10;
            this.panel_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Header_Paint);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(25, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(378, 41);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "📚 DANH SÁCH ĐỘC GIẢ";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_Controls.Controls.Add(this.btn_LamMoi);
            this.panel_Controls.Controls.Add(this.btn_Xoa);
            this.panel_Controls.Controls.Add(this.btn_Sua);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(0, 571);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1098, 80);
            this.panel_Controls.TabIndex = 11;
            this.panel_Controls.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Controls_Paint);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_Main.Controls.Add(this.dgv_danhSachDocGia);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 80);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.panel_Main.Size = new System.Drawing.Size(1098, 491);
            this.panel_Main.TabIndex = 12;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // frm_DanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 651);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frm_DanhSachDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thư viện - Danh sách Độc giả";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
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
    }
}