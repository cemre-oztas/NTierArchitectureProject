using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MagazineManager : IMagazineService
    {
        IMagazineDal _magazineDal;

        public MagazineManager(IMagazineDal magazineDal)
        {
            _magazineDal = magazineDal;
        }

        public List<Magazine> GetAll()
        {
            return _magazineDal.GetAll();
        }
    }
}
