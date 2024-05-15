using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public readonly string Title;
        public readonly string Author;
        public int Copies;
        public Book(string title, string author, int copies)
        {
            Title = title;
            Author = author;
            Copies = copies;
        }

        public void Borrow() => this.Copies--;
        public void Return() => this.Copies++;


    }
}
