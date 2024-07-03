using Core.Utilities.Result;
using Entities.Concrete;
using Entities.IDTOs;
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
        IDataResult<List<Notebook>> GetAll();

        IDataResult<Notebook> GetById(int notebookId);

        IResult Add(Notebook notebook);

        IResult Update(Notebook notebook);

        IResult Delete(Notebook notebook);

        IDataResult<List<BookDetailDto>> GetNotebookDetails();
    }
}