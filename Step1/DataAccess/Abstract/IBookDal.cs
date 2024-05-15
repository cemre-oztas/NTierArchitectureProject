using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBookDal
    {
        Book GetById(int bookId);
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
