using System;
using System.Collections.Generic;
using System.Text;
using DoAn.Data.DTO;
using System.IO;


namespace DoAn.DataAccessLayer
{
    class NhanVienDAL
    {        
            private string fileName = "NhanVien.txt";
            private StreamReader sr;
            public NhanVienDAL()
            {
                
            }
            public List<Nhanvien> docTep()
            {
                sr = new StreamReader(fileName);
                List<Nhanvien> sanphams = new List<Nhanvien>();
                string r;
                while ((r = sr.ReadLine())
                    != null)
                {
                    string[] tmp = r.Split('#');
                    Nhanvien sanpham = new Nhanvien(int.Parse(tmp[0]),
                        int.Parse(tmp[1]), int.Parse(tmp[2]), int.Parse(tmp[3]), tmp[4],
                        tmp[5], DateTime.Parse(tmp[6]), DateTime.Parse(tmp[7]));
                    sanphams.Add(sanpham);
                }
                sr.Close();
                return sanphams;
            }
            public void ghitep(List<Nhanvien> nhanviens)
            {
                StreamWriter f = File.CreateText(fileName);
                foreach (Nhanvien nv in nhanviens)
                {
                    f.WriteLine(nv.MaNV + "#" + nv.TenNV + "#" + nv.GioiTinh + "#" + nv.NgaySinh + "#" + nv.NgayVaoLV );
                }
                f.Close();
            }
        }
    }

