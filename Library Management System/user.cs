﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal abstract class user
    {
        public string Name { get; set; }

        public void DisplayLibrary(Library library)
        {
            library.Display();

        }

         
     
    }
}
