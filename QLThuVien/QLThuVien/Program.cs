using QLThuVien.Manager;
using QLThuVien.Sach;

internal class Program
{
    private static void Main(string[] args)
    {
        BookManager bookManager = new BookManager();
        ReaderManager readerManager = new ReaderManager();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Thu vien");
            Console.WriteLine("2. Doc gia");
            Console.WriteLine("3. Thoat chuong trinh");
            Console.Write("Moi ban chon chuc nang: ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. Them sach vao thu vien");
                    Console.WriteLine("2. In danh sach sach trong thu vien");
                    Console.WriteLine("3. Tim sach theo ten tac gia");
                    Console.WriteLine("4. Tim sach theo ten sach");
                    Console.WriteLine("5. Thoat khoi muc thu vien");
                    Console.Write("Moi ban chon chuc nang: ");
                    int option1 = int.Parse(Console.ReadLine());
                    if (option1 == 1)
                    {
                        bookManager.AddBook();
                        Console.ReadKey();
                    }
                    else if (option1 == 2)
                    {
                        bookManager.PrintBook();
                        Console.ReadKey();
                    }
                    else if (option1 == 3)
                    {
                        bookManager.searchByAuthor();
                        Console.ReadKey();
                    }
                    else if (option1 == 4)
                    {
                        bookManager.SearchByName();
                        Console.ReadKey();
                    }
                    else if (option1 == 5)
                    {
                        break;
                    }
                }
            }
            else if (option == 2)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. Them thong tin doc gia");
                    Console.WriteLine("2. In danh sach doc gia");
                    Console.WriteLine("3. Muon va tra sach");
                    Console.WriteLine("4. Thoat khoi muc doc gia");
                    Console.Write("Moi ban chon chuc nang: ");
                    int option2 = int.Parse(Console.ReadLine());
                    if (option2 == 1)
                    {
                        readerManager.AddReader();
                        Console.ReadKey();
                    }
                    else if (option2 == 2)
                    {
                        readerManager.PrintReader();
                        Console.ReadKey();
                    }
                    else if (option2 == 3)
                    {
                        if (bookManager.KiemTra())
                        {
                            readerManager.Muontra();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Khong co sach trong thu vien");
                            Console.ReadKey();
                        }
                    }
                    else if (option2 == 4)
                    {
                        break;
                    }
                }
            }
            else { break; }
        }
        Console.ReadKey();
    }
}