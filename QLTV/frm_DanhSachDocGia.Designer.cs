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
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhSachDocGia
            // 
            this.dgv_danhSachDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhSachDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSachDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SDT,
            this.col_hoTen,
            this.col_email,
            this.col_diaChi,
            this.col_ngayDangKy});
            this.dgv_danhSachDocGia.Location = new System.Drawing.Point(12, 66);
            this.dgv_danhSachDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_danhSachDocGia.Name = "dgv_danhSachDocGia";
            this.dgv_danhSachDocGia.RowHeadersWidth = 62;
            this.dgv_danhSachDocGia.RowTemplate.Height = 28;
            this.dgv_danhSachDocGia.Size = new System.Drawing.Size(1074, 242);
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
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(633, 363);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(109, 38);
            this.btn_LamMoi.TabIndex = 9;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(461, 363);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 38);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(295, 363);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(109, 38);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // frm_DanhSachDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 651);
            this.Controls.Add(this.dgv_danhSachDocGia);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
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
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}