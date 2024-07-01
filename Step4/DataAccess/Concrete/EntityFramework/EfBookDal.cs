using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookContext>, IBookDal
    {
        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public class EfEntityRepositoryBase<T1, T2>
    {
    }

    internal interface IBookDal
    {
    }
}