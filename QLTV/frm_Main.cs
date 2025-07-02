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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formToOpen)
        {
            // Xóa các control (form con) hiện tại trong frm_Main
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Form f)
                    f.Close();
            }

            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;
            this.Controls.Add(formToOpen);
            formToOpen.Show();
        }


        private void frm_Main_Load(object sender, EventArgs e)
        {
            // mặc định hiển thị form trang chủ khi mở ứng dụng
            frm_TrangChu trangChuForm = new frm_TrangChu();
            trangChuForm.TopLevel = false; // cho phép hiển thị form con trong form cha
            trangChuForm.FormBorderStyle = FormBorderStyle.None; // không có viền form
            trangChuForm.Dock = DockStyle.Fill; // chiếm toàn bộ không gian của form cha
            this.Controls.Add(trangChuForm); // thêm form con vào form cha
            trangChuForm.Show(); // hiển thị form con
        }

        private void thêmMớiĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form thêm mới độc giả, có kiểm tra xem form đã mở hay chưa
            if(Application.OpenForms["frm_ThemDocGia"] == null)
            {
                OpenForm(new frm_ThemDocGia());
            }
        }

        private void danhSáchĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form danh sách độc giả, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_DanhSachDocGia"] == null)
            {
                OpenForm(new frm_DanhSachDocGia());
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form trang chủ, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_TrangChu"] == null)
            {
                OpenForm(new frm_TrangChu());
            }
        }

        private void tạoPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form tạo phiếu mượn, có kiểm tra xem form đã mở hay chưa
            if (Application.OpenForms["frm_TaoPhieuMuon"] == null)
            {
                OpenForm(new frm_TaoPhieuMuon());
            }
        }
    }
}
