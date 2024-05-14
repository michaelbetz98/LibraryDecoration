using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowStart : Borrow
    {
        public BorrowStart(DateOnly expirationDate, string email, Book book)
        {
            this.expirationDate = expirationDate;
            this.email = email;
            this.book = book;
            book.Copies--;
        }
    }
}
