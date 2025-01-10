using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Library
    {
        private List<Book> books =new List<Book>() ;
        private int CurrentBookCount=0;
        private List<Book> borrowedbooks = new List<Book>();
        private int CurrentBowrredBookCount=0;


        internal void Add(Book book)
        {
            if (CurrentBookCount < 100)
            {

                books.Add(book);
                CurrentBookCount++;
                Console.WriteLine("Book added successflly");

            }
            else
            {
                Console.WriteLine("Library is Full,can't add new books");
            }
            

        }
        internal void Remove(Book book)
        {
            books.Remove(book);
            CurrentBookCount--;
            Console.WriteLine("Book Removed");


        }
        internal void Display()
        {
            foreach(Book book in books)
            {

                Console.WriteLine($"Title:{book.title}");
                Console.WriteLine($"Author:{book.author}");
                Console.WriteLine($"Year:{book.year}");
                Console.WriteLine("*********************************");
            }
        }

        public void Borrow(Book book)
        {
            if (CurrentBowrredBookCount<20)
            {
                books.Remove(book);
                borrowedbooks.Add(book);
                CurrentBowrredBookCount++;
                Console.WriteLine("the book borrowed successfully");
            }
            else
            {
                Console.WriteLine("sorry can't borrow more 20 books");
            }
        }

    }
}
