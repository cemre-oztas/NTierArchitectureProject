using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryMagazineDal : IMagazineDal
    {
        List<Magazine> _magazines;
        public InMemoryMagazineDal()

        {
            _magazines = new List<Magazine>

            {
                 new Magazine{Id = 1, MagazineName = "VOGUE",               Publisher= "Condé Nast",                  Price = 20, Language = "French",   RelaseDate = 1996, Description = "Fashion"},
                 new Magazine{Id = 2, MagazineName = "NATIONAL GEOGRAPHIC", Publisher= "Penguin Random House",        Price = 30, Language = "English",  RelaseDate = 1980, Description = "Documentary"},                 
                 new Magazine{Id = 3, MagazineName = "BILIM & TEKNIK",      Publisher= "TÜBİTAK",                     Price = 40, Language = "English",  RelaseDate = 2014, Description = "Science"},
                 new Magazine{Id = 4, MagazineName = "Araştırmacı Çocuk",   Publisher= "Araştırmacı Çocuk Merkezi ",  Price = 50, Language = "Turkish",  RelaseDate = 2015, Description = "Children's Magazine"},
                 new Magazine{Id = 5, MagazineName  = "HECE",               Publisher= " Hece Yayınları",             Price = 60, Language = "Turkish" , RelaseDate = 2005, Description = "Literature"},


            };
        }

        public void Add(Magazine magazine)
        {
            _magazines.Add(magazine);
        }

        public void Delete(Magazine magazine)
        {
            Magazine magazineForDelete = _magazines.SingleOrDefault(x => x.Id == magazine.Id);
            _magazines.Remove(magazineForDelete);
        }

        public List<Magazine> GetAll()
        {
            return _magazines.ToList();
        }

        public Magazine GetById(int magazineId)
        {
            return _magazines.SingleOrDefault(x => x.Id == magazineId);
        }

        public void Update(Magazine magazine)
        {
            Magazine magazineForUpdate = _magazines.SingleOrDefault(x => x.Id == magazine.Id);
            magazineForUpdate.Id = magazine.Id;
            magazineForUpdate.MagazineName = magazine.MagazineName;
            magazineForUpdate.Price = magazine.Price;
            magazineForUpdate.Language = magazine.Language;
            magazineForUpdate.RelaseDate = magazine.RelaseDate;
            magazineForUpdate.Description = magazine.Description;
        }
    }
}
