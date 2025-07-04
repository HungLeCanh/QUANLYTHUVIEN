using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            this.Load += frm_DangNhap_Load;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            // Thiết lập placeholder cho textbox
            SetPlaceholderText();

            // Thiết lập focus vào textbox đầu tiên
            txt_TenDangNhap.Focus();
        }

        private void SetPlaceholderText()
        {
            // Thiết lập placeholder cho tên đăng nhập
            txt_TenDangNhap.Text = "Nhập tên tài khoản";
            txt_TenDangNhap.ForeColor = Color.Gray;
            txt_TenDangNhap.Enter += (s, e) => {
                if (txt_TenDangNhap.Text == "Nhập tên tài khoản")
                {
                    txt_TenDangNhap.Text = "";
                    txt_TenDangNhap.ForeColor = Color.FromArgb(44, 62, 80);
                }
            };
            txt_TenDangNhap.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt_TenDangNhap.Text))
                {
                    txt_TenDangNhap.Text = "Nhập tên tài khoản";
                    txt_TenDangNhap.ForeColor = Color.Gray;
                }
            };

            // Thiết lập placeholder cho mật khẩu
            txt_MatKhau.Text = "Nhập mật khẩu";
            txt_MatKhau.ForeColor = Color.Gray;
            txt_MatKhau.PasswordChar = '\0'; // Tạm thời bỏ PasswordChar
            txt_MatKhau.Enter += (s, e) => {
                if (txt_MatKhau.Text == "Nhập mật khẩu")
                {
                    txt_MatKhau.Text = "";
                    txt_MatKhau.ForeColor = Color.FromArgb(44, 62, 80);
                    txt_MatKhau.PasswordChar = '●';
                }
            };
            txt_MatKhau.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
                {
                    txt_MatKhau.Text = "Nhập mật khẩu";
                    txt_MatKhau.ForeColor = Color.Gray;
                    txt_MatKhau.PasswordChar = '\0';
                }
            };
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txt_TenDangNhap.Text) || txt_TenDangNhap.Text == "Nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || txt_MatKhau.Text == "Nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return;
            }

            // Xử lý đăng nhập (có thể kết nối database sau)
            string username = txt_TenDangNhap.Text;
            string password = txt_MatKhau.Text;

            // Tạm thời để đăng nhập demo với admin/admin
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form chính và ẩn form đăng nhập
                this.Hide();
                frm_Main mainForm = new frm_Main();
                mainForm.Show();

                // Đóng form đăng nhập khi form chính đóng
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MatKhau.Clear();
                txt_MatKhau.Text = "Nhập mật khẩu";
                txt_MatKhau.ForeColor = Color.Gray;
                txt_MatKhau.PasswordChar = '\0';
                txt_TenDangNhap.Focus();
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu và reset placeholder
            txt_TenDangNhap.Text = "Nhập tên tài khoản";
            txt_TenDangNhap.ForeColor = Color.Gray;

            txt_MatKhau.Text = "Nhập mật khẩu";
            txt_MatKhau.ForeColor = Color.Gray;
            txt_MatKhau.PasswordChar = '\0';

            txt_TenDangNhap.Focus();
        }

        // Thêm hiệu ứng hover cho button
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Hiệu ứng hover cho button đăng nhập
            btn_DangNhap.MouseEnter += (s, args) => {
                btn_DangNhap.BackColor = Color.FromArgb(52, 152, 219);
            };
            btn_DangNhap.MouseLeave += (s, args) => {
                btn_DangNhap.BackColor = Color.FromArgb(41, 128, 185);
            };

            // Hiệu ứng hover cho button nhập lại
            btn_NhapLai.MouseEnter += (s, args) => {
                btn_NhapLai.BackColor = Color.FromArgb(127, 140, 141);
            };
            btn_NhapLai.MouseLeave += (s, args) => {
                btn_NhapLai.BackColor = Color.FromArgb(149, 165, 166);
            };
        }

        // Cho phép nhấn Enter để đăng nhập
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btn_DangNhap_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}