using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Borrow
    {
        public DateOnly expirationDate;

        public string email;

        public Book book;
    }
}
