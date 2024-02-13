class Book
{
    string id;
    string author;
    string title;
    string iSBN;
    int copies;
    string publishedyear;
    bool availability;

    public Book(string id, string author, string title, string iSBN, string publishedyear, bool availability, int copies = 1)
    {
        this.id = id;
        this.author = author;
        this.title = title;
        this.iSBN = iSBN;
        this.copies = copies;
        this.publishedyear = publishedyear;
        this.availability = availability;
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

    public int Copies
    {
        get { return copies; }
        set { copies = value; }
    }

    public string Publishedyear
    {
        get { return publishedyear; }
        set { publishedyear = value; }
    }

    public bool Availability
    {
        get { return availability; }
        set { availability = value; }
    }
}