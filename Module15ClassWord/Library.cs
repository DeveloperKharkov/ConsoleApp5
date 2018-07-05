using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15ClassWord
{
    public enum BookType
    {
        All,
        Technical,
        Fiction
    }

    public enum SortingCriteria
    {
        None,
        ByAuthor,
        ByTitle
    }

    class Library
    {
        private List<Book> _books;

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Print(BookType bookType, SortingCriteria sortingData)
        {
            List<Book> sortedBooks;

            switch (sortingData)
            {
                case SortingCriteria.None:
                    sortedBooks = _books;
                    break;
                case SortingCriteria.ByAuthor:
                    sortedBooks = _books.OrderBy(b => b.Author).ToList();
                    break;
                case SortingCriteria.ByTitle:
                    sortedBooks = _books.OrderBy(b => b.Title).ToList();
                    break;
                default:
                    throw new ArgumentException($"The sortingCriteria={sortingData} is not supported", nameof(sortingData));
            }

            foreach (Book item in sortedBooks)
            {
                switch (bookType)
                {
                    case BookType.All:
                        item.Print();
                        break;

                    case BookType.Technical:
                        if (item is TecnicalBook)
                        {
                            item.Print();
                        }
                        break;

                    case BookType.Fiction:
                        if (item is FictionBook)
                        {
                            item.Print();
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public Library()
        {
            _books = new List<Book>();
        }
    }
}
