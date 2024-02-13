using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class User
{ 
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username{ get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }

    public User(string id, string firstName, string lastName, string username, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Password = password;
    }

    public bool userlogin()
    {
        return true;
    }

    public abstract void borrowBook();

    public abstract void returnBook();

    public void recordtransaction()
    {

    }
}

