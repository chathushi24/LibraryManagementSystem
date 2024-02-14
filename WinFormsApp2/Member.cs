using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Member : User
{
    public List<Book> BorrowedBooks { get; set; }

    public Member(string id, string firstName, string lastName, string username, string password) :
        base(id, firstName, lastName, username, password)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Username = username;
        this.Password = password;
        this.IsAdmin = false;
        BorrowedBooks = new List<Book>();
    }

}