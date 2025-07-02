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
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            // kiểm tra xem tên và mật khẩu có phải admin hay không
            if (txt_TenDangNhap.Text == "admin" && txt_MatKhau.Text == "admin")
            {
                // nếu đúng thì mở form chính
                frm_Main mainForm = new frm_Main();
                mainForm.Show();
                this.Hide(); // ẩn form đăng nhập
            }
            else
            {
                // nếu sai thì thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
