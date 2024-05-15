using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book: IEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }
        public string Language { get; set; }
        public int RelaseDate { get; set; }
        public string Description { get; set; }

    }
}
