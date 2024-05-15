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
    public class NotebookManager : INotebookService { 

        INotebookDal _notebookDal;


        public NotebookManager(INotebookDal notebookDal)
        {
            _notebookDal = notebookDal;
        }

        public void Add(Notebook notebook)
        {
            throw new NotImplementedException();
        }

        public List<Notebook> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}