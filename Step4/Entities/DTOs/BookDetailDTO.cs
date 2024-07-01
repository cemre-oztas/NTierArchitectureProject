using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IDTOs
{
    public class BookDetailDto : IDto
    {
        public string BookName { get; set; }
        public string NotebookName { get; set; }
        public int RelaseDate { get; set; }
        public string MagazineName { get; set; }
        public string Language { get; set; }
    }

    public interface IDto
    {
    }
}