using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Magazine magazine);
        IResult Update(Magazine magazine);
        IDataResult<Magazine> GetbyId(int magazineId);
        IDataResult<List<Magazine>> GetAll();
        IResult Delete(Magazine magazine);

    }
}