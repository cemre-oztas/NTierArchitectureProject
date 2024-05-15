using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        BookManager bookManager = new BookManager(new EfBookDal());
        foreach (var book in bookManager.GetBooksByBookId(20))
        {
            Console.WriteLine(book.Description);
        }
        Console.WriteLine("Hello, World!");
    }
}