using _66BitTest.Models.EF;
using _66BitTest.Models.Entites;
using _66BitTest.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _66BitTest.Models.Repositories
{
    public class FootballerRepository : IRepository<Footballer>
    {
        private ApplicationContext DBContext;

        public FootballerRepository(ApplicationContext context)
        {
            DBContext = context;
        }

        public IEnumerable<Footballer> GetAll()
        {
            return DBContext.Footballers;
        }

        public void Create(Footballer footballer)
        {
            DBContext.Footballers.Add(footballer);
            DBContext.SaveChanges();
        }

        public void Update(Footballer footballer)
        {
            DBContext.Entry(footballer).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Footballer footballer = DBContext.Footballers.Find(id);
            if (footballer != null)
                DBContext.Footballers.Remove(footballer);
        }
    }
}
