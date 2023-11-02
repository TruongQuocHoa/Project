using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Sach
{
    internal class Book
    {
        public string maSach, tenSach, tacGia;
        public int namXuatBan;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }

        public Book()
        {
            maSach = string.Empty;
            tenSach = string.Empty;
            tacGia = string.Empty;
            namXuatBan = 0;
        }
        public Book(string maSach, string tenSach, string tacGia, int namXuatBan)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.namXuatBan = namXuatBan;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ma sach: ");
            maSach = Console.ReadLine();
            Console.Write("Nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.Write("Nhap tac gia: ");
            tacGia = Console.ReadLine();
            Console.Write("Nhap nam xuat ban: ");
            namXuatBan = int.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine($"\nMa sach: {maSach}");
            Console.WriteLine($"Ten sach: {tenSach}");
            Console.WriteLine($"Tac gia: {tacGia}");
            Console.WriteLine($"Nam xuat ban: {namXuatBan}");
        }
    }
}
