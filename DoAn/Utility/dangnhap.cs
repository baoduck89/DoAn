using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn.NewFolder4
{
     class dangnhap
    {               
        public void dangnhap()
        {
            string tk, mk;
            int dem = 0;
            while (dem < 3)
            {
                dem++;
                Console.WriteLine("-------------Dang Nhap-------------");
                Console.Write("Tai Khoan:");
                tk = Console.ReadLine();
                Console.WriteLine("Mat Khau:");
                mk = Console.ReadLine();
                if (tk == "admin" && mk = "admin")
                {
                    Console.WriteLine(" DANG NHAP THANH CONG!");
                    break;
                }


            }
        }
    }
}
