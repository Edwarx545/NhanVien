using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
     abstract public class NhanVien
    {
        string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        DateTime namSinh;
        int gioiTinh;
        int cMND;
        public int CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }
        int maNV;
        int trongTai;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public NhanVien(string hoTen, DateTime namSinh, int gioiTinh, int cMND, int maNV)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.cMND = cMND;
            this.maNV = maNV;
        }
      
        public NhanVien() { }
        
        public void nhap()
        {
            Console.Write("Ho Ten");
            this.hoTen = Console.ReadLine();


            Console.Write("Nam sinh");
            this.namSinh = DateTime.Parse(Console.ReadLine());

            Console.Write("Gioi tinh (Nam:0, Nu:1): ");
            this.gioiTinh = int.Parse(Console.ReadLine());

            Console.Write("CMND: ");
            this.cMND = int.Parse(Console.ReadLine());

            Console.Write("MA NV: ");
            this.maNV = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Nam sinh: " + this.namSinh);
            Console.WriteLine("Gioi tinh: ");
            if (this.gioiTinh == 0)
                Console.Write("Nam");
            else Console.Write("Nu");
            Console.WriteLine("CMND: " + this.cMND);
            Console.WriteLine("Ma NV: " + this.maNV);
        }

        public abstract int thucLinh();
        
    }
}
