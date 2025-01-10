using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class librarian:user
    {
        public int Employee_Number { get; set; }
        public librarian(string name)
        {
                Name = name;    
        }

        public void Addbook(Book nbook,Library library )
        {
            library.Add(nbook);
        }
        public void removebook(Book rbook,Library library)
        {
            library.Remove(rbook);
        }
        
    }
}
