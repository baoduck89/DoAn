using System;
using System.Collections.Generic;
using System.Text;
using DoAn.Data;
using DoAn.Data.DTO;


namespace DoAn.Business
{
    class NhanVienBLL
    {
        NhanVienBLL sp = new NhanVienBLL();
        List<Nhanvien> nhanviens;
        public void hienthi()
        {
            nhanviens = nv.docTep();
            foreach (Nhanvien nv in nhanviens)
            {
                Console.WriteLine(nv.MaNV + "\t" + nv.TenNV + "\t" + nv.GioiTinh +
                    "\t" + nv.NgaySinh + "\t" + nv.NgayVaoLv );

            }
        }
        public void add(NhanVienBLL tmp)
        {
            NhanVienBLL c = new NhanVienBLL();
           nhanviens= c.docTep();
            NhanVienBLL.Add(tmp);
            nv.ghitep(nhanviens);
        }
    }
}
