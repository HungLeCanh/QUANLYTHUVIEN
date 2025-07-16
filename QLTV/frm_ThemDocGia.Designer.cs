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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.chart_DocGiaMoiTheoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Header.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_Form.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DocGiaMoiTheoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "📞 Số điện thoại:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.Color.White;
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_SoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(100, 71);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(280, 32);
            this.txt_SoDienThoai.TabIndex = 1;
            this.txt_SoDienThoai.TextChanged += new System.EventHandler(this.txt_SoDienThoai_TextChanged);
            // 
            // txt_TenDocGia
            // 
            this.txt_TenDocGia.BackColor = System.Drawing.Color.White;
            this.txt_TenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDocGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_TenDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_TenDocGia.Location = new System.Drawing.Point(100, 131);
            this.txt_TenDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDocGia.Name = "txt_TenDocGia";
            this.txt_TenDocGia.Size = new System.Drawing.Size(280, 32);
            this.txt_TenDocGia.TabIndex = 3;
            this.txt_TenDocGia.TextChanged += new System.EventHandler(this.txt_TenDocGia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(96, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "👤 Tên độc giả:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_Email.Location = new System.Drawing.Point(100, 191);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(280, 32);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(96, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "✉️ Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.White;
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(100, 251);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(280, 32);
            this.txt_DiaChi.TabIndex = 7;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(96, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "🏠 Địa chỉ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(462, 20);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(140, 50);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "➕ Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_NhapLai.FlatAppearance.BorderSize = 0;
            this.btn_NhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_NhapLai.ForeColor = System.Drawing.Color.White;
            this.btn_NhapLai.Location = new System.Drawing.Point(622, 20);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(140, 50);
            this.btn_NhapLai.TabIndex = 9;
            this.btn_NhapLai.Text = "🔄 Nhập lại";
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel_Header.Controls.Add(this.lbl_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1228, 80);
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
            this.lbl_Title.Size = new System.Drawing.Size(286, 41);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "📝 THÊM ĐỘC GIẢ";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel_Main.Controls.Add(this.panel_Form);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 80);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Padding = new System.Windows.Forms.Padding(30);
            this.panel_Main.Size = new System.Drawing.Size(1228, 390);
            this.panel_Main.TabIndex = 11;
            this.panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_Paint);
            // 
            // panel_Form
            // 
            this.panel_Form.BackColor = System.Drawing.Color.White;
            this.panel_Form.Controls.Add(this.chart_DocGiaMoiTheoThang);
            this.panel_Form.Controls.Add(this.txt_SoDienThoai);
            this.panel_Form.Controls.Add(this.label1);
            this.panel_Form.Controls.Add(this.txt_TenDocGia);
            this.panel_Form.Controls.Add(this.label2);
            this.panel_Form.Controls.Add(this.txt_Email);
            this.panel_Form.Controls.Add(this.label3);
            this.panel_Form.Controls.Add(this.txt_DiaChi);
            this.panel_Form.Controls.Add(this.label4);
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form.Location = new System.Drawing.Point(30, 30);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(1168, 330);
            this.panel_Form.TabIndex = 0;
            this.panel_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Paint);
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_Controls.Controls.Add(this.btn_Them);
            this.panel_Controls.Controls.Add(this.btn_NhapLai);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(0, 470);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1228, 90);
            this.panel_Controls.TabIndex = 12;
            this.panel_Controls.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Controls_Paint);
            // 
            // chart_DocGiaMoiTheoThang
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_DocGiaMoiTheoThang.ChartAreas.Add(chartArea1);
            this.chart_DocGiaMoiTheoThang.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart_DocGiaMoiTheoThang.Legends.Add(legend1);
            this.chart_DocGiaMoiTheoThang.Location = new System.Drawing.Point(530, 0);
            this.chart_DocGiaMoiTheoThang.Name = "chart_DocGiaMoiTheoThang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Độc Giả Mới";
            this.chart_DocGiaMoiTheoThang.Series.Add(series1);
            this.chart_DocGiaMoiTheoThang.Size = new System.Drawing.Size(638, 330);
            this.chart_DocGiaMoiTheoThang.TabIndex = 8;
            this.chart_DocGiaMoiTheoThang.Text = "Độc Giả Mới Theo Tháng";
            // 
            // frm_ThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 560);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_ThemDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thư viện - Thêm mới Độc giả";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel_Form.ResumeLayout(false);
            this.panel_Form.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DocGiaMoiTheoThang)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DocGiaMoiTheoThang;
    }
}