using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

         public BookManager(IBookDal bookDal)
         {
             _bookDal = bookDal;
         }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        
    }

     
}
