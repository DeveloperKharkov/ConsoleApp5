using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module15ClassWord
{
    class TecnicalBook: Book
    {
        private string _areaOf;

        public string AreaOf { get { return _areaOf; } }

        public override void Print()
        {
            Console.Write($"AreaOf={_areaOf}, ");
            base.Print();
        }

        public TecnicalBook(string author, string title, int numberOfPages, string areaOf): 
            base(author, title, numberOfPages)
        {
            _areaOf = areaOf;
        }
    }
}
