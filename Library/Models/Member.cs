using CSDemoProject1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemoProject1.Models
{
    public class Member : IMember
    {
        public Member()
        {
            BookReceived = new List<Book>();
        }
        public int MemnerNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Book> BookReceived { get; set; }

        public void BookReturn(Book book)
        {
            if (BookReceived.Contains(book))
            {
                book.Status=Enums.Status.Avaible;
                BookReceived.Remove(book);
            }
            else
            {

            }

        }

        public void BorrowBook(Book book)
        {
            if (book.Status == Enums.Status.Avaible)
            {
                book.Status = Enums.Status.InUse;
                BookReceived.Add(book);
            }
            else
            {

            }
        }
    }
}
