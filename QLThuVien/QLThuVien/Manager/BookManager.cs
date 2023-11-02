using QLThuVien.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Manager
{
    internal class BookManager
    {
        List<Book> books;

        public List<Book> Books { get => books; set => books = value; }

        public BookManager()
        {
            books = new List<Book>();
        }

        public void AddBook()
        {
            Book book;
            while (true)
            {
                Console.Write("Ban muon nhap loai sach nao? (T/N): ");
                string option = Console.ReadLine();
                if (option.ToLower().Equals("t"))
                {
                    book = new TextBook();
                }
                else if (option.ToLower().Equals("n"))
                {
                    book = new Novel();
                }
                else
                    break;
                book.Input();
                books.Add(book);
            }
        }
        public void PrintBook()
        {
            foreach (Book book in books)
            {
                book.Output();
            }
        }
        public void PrintBook(List<Book> books)
        {
            foreach (Book book in books)
            {
                book.Output();
            }
        }
        public void searchByAuthor()
        {
            List<Book> searchByAuthor = new List<Book>();
            Console.Write("Nhap ten tac gia can tim: ");
            string author = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.tacGia.ToLower().Equals(author.ToLower()))
                {
                    searchByAuthor.Add(book);
                }
            }
            PrintBook(searchByAuthor);
        }
        public void SearchByName()
        {
            List<Book> searchByName = new List<Book>();
            Console.Write("Nhap ten sach can tim: ");
            string name = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.tenSach.ToLower().Equals(name.ToLower()))
                {
                    searchByName.Add(book);
                }
            }
            PrintBook(searchByName);
        }
        public bool KiemTra()
        {
            bool timThay = true;
            Console.Write("Nhap sach muon: ");
            string ten = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].TenSach.ToLower().Equals(ten.ToLower()))
                {
                    timThay = true;
                }
            }
            if (timThay)
            {
                return true;
            }
            else
                return false;
        }
    }
}
