using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

public class Library
{
    List<Member> membercollection;

    // All Books in Library
    public List <Book> Bookcollection
    {
        // Get book records from database and return
        get { return libraryDatabase.getAllBookRecords(); }
    }

    public List<Member> Membercollection
    {
        get { return membercollection; }
        set { membercollection = value; }
    }

    //public List <Book> getAllBooks() 
    //{

    //}

    //public List <Member> getAllMember() 
    //{
        
    //}

    public void addNewBook(Book book)
    {
        // Add given book object into the database using static method
        libraryDatabase.insertRecord<Book>(book, "Books");
    }

    public void removeBook(string isbn)
    {
        // filter book from library database searching for given isbn
        Book book = libraryDatabase.getRecord<Book>("ISBN", isbn, "Books");
        // Delete filtered book
        libraryDatabase.deleteRecord<Book>(book.Id, "Books");
    }

    public List<Book> getAllBooks()
    {
        // Returun all books
        return Bookcollection;
    }
}
