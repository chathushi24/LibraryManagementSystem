using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Transaction
    {
        string id;
        Member member;
        Book book;
        string transactionName;

        public Transaction(Member member, Book book, string transactionName)
        {
            this.member = member;
            this.book = book;
            this.transactionName = transactionName;
        }

        // Assign auto generated unique id from mongodb
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        public Member Member
        { 
            get { return member; } 
            set { member = value; } 
        }

        public Book Book 
        { 
            get { return book; } 
            set { book = value; } 
        }

        public string TransactionName
        {
            get { return transactionName; }
            set { transactionName = value; }
        }
    }
}
