using MongoDB.Driver;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Libmongocrypt;


namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int option = 0;
            do
            {
                try
                {
                    // Main menu
                    Console.Clear();
                    Console.WriteLine("Library Management System");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Windows Form Application");
                    Console.WriteLine("\t2. Console Application");
                    Console.WriteLine("\t3. Exit");
                    Console.WriteLine();
                    Console.Write("Select an option: ");
                    option = int.Parse(Console.ReadLine());

                    // Check user choice to run gui or console application
                    switch (option)
                    {
                        // Run GUI Application
                        case 1:
                            // To customize application configuration such as set high DPI settings or default font,
                            // see https://aka.ms/applicationconfiguration.
                            ApplicationConfiguration.Initialize();
                            Application.Run(new login());
                            break;

                        case 2:
                            // Run console application
                            consoleApplication();
                            break;

                        case 3:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Option!");
                    Console.ReadKey();
                }


            }
            while (option != 3);
        }

        // Static method to run console application
        static void consoleApplication()
        {
            do
            {
                // Clear console
                Console.Clear();
                // Get users from library database
                List<User> users = libraryDatabase.getAllRecords<User>("Users");
                Console.WriteLine("Library Management System!");
                Console.WriteLine();
                Console.Write("\tUsername: ");
                string username = Console.ReadLine();
                Console.Write("\tPassword: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                // Get target user to login
                User user = users.Find(u => u.Username == username);
                if (user != null)
                {
                    // Check whether the user name and password is correct
                    if (user.userlogin(username, password))
                    {
                        // If user is librarian open librarians menu
                        if (user.IsAdmin)
                        {
                            librarianInterface(user as Admin);
                            break;
                        }
                        else
                        {
                            memberInterface(user as Member);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username or password");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect username or password");
                    Console.ReadKey();
                }


            }
            while (true);

        }

        static void librarianInterface(Admin librarian)
        {
            Library library = new Library();

            int option = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {librarian.FirstName}");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Search Books");
                    Console.WriteLine("\t2. Add Book");
                    Console.WriteLine("\t3. Remove Book");
                    Console.WriteLine("\t4. Add Member");
                    Console.WriteLine("\t5. Remove Member");
                    Console.WriteLine("\t6. Return Books");
                    Console.WriteLine("\t7. Issue Books");
                    Console.WriteLine("\t8. View Transactions");
                    Console.WriteLine("\t9. Exit");
                    Console.WriteLine();
                    Console.Write("Select an option: ");
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            searchBooks(library);
                            break;
                        case 2:
                            addBook(library);
                            break;
                        case 3:
                            removeBook(library);
                            break;
                        case 4:
                            addMember(librarian);
                            break;
                        case 5:
                            removeMember(librarian);
                            break;
                        case 6:
                            returnBook(librarian);
                            break;
                        case 7:
                            issueBook(librarian);
                            break;
                        case 8:
                            showTransactions(librarian);
                            break;
                        case 9:
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid option!");
                    Console.ReadKey();
                }
            }
            while (option != 9);
        }

        static void searchBooks(Library library)
        {
            try
            {
                Book result;
                string title;
                string isbn;
                string id;

                Console.WriteLine("Search Books");
                Console.WriteLine();
                Console.WriteLine("\t1. Search By title");
                Console.WriteLine("\t2. Search By ISBN");
                Console.WriteLine("\t3. Search By ID");
                Console.WriteLine();
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Search book by title");
                        Console.WriteLine();
                        Console.Write("\tTitle: ");
                        title = Console.ReadLine();
                        Console.WriteLine();
                        result = library.getAllBooks().Find(b => b.Title == title);
                        if (result != null)
                        {
                            Console.WriteLine($"ID: {result.Id}");
                            Console.WriteLine($"Title: {result.Title}");
                            Console.WriteLine($"ISBN: {result.ISBN}");
                            Console.WriteLine($"Author: {result.Author}");
                            Console.WriteLine($"Availability: {result.Availability.ToString()}");

                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Search book by ISBN");
                        Console.WriteLine();
                        Console.Write("\tISBN: ");
                        isbn = Console.ReadLine();
                        Console.WriteLine();
                        result = library.getAllBooks().Find(b => b.ISBN == isbn);
                        if (result != null)
                        {
                            Console.WriteLine($"ID: {result.Id}");
                            Console.WriteLine($"Title: {result.Title}");
                            Console.WriteLine($"ISBN: {result.ISBN}");
                            Console.WriteLine($"Author: {result.Author}");
                            Console.WriteLine($"Availability: {result.Availability.ToString()}");

                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Search book by ID");
                        Console.WriteLine();
                        Console.Write("\tID: ");
                        id = Console.ReadLine();
                        Console.WriteLine();
                        result = library.getAllBooks().Find(b => b.Id == id);
                        if (result != null)
                        {
                            Console.WriteLine($"ID: {result.Id}");
                            Console.WriteLine($"Title: {result.Title}");
                            Console.WriteLine($"ISBN: {result.ISBN}");
                            Console.WriteLine($"Author: {result.Author}");
                            Console.WriteLine($"Availability: {result.Availability.ToString()}");

                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid Option!");
                        Console.ReadKey();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Option!");
                Console.ReadKey();
            }
        }

        static void memberInterface(Member member)
        {
            Library library = new Library();

            int option = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {member.FirstName}");
                    Console.WriteLine();
                    Console.WriteLine("\t1. Search Books");
                    Console.WriteLine("\t2. Return Books");
                    Console.WriteLine("\t3. Borrow Books");
                    Console.WriteLine("\t4. View Borrowed Books");
                    Console.WriteLine("\t5. Exit");
                    Console.WriteLine();
                    Console.Write("Select an option: ");
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            searchBooks(library);
                            break;

                        case 2:
                            returnBook(member);
                            break;
                        case 3:
                            issueBook(member);
                            break;
                        case 4:
                            viewBorrowedBooks(member);
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid option!");
                    Console.ReadKey();
                }
            }
            while (option != 5);
        }

        static void addBook(Library library)
        {
            string title;
            string id;
            string isbn;
            string author;
            int publishedYaer;

            try
            {
                Console.Clear();
                Console.WriteLine("Add books");
                Console.WriteLine();
                Console.Write("\tId: ");
                id = Console.ReadLine();
                Console.Write("\tTitle ");
                title = Console.ReadLine();
                Console.Write("\tISBN: ");
                isbn = Console.ReadLine();
                Console.Write("\tAuthor: ");
                author = Console.ReadLine();
                Console.Write("\tPublished Year: ");
                publishedYaer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Book newbook = new Book(id, author, title, isbn, publishedYaer);
                library.addNewBook(newbook);

            }
            catch
            {
                Console.WriteLine("Please enter valid inputs!");
                Console.ReadKey();
            }
        }

        static void removeBook(Library library)
        {
            Console.WriteLine("Remove Book");
            Console.WriteLine();
            Console.Write("\tISBN: ");
            string isbn = Console.ReadLine();
            

            if (isbn.Trim() == "")
            {
                Console.WriteLine("Please enter valid Details!");
                Console.ReadKey();
            }
            else
            {
                library.removeBook(isbn);
            }
        }

        static void addMember(Admin librarian)
        {
            string id;
            string fname;
            string lname;
            string uname;
            string password;

            Console.Clear();
            Console.WriteLine("Add New Member");
            Console.WriteLine();
            Console.Write("\tId: ");
            id = Console.ReadLine();
            Console.Write("\tFirst Name ");
            fname = Console.ReadLine();
            Console.Write("\tLast Name: ");
            lname = Console.ReadLine();
            Console.Write("\tUser name: ");
            uname = Console.ReadLine();
            Console.Write("\tPassword: ");
            password = Console.ReadLine();
            Console.WriteLine();


            if (id.Trim() == "" || fname.Trim() == "" || lname.Trim() == "" || uname.Trim() == "" || password.Trim() == "")
            {
                Console.WriteLine("Please enter valid inputs!");
                Console.ReadKey();
            }
            else
            {
                Member member = new Member(id, fname, lname, uname, password);
                librarian.addNewMember(member);
            }
        }

        static void removeMember(Admin librarian)
        {
            Console.WriteLine("Remove Member");
            Console.WriteLine();
            Console.Write("\tMember ID: ");
            string id = Console.ReadLine();
            librarian.removeMember(id);
        }

        static void showTransactions(Admin librarian)
        {
            List<WinFormsApp2.Transaction> transactions = librarian.readTransactions();

            if (transactions != null)
            {
                Console.Clear();
                Console.WriteLine("Transactions");
                Console.WriteLine();
                foreach (WinFormsApp2.Transaction transaction in transactions)
                {
                    Console.WriteLine($"ID: {transaction.Id}");
                    Console.WriteLine($"Date: {transaction.Date}");
                    Console.WriteLine($"Activity: {transaction.TransactionName}");
                    Console.WriteLine($"Member: {transaction.Member.FirstName}");
                    Console.WriteLine($"Book: {transaction.Book.Title}");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No transactions");
                Console.ReadKey();
            }
        }

        static void issueBook(User user)
        {
            string isbn;
            Book book;
            string memberID;
            Member member;

            Console.WriteLine("Borrow Books");
            Console.WriteLine();
            if (user.IsAdmin)
            {
                Console.Write("\tMember ID: ");
                memberID = Console.ReadLine();
                Console.Write("\tISBN: ");
                isbn = Console.ReadLine();
                book = libraryDatabase.getAllBookRecords().Find(b => b.ISBN == isbn);
                member = libraryDatabase.getRecord<User>("Id", memberID, "Users") as Member;

                if (member == null || book == null)
                {
                    Console.WriteLine("Member id or ISBN number is invalid!");
                    Console.ReadKey();
                }
                else
                {
                    user.borrowBook(book, member);
                }
            }
            else
            {
                Console.Write("\tISBN: ");
                isbn = Console.ReadLine();
                book = libraryDatabase.getAllBookRecords().Find(b => b.ISBN == isbn);

                if (book != null)
                {
                    user.borrowBook(book, user as Member);
                }
                else
                {
                    Console.WriteLine("Book not found!");
                    Console.ReadKey();
                }
            }

        }

        static void returnBook(User user)
        {
            string isbn;
            Book book;
            string memberID;
            Member member;

            Console.WriteLine("Return Books");
            Console.WriteLine();
            if (user.IsAdmin)
            {
                Console.Write("\tMember ID: ");
                memberID = Console.ReadLine();
                Console.Write("\tISBN: ");
                isbn = Console.ReadLine();
                book = libraryDatabase.getAllBookRecords().Find(b => b.ISBN == isbn);
                member = libraryDatabase.getRecord<User>("Id", memberID, "Users") as Member;

                if (member == null || book == null)
                {
                    Console.WriteLine("Member id or ISBN number is invalid!");
                    Console.ReadKey();
                }
                else
                {
                    user.returnBook(book, member);
                }
            }
            else
            {
                Console.Write("\tISBN: ");
                isbn = Console.ReadLine();
                book = libraryDatabase.getAllBookRecords().Find(b => b.ISBN == isbn);

                if (book != null)
                {
                    user.returnBook(book, user as Member);
                }
                else
                {
                    Console.WriteLine("Book not found!");
                    Console.ReadKey();
                }
            }
        }

        static void viewBorrowedBooks(Member member)
        {
            Console.Clear();
            Console.WriteLine($"{member.FirstName} : Borrowed Books");
            Console.WriteLine();
            List<Book> borrowedBooks = member.BorrowedBooks;

            if (borrowedBooks.Count <= 0)
            {
                Console.WriteLine("Member not borrowed any book!");
            }
            else
            {
                foreach(Book book in borrowedBooks)
                {
                    Console.WriteLine($"ID: {book.Id}");
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"ISBN: {book.ISBN}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Published Year: {book.Publishedyear}");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}