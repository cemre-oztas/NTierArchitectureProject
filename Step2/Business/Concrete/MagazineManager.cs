using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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


        public void Add(Magazine magazine)
        {
            throw new NotImplementedException();
        }

        public List<Magazine> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}