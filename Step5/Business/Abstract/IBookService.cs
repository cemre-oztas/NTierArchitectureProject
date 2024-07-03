using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetBookByBookId(int id);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
    }

    public interface IResult
    {
    }

    public interface IDataResult<T>
    {
    }
}