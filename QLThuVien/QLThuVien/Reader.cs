using QLThuVien.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class Reader
    {
        public string maDocGia, tenDocGia, diaChi;
        public string soDienThoai;
        public DateTime ngayMuon, ngayTra;
        public DateTime ngayThucTe;

        public string MaDocGia { get => maDocGia; set => maDocGia = value; }
        public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public DateTime NgayThucTe { get => ngayThucTe; set => ngayThucTe = value; }

        public Reader()
        {
            this.maDocGia = string.Empty;
            this.tenDocGia = string.Empty;
            this.diaChi = string.Empty;
            this.soDienThoai = string.Empty;
            this.ngayMuon = DateTime.MinValue;
            this.ngayTra = DateTime.MinValue;
        }

        public Reader(string maDocGia, string tenDocGia, string diaChi, string soDienThoai, DateTime ngayMuon, DateTime ngayTra)
        {
            this.maDocGia = maDocGia;
            this.tenDocGia = tenDocGia;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
        }

        public void Input()
        {
            Console.Write("Nhap ma doc gia: ");
            maDocGia = Console.ReadLine();
            Console.Write("Nhap ten doc gia: ");
            tenDocGia = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            soDienThoai = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"\nMa doc gia: {maDocGia}");
            Console.WriteLine($"Ten doc gia: {tenDocGia}");
            Console.WriteLine($"Dia chi: {diaChi}");
            Console.WriteLine($"So dien thoai: {soDienThoai}");
            Console.WriteLine($"Ngay muon: {ngayMuon}");
            Console.WriteLine($"Ngay tra: {ngayTra}");
        }
    }
}
