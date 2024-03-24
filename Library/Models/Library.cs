using CSDemoProject1.Abstracts;
using CSDemoProject1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemoProject1.Models
{
    public class Library
    {
        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }
        public List<Book> Books{ get; set; }
        public List<Member> Members { get; set; }

        public void BookStatusUpdate(Book book,Status status)
        {
            book.Status = status;       
        }
           

    }
}
