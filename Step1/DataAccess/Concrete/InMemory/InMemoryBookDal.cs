using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBookDal : IBookDal
    {

        List<Book> _books;
        public InMemoryBookDal()

        {
            _books = new List<Book>

            {
                 new Book{Id = 1, BookName = "Masumiyet Müzesi",    Author = "Orhan Pamuk",        Publisher= "Yapı Kredi Yayınları",     Price = 20, Language = "Turkish", RelaseDate = 2003, Description = "Romantic"},
                 new Book{Id = 2, BookName = "O",                   Author= "Stephan King",        Publisher= "New English Library",      Price = 30, Language = "English", RelaseDate = 2001, Description = "Horror"},
                 new Book{Id = 3, BookName = "Alice In Wonderland", Author= "Lewis Carroll",       Publisher= "Karbon Kİtaplar",          Price = 40, Language = "English", RelaseDate = 2016, Description = "Funny"},
                 new Book{Id = 4, BookName = "Romeo And Juliet",    Author= "William Shakespeare", Publisher= "Samaira Book Publishers",  Price = 50, Language = "English", RelaseDate = 1980, Description = "Theatre"},
                 new Book{Id = 5, BookName = "Wenn Nietzsche Weint",Author= "Irvin D. Yalom ",     Publisher= "Piper Taschenbuch",        Price = 60, Language = "German" , RelaseDate = 2024, Description = "Philosophy"},


            };
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Delete(Book book)
        {
            Book bookForDelete = _books.SingleOrDefault(x => x.Id == book.Id);
            _books.Remove(bookForDelete);
        }

        public List<Book> GetAll()
        {
            return _books.ToList();
        }

        public Book GetById(int bookId)
        {
            return _books.SingleOrDefault(x => x.Id == bookId);
        }

        public void Update(Book book)
        {
            Book bookForUpdate = _books.SingleOrDefault(x => x.Id == book.Id);
            bookForUpdate.Id = book.Id;
            bookForUpdate.BookName = book.BookName;
            bookForUpdate.Price = book.Price;
            bookForUpdate.Language = book.Language;
            bookForUpdate.RelaseDate = book.RelaseDate;
            bookForUpdate.Description = book.Description;

        }
    }

}
