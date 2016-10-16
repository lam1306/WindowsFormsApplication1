using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class UDQLTK : Form
    {
        public UDQLTK()
        {
            InitializeComponent();
        }
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (taikhoanbus.KTDangNhap(txtTaikhoan.Text, txtMatkhau.Text) == true)
            {
                this.Hide();
                formQLTK frm = new formQLTK();
                frm.Show();
            }
            else
                MessageBox.Show("tai khoan k đúng");
        }
    }
}
