namespace QLTV
{
    partial class frm_HoaDonThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Added controls
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Label lbl_MaPhieu;
        private System.Windows.Forms.Label lbl_SoNgayMuon;
        private System.Windows.Forms.Panel pnl_ChiTiet;
        private System.Windows.Forms.Label lbl_ChiTietTitle;
        private System.Windows.Forms.DataGridView dgv_ChiTiet;
        private System.Windows.Forms.Panel pnl_ThanhToan;
        private System.Windows.Forms.Label lbl_TienThanhToan;
        private System.Windows.Forms.Panel pnl_GhiChu;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label lbl_GhiChu;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_XacNhanThanhToan;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lbl_MaPhieu = new System.Windows.Forms.Label();
            this.lbl_SoNgayMuon = new System.Windows.Forms.Label();
            this.pnl_ChiTiet = new System.Windows.Forms.Panel();
            this.lbl_ChiTietTitle = new System.Windows.Forms.Label();
            this.dgv_ChiTiet = new System.Windows.Forms.DataGridView();
            this.col_MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGiaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_ThanhToan = new System.Windows.Forms.Panel();
            this.lbl_TienThanhToan = new System.Windows.Forms.Label();
            this.pnl_GhiChu = new System.Windows.Forms.Panel();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_XacNhanThanhToan = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.pnl_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).BeginInit();
            this.pnl_ThanhToan.SuspendLayout();
            this.pnl_GhiChu.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(900, 60);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(20, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // pnl_Info
            // 
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Info.Controls.Add(this.lbl_MaPhieu);
            this.pnl_Info.Controls.Add(this.lbl_SoNgayMuon);
            this.pnl_Info.Location = new System.Drawing.Point(20, 80);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_Info.Size = new System.Drawing.Size(860, 70);
            this.pnl_Info.TabIndex = 1;
            // 
            // lbl_MaPhieu
            // 
            this.lbl_MaPhieu.AutoSize = true;
            this.lbl_MaPhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_MaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_MaPhieu.Location = new System.Drawing.Point(15, 10);
            this.lbl_MaPhieu.Name = "lbl_MaPhieu";
            this.lbl_MaPhieu.Size = new System.Drawing.Size(105, 25);
            this.lbl_MaPhieu.TabIndex = 0;
            this.lbl_MaPhieu.Text = "Mã phiếu: ";
            // 
            // lbl_SoNgayMuon
            // 
            this.lbl_SoNgayMuon.AutoSize = true;
            this.lbl_SoNgayMuon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_SoNgayMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_SoNgayMuon.Location = new System.Drawing.Point(15, 35);
            this.lbl_SoNgayMuon.Name = "lbl_SoNgayMuon";
            this.lbl_SoNgayMuon.Size = new System.Drawing.Size(152, 25);
            this.lbl_SoNgayMuon.TabIndex = 1;
            this.lbl_SoNgayMuon.Text = "Số ngày mượn: 0";
            // 
            // pnl_ChiTiet
            // 
            this.pnl_ChiTiet.BackColor = System.Drawing.Color.White;
            this.pnl_ChiTiet.Controls.Add(this.lbl_ChiTietTitle);
            this.pnl_ChiTiet.Controls.Add(this.dgv_ChiTiet);
            this.pnl_ChiTiet.Location = new System.Drawing.Point(20, 170);
            this.pnl_ChiTiet.Name = "pnl_ChiTiet";
            this.pnl_ChiTiet.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_ChiTiet.Size = new System.Drawing.Size(860, 250);
            this.pnl_ChiTiet.TabIndex = 2;
            // 
            // lbl_ChiTietTitle
            // 
            this.lbl_ChiTietTitle.AutoSize = true;
            this.lbl_ChiTietTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ChiTietTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_ChiTietTitle.Location = new System.Drawing.Point(15, 10);
            this.lbl_ChiTietTitle.Name = "lbl_ChiTietTitle";
            this.lbl_ChiTietTitle.Size = new System.Drawing.Size(191, 28);
            this.lbl_ChiTietTitle.TabIndex = 0;
            this.lbl_ChiTietTitle.Text = "Chi tiết thanh toán";
            // 
            // dgv_ChiTiet
            // 
            this.dgv_ChiTiet.AllowUserToAddRows = false;
            this.dgv_ChiTiet.AllowUserToDeleteRows = false;
            this.dgv_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ChiTiet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ChiTiet.ColumnHeadersHeight = 40;
            this.dgv_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaSach,
            this.col_TenSach,
            this.col_DonGiaMuon,
            this.col_ThanhTien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ChiTiet.EnableHeadersVisualStyles = false;
            this.dgv_ChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_ChiTiet.Location = new System.Drawing.Point(15, 40);
            this.dgv_ChiTiet.Name = "dgv_ChiTiet";
            this.dgv_ChiTiet.ReadOnly = true;
            this.dgv_ChiTiet.RowHeadersVisible = false;
            this.dgv_ChiTiet.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgv_ChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ChiTiet.RowTemplate.Height = 35;
            this.dgv_ChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTiet.Size = new System.Drawing.Size(830, 195);
            this.dgv_ChiTiet.TabIndex = 1;
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
            // pnl_ThanhToan
            // 
            this.pnl_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnl_ThanhToan.Controls.Add(this.lbl_TienThanhToan);
            this.pnl_ThanhToan.Location = new System.Drawing.Point(524, 440);
            this.pnl_ThanhToan.Name = "pnl_ThanhToan";
            this.pnl_ThanhToan.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_ThanhToan.Size = new System.Drawing.Size(356, 50);
            this.pnl_ThanhToan.TabIndex = 3;
            // 
            // lbl_TienThanhToan
            // 
            this.lbl_TienThanhToan.AutoSize = true;
            this.lbl_TienThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TienThanhToan.ForeColor = System.Drawing.Color.White;
            this.lbl_TienThanhToan.Location = new System.Drawing.Point(6, 10);
            this.lbl_TienThanhToan.Name = "lbl_TienThanhToan";
            this.lbl_TienThanhToan.Size = new System.Drawing.Size(205, 28);
            this.lbl_TienThanhToan.TabIndex = 0;
            this.lbl_TienThanhToan.Text = "Tiền thanh toán: 0 đ";
            // 
            // pnl_GhiChu
            // 
            this.pnl_GhiChu.BackColor = System.Drawing.Color.White;
            this.pnl_GhiChu.Controls.Add(this.lbl_GhiChu);
            this.pnl_GhiChu.Controls.Add(this.txt_GhiChu);
            this.pnl_GhiChu.Location = new System.Drawing.Point(20, 440);
            this.pnl_GhiChu.Name = "pnl_GhiChu";
            this.pnl_GhiChu.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_GhiChu.Size = new System.Drawing.Size(425, 120);
            this.pnl_GhiChu.TabIndex = 4;
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_GhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_GhiChu.Location = new System.Drawing.Point(15, 10);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(84, 25);
            this.lbl_GhiChu.TabIndex = 0;
            this.lbl_GhiChu.Text = "Ghi chú:";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txt_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_GhiChu.Location = new System.Drawing.Point(15, 35);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(392, 70);
            this.txt_GhiChu.TabIndex = 1;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Buttons.Controls.Add(this.btn_XacNhanThanhToan);
            this.pnl_Buttons.Controls.Add(this.btn_Dong);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 580);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Padding = new System.Windows.Forms.Padding(20);
            this.pnl_Buttons.Size = new System.Drawing.Size(900, 70);
            this.pnl_Buttons.TabIndex = 5;
            // 
            // btn_XacNhanThanhToan
            // 
            this.btn_XacNhanThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_XacNhanThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhanThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhanThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_XacNhanThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhanThanhToan.Location = new System.Drawing.Point(524, 15);
            this.btn_XacNhanThanhToan.Name = "btn_XacNhanThanhToan";
            this.btn_XacNhanThanhToan.Size = new System.Drawing.Size(236, 40);
            this.btn_XacNhanThanhToan.TabIndex = 0;
            this.btn_XacNhanThanhToan.Text = "Xác nhận thanh toán";
            this.btn_XacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btn_XacNhanThanhToan.Click += new System.EventHandler(this.btn_XacNhanThanhToan_Click);
            this.btn_XacNhanThanhToan.MouseEnter += new System.EventHandler(this.btn_XacNhanThanhToan_MouseEnter);
            this.btn_XacNhanThanhToan.MouseLeave += new System.EventHandler(this.btn_XacNhanThanhToan_MouseLeave);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Dong.FlatAppearance.BorderSize = 0;
            this.btn_Dong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Dong.ForeColor = System.Drawing.Color.White;
            this.btn_Dong.Location = new System.Drawing.Point(780, 15);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(100, 40);
            this.btn_Dong.TabIndex = 1;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            this.btn_Dong.MouseEnter += new System.EventHandler(this.btn_Dong_MouseEnter);
            this.btn_Dong.MouseLeave += new System.EventHandler(this.btn_Dong_MouseLeave);
            // 
            // frm_HoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.pnl_GhiChu);
            this.Controls.Add(this.pnl_ThanhToan);
            this.Controls.Add(this.pnl_ChiTiet);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.frm_HoaDonThanhToan_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_HoaDonThanhToan_Paint);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.pnl_ChiTiet.ResumeLayout(false);
            this.pnl_ChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTiet)).EndInit();
            this.pnl_ThanhToan.ResumeLayout(false);
            this.pnl_ThanhToan.PerformLayout();
            this.pnl_GhiChu.ResumeLayout(false);
            this.pnl_GhiChu.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Event handlers for button hover effects
        private void btn_XacNhanThanhToan_MouseEnter(object sender, System.EventArgs e)
        {
            btn_XacNhanThanhToan.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        }

        private void btn_XacNhanThanhToan_MouseLeave(object sender, System.EventArgs e)
        {
            btn_XacNhanThanhToan.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
        }

        private void btn_Dong_MouseEnter(object sender, System.EventArgs e)
        {
            btn_Dong.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        }

        private void btn_Dong_MouseLeave(object sender, System.EventArgs e)
        {
            btn_Dong.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        // Paint event for form border
        private void frm_HoaDonThanhToan_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Pen borderPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(52, 73, 94), 2);
            e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            borderPen.Dispose();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGiaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
    }
}