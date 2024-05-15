using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface INotebookDal
    {
        Notebook GetById(int notebookId);
        List<Notebook> GetAll();
        void Add(Notebook notebook);
        void Update(Notebook notebook);
        void Delete(Notebook notebook);
    }
}
