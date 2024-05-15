using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryNotebookDal : INotebookDal
    {

        List<Notebook> _notebooks;
        public InMemoryNotebookDal()

        {
            _notebooks = new List<Notebook>

            {
                 new Notebook{Id = 1, NumberOfPages = 50,   Price = 100,   Design = "checkered", Description = "Flat Cover"},
                 new Notebook{Id = 2, NumberOfPages = 70,   Price = 120,   Design = "lined",     Description = "Leather Cover"},
                 new Notebook{Id = 3, NumberOfPages = 80,   Price = 140,   Design = "checkered", Description = "Flat Cover"},
                 new Notebook{Id = 4, NumberOfPages = 120,  Price = 150,   Design = "dotted",    Description = "Leather Cover"},
                 new Notebook{Id = 5, NumberOfPages = 90,   Price = 130,   Design = "lined",     Description = "Flat Cover"},              


            };
        }

        public void Add(Notebook notebook)
        {
            _notebooks.Add(notebook);
        }

        public void Delete(Notebook notebook)
        {
            Notebook notebookForDelete = _notebooks.SingleOrDefault(x => x.Id == notebook.Id);
            _notebooks.Remove(notebookForDelete);
        }

        public List<Notebook> GetAll()
        {
            return _notebooks.ToList();
        }

        public Notebook GetById(int notebookId)
        {
            return _notebooks.SingleOrDefault(x => x.Id == notebookId);
        }

        public void Update(Notebook notebook)
        {
            Notebook notebookForUpdate = _notebooks.SingleOrDefault(x => x.Id == notebook.Id);
            notebookForUpdate.Id = notebook.Id;
            notebookForUpdate.NumberOfPages = notebook.NumberOfPages;
            notebookForUpdate.Price = notebook.Price;
            notebookForUpdate.Design = notebook.Design;
            notebookForUpdate.Description = notebook.Description;
        }
    }
}
