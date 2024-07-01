using Core.DataAccess;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMagazineDal : IEntityRepository<Magazine>
    {
        List<BookDetailDto> GetBooketailDtos();
    }
}