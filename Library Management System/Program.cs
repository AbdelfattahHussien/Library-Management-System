namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Library System");
            var library = new Library();
            
                Console.WriteLine("Are you librarian or user ?");
                Console.WriteLine("Please IF you librarian ENTER --> L");
                Console.WriteLine("Please IF you user ENTER --> R");
                Console.WriteLine("Exit --> E");


                //input from user
                var input = Console.ReadLine().ToUpper()[0];

                if (input == 'L')
                {
                    Console.Write("Welcome Librarian,Enter Name:");
                    string name = Console.ReadLine();

                    var lib = new librarian(name);   //new object from librarian

                    Console.WriteLine($"Welcome {lib.Name}");
                    while (true)
                    {
                        Console.WriteLine("please choose to Add book(A) / Remove book(R) / Display books(D) / Exit(E)");
                        char choise = Console.ReadLine().ToUpper()[0];

                        switch (choise)
                        {
                            case 'A':
                                Console.WriteLine("Enter Book Details ");
                                Console.Write("Enter book title:");
                                var booktitle = Console.ReadLine();
                                Console.Write("Enter book author");
                                var bookauthor = Console.ReadLine();
                                Console.Write("Enter book year");
                                int bookyear = int.Parse(Console.ReadLine());

                                var book = new Book()
                                {
                                    title = booktitle,
                                    author = bookauthor,
                                    year = bookyear
                                };
                                lib.Addbook(book, library);

                                break;
                            case 'R':
                                Console.WriteLine("Enter Book Details to remove");
                                Console.Write("Enter book title:");
                                booktitle = Console.ReadLine();
                                Console.Write("Enter book author");
                                bookauthor = Console.ReadLine();
                                Console.Write("Enter book year");
                                bookyear = int.Parse(Console.ReadLine());

                                book = new Book()
                                {
                                    title = booktitle,
                                    author = bookauthor,
                                    year = bookyear
                                };
                                lib.removebook(book, library);
                                break;
                            case 'D':
                                Console.WriteLine("The Book List");
                                lib.DisplayLibrary(library);
                                break;
                            case 'E':
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Please,Enter the correct value(A/R/D/E)");
                                break;
                        }
                    }

                }
                else if (input == 'R')
                {
                Console.Write("Welcome user,Enter Name:");
                string uname = Console.ReadLine();
                libraryuser libuser =new libraryuser(uname);
                Console.WriteLine($"Welcome {libuser.Name}");
                while(true)
                {
                    Console.WriteLine("Please Choose to Display books(D) / Borrow Book(B) / Exit(E)");
                    var choise = Console.ReadLine().ToUpper()[0];
                    switch(choise)
                    {
                        case 'D':
                            Console.WriteLine("The Book List");
                            libuser.DisplayLibrary(library);

                            break;
                        case 'B':
                            Console.WriteLine("Enter Book Details to Borrow ");
                            Console.Write("Enter book title:");
                            var booktitle = Console.ReadLine();
                            Console.Write("Enter book author");
                            var bookauthor = Console.ReadLine();
                            Console.Write("Enter book year");
                            int bookyear = int.Parse(Console.ReadLine());
                            var book = new Book()
                            {
                                title = booktitle,
                                author = bookauthor,
                                year = bookyear
                            };
                            libuser.BorrowBook(book,library);
                            break;
                        case 'E':
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please Enter (D / B / E)");
                            break;
                    }
                     

                }

            }
            else if (input == 'E')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please,Enter the correct value(L/R/E)");
                }



            
        }
    }
}
