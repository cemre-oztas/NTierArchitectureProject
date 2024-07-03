using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static object bookManager;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BookManager rentalManager = new BookManager(new EfBookDal());
        var Result = bookManager.Add(new Book { Id = 1581, BookId = 1, BookName = "Masumiyet Müzesi", Language = "İngilizce", Author="Orhan Pamuk" });
    }
}