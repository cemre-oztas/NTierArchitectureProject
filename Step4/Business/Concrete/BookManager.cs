using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.Build.Tasks;
using Salesforce.Common.Models.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        EfBookDal _bookDal;
        public BookManager(EfBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        
        public IResult Add(Book book)
        {
            if (book.BookName!.Length < 5)
            {
                return new ErrorResult(Message.BookNameInvalid);
            }
            _bookDal.Add(book);
            return new SuccessResult(Message.BookAdded);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Message.BookDeleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<List<Book>> GetBookByBookId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Book> GetBooksByBookId()
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p => p.Id == bookId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Message.BookUpdated);
        }
    }

    internal class SuccessDataResult<T> : IDataResult<List<Book>>
    {
    }

    internal class SuccessResult : IResult
    {
        public SuccessResult(object bookDeleted)
        {
        }
    }
}