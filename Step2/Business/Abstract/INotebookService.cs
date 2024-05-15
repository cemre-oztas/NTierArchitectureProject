using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INotebookService
    {
        List<Notebook> GetAll();
        void Add(Notebook notebook);
    }
}