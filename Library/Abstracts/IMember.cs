using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemoProject1.Abstracts
{
    public interface IMember
    {
        [Key]
        public int MemnerNumber { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
       
        void BorrowBook(Book book);
        void BookReturn(Book book);

      
    }
}
