using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn.Data.DTO
{
    class Nhanvien
    {
        private int MaNV;
        private string TenNV, GioiTinh;
        DateTime NgaySinh, NgayVaoLV;
        public Nhanvien(int MaNV, string TenNV, string GioiTinh, DateTime NgaySinh, DateTime NgayVaoLV)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.NgayVaoLV = NgayVaoLV;
        }
    }
}
        