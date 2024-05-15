using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowEmailNotification : Borrow
    {
        public BorrowEmailNotification(Borrow borrow) : base(borrow.expirationDate, borrow.email, borrow.book)
        {
        }

        public string EmailNotification()
        {
            return $"You have to return the book {book.Title}, the return date was {expirationDate}";
        }
    }
}
