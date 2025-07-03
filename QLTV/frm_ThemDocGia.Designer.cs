namespace QLTV
{
    partial class frm_ThemDocGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_TenDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(352, 66);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(210, 26);
            this.txt_SoDienThoai.TabIndex = 1;
            // 
            // txt_TenDocGia
            // 
            this.txt_TenDocGia.Location = new System.Drawing.Point(352, 121);
            this.txt_TenDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenDocGia.Name = "txt_TenDocGia";
            this.txt_TenDocGia.Size = new System.Drawing.Size(210, 26);
            this.txt_TenDocGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên độc giả:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(352, 188);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(210, 26);
            this.txt_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(352, 251);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(210, 26);
            this.txt_DiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(252, 315);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(138, 48);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Location = new System.Drawing.Point(424, 315);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(138, 48);
            this.btn_NhapLai.TabIndex = 9;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // frm_ThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 488);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenDocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ThemDocGia";
            this.Text = "Thêm mới Độc Giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_TenDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_NhapLai;
    }
}