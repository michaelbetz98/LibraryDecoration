using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BorrowExtend : Borrow
    {
        public BorrowExtend(Borrow borrow, DateOnly newExpirationDate) : base(newExpirationDate, borrow.email, borrow.book)
        {
        }

        //metodo estensione-- non posso metterlo perche non c'è nela classe Borrow, posso fare solo tramite costruttoie

    }
}
