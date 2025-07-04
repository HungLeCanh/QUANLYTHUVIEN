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
    public partial class frm_TrangChu : Form
    {
        double width, height;  
        public frm_TrangChu(double width, double height)
        {
            InitializeComponent();
            this.width = width;
            this.height = height;
            CenterPanel();

        }
        private void CenterPanel()
        {
            int x = (int)((width - panel1.Width) / 2);
            int y = (int)((height - panel1.Height) / 2);
            panel1.Location = new Point(x, y);

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
