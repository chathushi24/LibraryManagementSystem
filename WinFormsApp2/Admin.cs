﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

class Admin : User
{
    public Admin(string id, string firstName, string lastName, string username, string password): base (id, firstName, lastName, username, password)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Username = username;
        this.Password = password;
        this.IsAdmin = false;
    }

    public override void borrowBook()
    {

    }

    public override void returnBook()
    {

    }

    //public List<Member> getAllMembers()
    //{
        
    //}

    public void addNewMember()
    {

    }

    public void removeMember() 
    {

    }

    public void editMemberDetails()
    {

    }
}