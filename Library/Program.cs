namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Titolo","Tizio",10);
            DateOnly date = new DateOnly(2024,06,14);

            Console.WriteLine(book.Copies);
            Borrow borrow = new Borrow(date, "tizio.gmail.com", book);
            Borrow borrow2 = new Borrow(date, "tizio2.gmail.com", book);

            borrow.BorrowStart();
            Console.WriteLine("borrow started " + book.Copies);
            Borrow borrowEmailNotification = new BorrowEmailNotification(borrow);
            Borrow borrowExtended = new BorrowExtend(borrowEmailNotification, date.AddMonths(1));
            Console.WriteLine("borrow extended " + book.Copies);
            borrow.BorrowEnd();
            Console.WriteLine("borrow ended "+book.Copies);
        }
    }
}
