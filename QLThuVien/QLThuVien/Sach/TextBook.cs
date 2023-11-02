using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Sach
{
    internal class TextBook : Book
    {
        public string subject;

        public string Subject { get => subject; set => subject = value; }

        public TextBook() : base()
        {
            subject = string.Empty;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap mon hoc: ");
            subject = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Mon hoc: {subject}");
        }
    }
}
