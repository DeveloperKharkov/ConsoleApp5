using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15ClassWord
{
    class FictionBook: Book
    {
        public FictionBook(string author, string title, int numberOfPages): 
            base(author, title, numberOfPages)
        {
        }
    }
}
