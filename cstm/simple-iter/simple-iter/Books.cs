using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_iter
{
    class Books  : IEnumerable
    {
        public Book[] book_list;
        public Books(Book first, Book second)
        {
            book_list = new Book[2];
            book_list[0] = first;
            book_list[1] = second;
        }
        public IEnumerator GetEnumerator()
        {
            return book_list.GetEnumerator();
        }
    }
}
