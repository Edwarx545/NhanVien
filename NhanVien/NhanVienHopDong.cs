using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class NhanVienHopDong:NhanVien,IPHUCAP
    {
        int mucLuong;
        public NhanVienHopDong(string hoTen, DateTime namSinh, int gioiTinh, int cMND, int maNV, int mucLuong)
            : base(hoTen, namSinh, gioiTinh, cMND, maNV)
        {
            this.mucLuong= mucLuong;
        }

        public NhanVienHopDong() : base() { }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Muc luong: ");
            this.mucLuong = int.Parse(Console.ReadLine());
        }

        public override int thucLinh()
        {
            int thucLinh =  mucLuong+ phuCap();
            return thucLinh;
        }

        public int phuCap()
        {
            int phuCap = mucLuong / 10;
            return phuCap;
        }
    }
}
