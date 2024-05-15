using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Notebook : IEntity
    {
        public int Id { get; set; }
        public int NumberOfPages { get; set; }
        public int Price { get; set; }
        public string Design { get; set; }
        public string Description { get; set; }
    }
}