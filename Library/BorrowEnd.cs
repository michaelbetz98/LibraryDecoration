using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowEnd : Borrow
    {
        public BorrowEnd(Borrow borrow)
        {
            this.book = borrow.book;
            this.expirationDate = borrow.expirationDate;
            this.email = borrow.email;
            book.Copies++;
        }
    }
}
