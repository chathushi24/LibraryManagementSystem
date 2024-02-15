using System.Transactions;

public class Book
{
    string id;
    string author;
    string title;
    string iSBN;
    int publishedyear;
    bool availability;
    string borrowedBy;

    public Book(string id, string author, string title, string iSBN, int publishedyear)
    {
        this.id = id;
        this.author = author;
        this.title = title;
        this.iSBN = iSBN;
        this.publishedyear = publishedyear;
        this.availability = true;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string ISBN
    {
        get { return iSBN; }
        set { iSBN = value; }
    }

    public int Publishedyear
    {
        get { return publishedyear; }
        set { publishedyear = value; }
    }

    public bool Availability
    {
        get { return availability; }
        set { availability = value; }
    }

    public void borrowBook(Member member)
    {
        // Check availability
        if (this.availability)
        {
            // If member is not already borrowed the book update database
            if (!member.BorrowedBooks.Exists(book => book.id == this.id))
            {
                // Set the borrowed member id in the book object
                this.borrowedBy = member.Id;

                // Change availability
                this.availability = false;

                // Add book into the member object borrowed book list
                member.BorrowedBooks.Add(this);

                // Update both book and member in the database using static methods
                libraryDatabase.updateRecord<Book>(this.Id, "Books", this);
                libraryDatabase.updateRecord<User>(member.Id, "Users", member);

                // Use name space before class name to avoid the name violation of system.Transaction
                WinFormsApp2.Transaction transaction = new WinFormsApp2.Transaction(member, this, "Borrow Book");
                libraryDatabase.insertRecord<WinFormsApp2.Transaction>(transaction, "Transactions");
                MessageBox.Show("Successfully issued the book !", " Issue book", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // If book is exists in members borrowed book list show error message
                MessageBox.Show("Book is already borrowed", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            // If book is not available show error message
            MessageBox.Show("Book is not available", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    public void returnBook(Member member)
    {
        // Search in the members borrowed book list if member borrowed the book
        // If member is not borrowed the book show error message
        if (!member.BorrowedBooks.Exists(book => book.id == this.id))
        {
            MessageBox.Show("Book is not borrowed", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            // When borrowing the book remove borrowed member id from the book object
            this.borrowedBy = "";

            // Set availability to true
            this.availability = true;

            // Remove book object from the member's borrowed book list
            member.BorrowedBooks.RemoveAll(book => book.id == this.id);

            // Update both book and member in the database
            libraryDatabase.updateRecord<Book>(this.Id, "Books", this);
            libraryDatabase.updateRecord<User>(member.Id, "Users", member);

            // Use name space before class name to avoid the name violation of system.Transaction
            WinFormsApp2.Transaction transaction = new WinFormsApp2.Transaction(member, this, "Return Book");
            libraryDatabase.insertRecord<WinFormsApp2.Transaction>(transaction, "Transactions");

            MessageBox.Show("Successfully Returned the book !", " Return book", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}