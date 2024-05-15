using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Borrow
    {
        public DateOnly expirationDate;

        public string email;

        public Book book;

        public Borrow(DateOnly expirationDate, string email, Book book)
        {
            this.expirationDate = expirationDate;
            this.email = email;
            this.book = book;
        }

        public void BorrowStart()
        {
            book.Borrow();
        }

        public void BorrowEnd()
        {
            book.Return();
        }
    }

   
}
