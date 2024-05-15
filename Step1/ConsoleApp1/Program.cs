using Business.Concrete;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        BookManager bookManager = new BookManager(new InMemoryBookDal());

        foreach (var returnedBook in bookManager.GetAll())
        {
            Console.WriteLine(returnedBook.Description);
        }
        Console.WriteLine("Hello, World!");
    }
}