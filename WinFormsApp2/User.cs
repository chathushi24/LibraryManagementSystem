﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(Member), typeof(Admin))]
public abstract class User
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

    public bool userlogin(string username, string password)
    {
        if (this.Username == username && this.Password == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void borrowBook(Book book, Member member)
    {
        book.borrowBook(member);
    }

    public void returnBook(Book book, Member member)
    {
        book.returnBook(member);
    }
}

