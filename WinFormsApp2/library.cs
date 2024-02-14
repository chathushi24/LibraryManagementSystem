using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

public class Library
{
    List<Book> bookcollection;
    List<Member> membercollection;

    public List <Book> Bookcollection
    {
        get { return bookcollection; }
        set { bookcollection = value; }
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

    public void editBookDetails()
    {
        //libraryDatabase.deleteRecord<>
    }

    public void removeBook(string isbn)
    {
        Book book = libraryDatabase.getRecord<Book>("ISBN", isbn, "Books");
        libraryDatabase.deleteRecord<Book>(book.Id, "Books");
    }
}
