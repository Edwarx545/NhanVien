using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    class DanhSachNhanVien
    {
        Dictionary<int, NhanVien> danhSach; 
        
        public DanhSachNhanVien()
        {
            danhSach = new Dictionary<int, NhanVien>();
        }
        public void nhap()
        {
            int i;
            while (true)
            {
                Console.WriteLine("0: Exit,1: Nhap");
                i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("0: Nhan vien bien che/ 1: Nhan vien hop dong");
                    int kieuNhanVien = int.Parse(Console.ReadLine());

                    if (kieuNhanVien == 0)
                    {
                        NhanVien nhanVien= new NhanVienBienChe();
                        nhanVien.nhap();
                        danhSach.Add(nhanVien.MaNV,nhanVien);
                    }
                    else if(kieuNhanVien == 1)
                    {
                        NhanVien nhanVien = new NhanVienHopDong();
                        nhanVien.nhap();
                        danhSach.Add(nhanVien.MaNV, nhanVien);
                    }

                }

            }
        }

        public void xuat()
        {
            NhanVien nv = new NhanVienBienChe();
            Console.WriteLine(nv.CMND);
            foreach (KeyValuePair<int, NhanVien> sinhVien in danhSach)
            {
                Console.WriteLine("Ma SV: {0} SV: {1}", sinhVien.Key, sinhVien.Value.HoTen);
            }
        }
    }
}
