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
    public class EfNotebookDal : EfEntityRepositoryBase<Notebook, BookContext>, INotebookDal
    {
    }

    internal interface INotebookDal
    {
    }
}