using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Sach
{
    internal class Novel: Book
    {
        public string genre;

        public string Genre { get => genre; set => genre = value; }

        public Novel() : base()
        {
            genre = string.Empty;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap the loai: ");
            genre = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"The loai: {genre}");
        }
    }
}
