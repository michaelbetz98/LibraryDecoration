namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Titolo","Tizio",10);
            DateOnly date = new DateOnly(2024,06,14);
            Borrow borrow = new BorrowStart(date, "tizio.gmail.com", book);
            Console.WriteLine(book.Copies);
            BorrowExtend borrowExtend = new BorrowExtend(borrow, date.AddMonths(1));
            Console.WriteLine(book.Copies);
            BorrowEnd borrowEnd = new BorrowEnd(borrowExtend);
            Console.WriteLine(book.Copies);
        }
    }
}
