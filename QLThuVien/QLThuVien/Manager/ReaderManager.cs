using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Manager
{
    internal class ReaderManager
    {
        List<Reader> readers;
        public List<Reader> Readers { get => readers; set => readers = value; }
        public ReaderManager()
        {
            readers = new List<Reader>();
        }
        public void AddReader()
        {
            Reader reader = null;
            while(true)
            {
                Console.Write("Ban co muon nhap thong tin doc gia? (Y/N): ");
                string option = Console.ReadLine();
                if (option.ToLower().Equals("y"))
                {
                    reader = new Reader();
                }
                else break;
                reader.Input();
                readers.Add(reader);
            }
        }
        public void PrintReader()
        {
            foreach(Reader reader in readers)
            {
                reader.Output();
            }
        }
        public void PrintReader(List<Reader> readers)
        {
            foreach(Reader reader in readers)
            {
                reader.Output();
            }
        }
        public void Muontra()
        {
            bool tim = true;
            Console.Write("Nhap ma doc gia muon sach: ");
            string id = Console.ReadLine();
            foreach (Reader reader in readers)
            {
                if (reader.maDocGia == id)
                {
                    tim = true; break;
                }
                else
                    tim = false;
            }
            if (tim)
            {
                foreach (Reader reader1 in readers)
                {
                    if (reader1.maDocGia == id)
                    {
                        Console.Write("Nhap ngay muon: ");
                        int ngay = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang muon: ");
                        int thang = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam muon: ");
                        int nam = int.Parse(Console.ReadLine());
                        reader1.ngayMuon = new DateTime(nam, thang, ngay);

                        Console.Write("Nhap ngay tra: ");
                        int ngay1 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang tra: ");
                        int thang1 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam tra: ");
                        int nam1 = int.Parse(Console.ReadLine());
                        reader1.ngayTra = new DateTime(nam1, thang1, ngay1);

                        Console.Write("Nhap ngay tra thuc te: ");
                        int ngayThucTe = int.Parse(Console.ReadLine());
                        Console.Write("Nhap thang tra thuc te: ");
                        int thangThucTe = int.Parse(Console.ReadLine());
                        Console.Write("Nhap nam tra thuc te: ");
                        int namThucTe = int.Parse(Console.ReadLine());
                        reader1.NgayThucTe = new DateTime(namThucTe, thangThucTe, ngayThucTe);

                        TimeSpan duration = reader1.ngayThucTe - reader1.ngayTra;
                        int khoangngay = (int)duration.Days;
                        if (khoangngay < 0)
                        {
                            Console.WriteLine("Cam on ban da tra dung han");
                        }
                        else
                        {
                            Console.WriteLine("Ban da muon qua so ngay quy dinh");
                            Console.WriteLine("Tien phat se la: 5000vnd/ngay");
                            Console.WriteLine("So tien ban phai tra la: {0}vnd", 5000 * khoangngay);
                        }
                            break;
                    }
                }
            }
            else
                Console.WriteLine("Khong tim thay doc gia");
            PrintReader(readers);
        }
    }
}
