using System;
using System.Collections.Generic;
using System.Linq;

namespace Module15ClassWord
{
    public class Book
    {
        protected string _author;
        protected string _title;
        protected int _numberOfPages;

        public string Author { get { return _author; } }
        public string Title { get { return _title; } }
        public int NumberOfPages { get { return _numberOfPages; } }

        public virtual void Print()
        {
            Console.WriteLine($"Author={_author}, Title={_title}, NumberOfPages={_numberOfPages}");
        }

        public Book()
        {
            _author = "unknown";
            _title = "unknown";
            _numberOfPages = 0;
        }

        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }

        public Book(string author, string title, int numberOfPages)
        {
            _author = author;
            _title = title;
            _numberOfPages = numberOfPages;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            library.Add(new Book("Lion Tolstoy", "Voskresenie", 345));
            library.Add(new TecnicalBook ("Gefrey Rihter", "C# Core", 344, ".Net"));
            library.Add(new FictionBook("IIi", "Summer", 335));

            Console.WriteLine("library.Print(BookType.All)");
            library.Print(BookType.All);
            Console.WriteLine();

            Console.WriteLine("library.Print(BookType.Technical)");
            library.Print(BookType.Technical);
            Console.WriteLine();

            Console.WriteLine("library.Print(BookType.Fiction)");
            library.Print(BookType.Fiction);
        }
    }
}
