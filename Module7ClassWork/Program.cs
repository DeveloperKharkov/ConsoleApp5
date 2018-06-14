using System;
using System.Linq;

namespace Module7ClassWork
{
    struct Book
    {
        public string Title;
        public string Author;
        public int NumberOfPages;
        public int Id;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[4];
            books[0] = new Book
            {
                Author = "AA",
                NumberOfPages = 12213,
                Title = "dsd",
                Id = 255633
            };

            books[1] = new Book
            {
                Author = "Ghehe",
                NumberOfPages = 12,
                Title = "drrttd",
                Id = 24533
            };

            books[2] = new Book
            {
                Author = "BB",
                NumberOfPages = 13,
                Title = "dsd",
                Id = 2344333
            };

            books[3] = new Book
            {
                Author = "F",
                NumberOfPages = 1573,
                Title = "dsfddfd",
                Id = 233
            };

            for (int i = books.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (books[j].NumberOfPages > books[j + 1].NumberOfPages)
                    {
                        int tempNumberOfPages = books[j + 1].NumberOfPages;
                        books[j + 1].NumberOfPages = books[j].NumberOfPages;
                        books[j].NumberOfPages = tempNumberOfPages;
                    }
                }
            }

            foreach (Book item in books)
            {
                Console.WriteLine(item.NumberOfPages);
            }

            Console.WriteLine("Output for orderedBooks:");

            IOrderedEnumerable<Book> orderedBooks = books.OrderBy(b => b.Author);

            foreach (Book item in orderedBooks)
            {
                Console.WriteLine(item.Author);
            }
        }
    }
}
