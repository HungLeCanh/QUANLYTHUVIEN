namespace QLTV
{
    partial class frm_HoaDonThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Added controls
        private System.Windows.Forms.Label lbl_MaPhieu;
        private System.Windows.Forms.Label lbl_SoNgayMuon;
        private System.Windows.Forms.Label lbl_TienThanhToan;
        private System.Windows.Forms.DataGridView dgv_ChiTiet;
        private System.Windows.Forms.Button btn_Dong;

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
            this.lbl_MaPhieu = new System.Windows.Forms.Label();
            this.lbl_SoNgayMuon = new System.Windows.Forms.Label();
            this.lbl_TienThanhToan = new System.Windows.Forms.Label();
            this.dgv_ChiTiet = new System.Windows.Forms.DataGridView();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_XacNhanThanhToan = new System.Windows.Forms.Button();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaPhieu
            // 
            this.lbl_MaPhieu.AutoSize = true;
            this.lbl_MaPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_MaPhieu.Location = new System.Drawing.Point(30, 16);
            this.lbl_MaPhieu.Name = "lbl_MaPhieu";
            this.lbl_MaPhieu.Size = new System.Drawing.Size(90, 23);
            this.lbl_MaPhieu.TabIndex = 3;
            this.lbl_MaPhieu.Text = "Mã phiếu:";
            // 
            // lbl_SoNgayMuon
            // 
            this.lbl_SoNgayMuon.AutoSize = true;
            this.lbl_SoNgayMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_SoNgayMuon.Location = new System.Drawing.Point(30, 40);
            this.lbl_SoNgayMuon.Name = "lbl_SoNgayMuon";
            this.lbl_SoNgayMuon.Size = new System.Drawing.Size(139, 23);
            this.lbl_SoNgayMuon.TabIndex = 2;
            this.lbl_SoNgayMuon.Text = "Số ngày mượn: 0";
            // 
            // lbl_TienThanhToan
            // 
            this.lbl_TienThanhToan.AutoSize = true;
            this.lbl_TienThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_TienThanhToan.Location = new System.Drawing.Point(537, 295);
            this.lbl_TienThanhToan.Name = "lbl_TienThanhToan";
            this.lbl_TienThanhToan.Size = new System.Drawing.Size(172, 23);
            this.lbl_TienThanhToan.TabIndex = 1;
            this.lbl_TienThanhToan.Text = "Tiền thanh toán: 0 đ";
            // 
            // dgv_ChiTiet
            // 
            this.dgv_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTiet.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.col_TenSach,
            this.col_DonGiaMuon,
            this.col_ThanhTien});
            this.dgv_ChiTiet.Enabled = false;
            this.dgv_ChiTiet.Location = new System.Drawing.Point(30, 72);
            this.dgv_ChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_ChiTiet.Name = "dgv_ChiTiet";
            this.dgv_ChiTiet.ReadOnly = true;
            this.dgv_ChiTiet.RowHeadersWidth = 51;
            this.dgv_ChiTiet.RowTemplate.Height = 29;
            this.dgv_ChiTiet.Size = new System.Drawing.Size(740, 200);
            this.dgv_ChiTiet.TabIndex = 0;
            // 
            // col_MaSach
            // 
            this.col_MaSach.HeaderText = "Mã Sách";
            this.col_MaSach.MinimumWidth = 6;
            this.col_MaSach.Name = "col_MaSach";
            this.col_MaSach.ReadOnly = true;
            // 
            // col_TenSach
            // 
            this.col_TenSach.HeaderText = "Tên Sách";
            this.col_TenSach.MinimumWidth = 6;
            this.col_TenSach.Name = "col_TenSach";
            this.col_TenSach.ReadOnly = true;
            // 
            // col_DonGiaMuon
            // 
            this.col_DonGiaMuon.HeaderText = "Đơn Giá Mượn";
            this.col_DonGiaMuon.MinimumWidth = 6;
            this.col_DonGiaMuon.Name = "col_DonGiaMuon";
            this.col_DonGiaMuon.ReadOnly = true;
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.HeaderText = "Thành Tiền";
            this.col_ThanhTien.MinimumWidth = 6;
            this.col_ThanhTien.Name = "col_ThanhTien";
            this.col_ThanhTien.ReadOnly = true;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Dong.Location = new System.Drawing.Point(646, 446);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(120, 37);
            this.btn_Dong.TabIndex = 0;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_XacNhanThanhToan
            // 
            this.btn_XacNhanThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_XacNhanThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_XacNhanThanhToan.Location = new System.Drawing.Point(430, 443);
            this.btn_XacNhanThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XacNhanThanhToan.Name = "btn_XacNhanThanhToan";
            this.btn_XacNhanThanhToan.Size = new System.Drawing.Size(210, 40);
            this.btn_XacNhanThanhToan.TabIndex = 4;
            this.btn_XacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btn_XacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btn_XacNhanThanhToan.Click += new System.EventHandler(this.btn_XacNhanThanhToan_Click);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GhiChu.Location = new System.Drawing.Point(30, 360);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(340, 123);
            this.txt_GhiChu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ghi chú:";
            // 
            // frm_HoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.btn_XacNhanThanhToan);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.lbl_TienThanhToan);
            this.Controls.Add(this.dgv_ChiTiet);
            this.Controls.Add(this.lbl_SoNgayMuon);
            this.Controls.Add(this.lbl_MaPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_HoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.frm_HoaDonThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XacNhanThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label1;
    }
}