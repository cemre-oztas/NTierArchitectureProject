using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMagazineDal : EfEntityRepositoryBase<Magazine, BookContext>, IMagazineDal
    {
        public List<BookDetailDto> GetBooketailDtos()
        {
            throw new NotImplementedException();
        }

        public List<BookDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}