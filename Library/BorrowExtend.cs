using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BorrowExtend : Borrow
    {
        public BorrowExtend(Borrow borrow, DateOnly newExpirationDate)
        {
            this.expirationDate = newExpirationDate;
            this.email = borrow.email;
            this.book = borrow.book;
        }
    }
}
