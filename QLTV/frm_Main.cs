using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formToOpen)
        {
            // Xóa các control (form con) hiện tại trong panel1
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Form f)
                    f.Close();
            }

            // Xóa tất cả controls trong panel1
            panel1.Controls.Clear();

            // Thiết lập form con
            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;

            // Thêm form con vào panel1 thay vì this.Controls
            panel1.Controls.Add(formToOpen);
            panel1.Visible = true; // Đảm bảo panel1 hiển thị
            formToOpen.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị form trang chủ khi mở ứng dụng
            frm_TrangChu trangChuForm = new frm_TrangChu(panel1.Width, panel1.Height);
            
            OpenForm(trangChuForm);
        }

        private void thêmMớiĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới độc giả, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_ThemDocGia"] == null)
            {
                OpenForm(new frm_ThemDocGia());
            }
        }

        private void danhSáchĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form danh sách độc giả, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_DanhSachDocGia"] == null)
            {
                OpenForm(new frm_DanhSachDocGia());
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form trang chủ, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                OpenForm(new frm_TrangChu(panel1.Width, panel1.Height));
            }
        }

        private void tạoPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form tạo phiếu mượn, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_TaoPhieuMuon"] == null)
            {
                OpenForm(new frm_TaoPhieuMuon());
            }
        }

        private void thêmMớiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới sách, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_ThemSach"] == null)
            {
                OpenForm(new frm_ThemSach());
            }
        }
    }
}