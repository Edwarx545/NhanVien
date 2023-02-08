using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class Class1
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ObjectDanhSach= new DanhSachNhanVien();
            ObjectDanhSach.nhap();
            ObjectDanhSach.xuat();
            Console.ReadLine();
        }
    }
}
