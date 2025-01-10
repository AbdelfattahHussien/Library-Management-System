using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class libraryuser:user
    {

        public int ID { get; set; }

        public libraryuser(string name)
        {
                Name = name;
        }
        public void BorrowBook(Book bbook,Library library)
        {
            library.Borrow(bbook);
        }
    }
}
