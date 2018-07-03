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
            var books = new List<Book>();
            books.Add(new Book("Lion Tolstoy", "Voskresenie", 345));
            books.Add(new TecnicalBook ("Gefrey Rihter", "C# Core", 344, ".Net"));
            books.Add(new FictionBook("IIi", "Summer", 335));

            foreach (Book item in books)
            {
                item.Print();
            } 

        }
    }
}
