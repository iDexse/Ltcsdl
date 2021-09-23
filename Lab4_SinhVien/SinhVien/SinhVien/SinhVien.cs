using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        public SinhVien()
        {

        }

        public SinhVien(string ms, string ht, bool gt, DateTime ngay, string lop, string sdt, string email,
            string diachi, string hinh)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.GioiTinh = gt;
            this.NgaySinh = ngay;
            this.Lop = lop;
            this.SoDienThoai = sdt;
            this.Email = email;
            this.DiaChi = diachi;
            this.Hinh = hinh;
        }
    }
}
