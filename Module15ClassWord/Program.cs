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
            library.Add(new Book("Nokolay Gogol", "Viy", 564));
            library.Add(new TecnicalBook ("Gefrey Rihter", "C# Core", 344, ".Net"));
            library.Add(new TecnicalBook("O'Relly", "Benefits of .Net", 333, ".Net"));
            library.Add(new FictionBook("IIi", "Summer", 335));
            library.Add(new FictionBook("Yama", "Winter", 456));

            Console.WriteLine("Please press the key from 1 to 5:");
            Console.WriteLine("1. Show all books");
            Console.WriteLine("2. Show only technical books");
            Console.WriteLine("3. Show only fiction books");
            Console.WriteLine("4. Show all books sorted by author");
            Console.WriteLine("5. Show all books sorted by title");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            ConsoleKeyInfo info;
            do
            {
                info = Console.ReadKey();
                Console.WriteLine();

                switch (info.Key)
                {
                    case ConsoleKey.D1:
                        library.Print(BookType.All, SortingCriteria.None);
                        break;

                    case ConsoleKey.D2:
                        library.Print(BookType.Technical, SortingCriteria.None);
                        break;

                    case ConsoleKey.D3:
                        library.Print(BookType.Fiction, SortingCriteria.None);
                        break;

                    case ConsoleKey.D4:
                        library.Print(BookType.All, SortingCriteria.ByAuthor);
                        break;

                    case ConsoleKey.D5:
                        library.Print(BookType.All, SortingCriteria.ByTitle);
                        break;

                    default:
                        break;
                }
            }
            while (info.Key != ConsoleKey.D6);
        }
    }
}
