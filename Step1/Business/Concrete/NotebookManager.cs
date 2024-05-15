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
    public class NotebookManager : INotebookService
    {
        INotebookDal notebookDal;

        public NotebookManager(INotebookDal notebookDal)
        {
            notebookDal = notebookDal;
        }   

        public List<Notebook> GetAll()
        {
            return  notebookDal.GetAll();
        }
    }
}
