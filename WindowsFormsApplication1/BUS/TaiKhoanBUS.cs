using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class TaiKhoanBUS
    {
        QUANLITAIKHOANDataContext TaiKhoans = new QUANLITAIKHOANDataContext();
        public bool KTDangNhap(string tendangnhap,string matkhau)
            {
            int taikhoan = (from tk in TaiKhoans.TAIKHOANs
                           where tk.TaiKhoan == tendangnhap && tk.MatKhau = matkhau
                           select tk).Count();
            if (taikhoan == 1)
                return true;
            else
                   return false;
            }

    }
}
