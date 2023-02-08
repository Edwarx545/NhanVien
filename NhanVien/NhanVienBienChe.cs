using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class NhanVienBienChe : NhanVien,IPHUCAP
    {
        int heSoLuong;
        int luongCoBan;

        public NhanVienBienChe(string hoTen, DateTime namSinh, int gioiTinh, int cMND, int maNV, int heSoLuong, int luongCoBan)
            :base( hoTen,  namSinh,  gioiTinh,  cMND,  maNV)
        {
            this.heSoLuong = heSoLuong;
            this.luongCoBan = luongCoBan;
        }
        
        public NhanVienBienChe() : base() { }
        
        public void nhap()
        {
            base.nhap();
            Console.WriteLine("He so luong: ");
            this.heSoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Luong co ban: ");
            this.luongCoBan = int.Parse(Console.ReadLine());
        }
        public int phuCap()
        {
            int phuCap = luongCoBan / 10;
            return phuCap;
        }

        public override int thucLinh()
        {
            int thucLinh = heSoLuong*luongCoBan+phuCap();
            return thucLinh;
        }
    }
}
