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
            this.dgv_danhSachDocGia = new System.Windows.Forms.DataGridView();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhSachDocGia
            // 
            this.dgv_danhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SDT,
            this.col_hoTen,
            this.col_email,
            this.col_diaChi,
            this.col_ngayDangKy});
            this.dgv_danhSachDocGia.Location = new System.Drawing.Point(34, 26);
            this.dgv_danhSachDocGia.Name = "dgv_danhSachDocGia";
            this.dgv_danhSachDocGia.RowHeadersWidth = 62;
            this.dgv_danhSachDocGia.RowTemplate.Height = 28;
            this.dgv_danhSachDocGia.Size = new System.Drawing.Size(1076, 303);
            this.dgv_danhSachDocGia.TabIndex = 0;
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "Số Điện thoại";
            this.col_SDT.MinimumWidth = 8;
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.Width = 150;
            // 
            // col_hoTen
            // 
            this.col_hoTen.HeaderText = "Họ tên";
            this.col_hoTen.MinimumWidth = 8;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.Width = 150;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 8;
            this.col_email.Name = "col_email";
            this.col_email.Width = 150;
            // 
            // col_diaChi
            // 
            this.col_diaChi.HeaderText = "Địa chỉ";
            this.col_diaChi.MinimumWidth = 8;
            this.col_diaChi.Name = "col_diaChi";
            this.col_diaChi.Width = 150;
            // 
            // col_ngayDangKy
            // 
            this.col_ngayDangKy.HeaderText = "Ngày đăng ký";
            this.col_ngayDangKy.MinimumWidth = 8;
            this.col_ngayDangKy.Name = "col_ngayDangKy";
            this.col_ngayDangKy.Width = 150;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(173, 387);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(123, 48);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(396, 387);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 48);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(626, 387);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(123, 48);
            this.btn_lamMoi.TabIndex = 4;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // frm_DanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 578);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.dgv_danhSachDocGia);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DanhSachDocGia";
            this.Text = "frm_DanhSachDocGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_danhSachDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayDangKy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}