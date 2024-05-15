using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMagazineDal
    {
        Magazine GetById(int magazineId);
        List<Magazine> GetAll();
        void Add(Magazine magazine);
        void Update(Magazine magazine);
        void Delete(Magazine magazine);
    }
}