using _66BitTest.Models.EF;
using _66BitTest.Models.Entites;
using _66BitTest.Models.Interfaces;
using System;

namespace _66BitTest.Models.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext DBContext;
        private FootballerRepository footballerRepository;

        public EFUnitOfWork(ApplicationContext context)
        {
            DBContext = context;
        }

        public IRepository<Footballer> Footballers
        {
            get
            {
                if (footballerRepository == null)
                    footballerRepository = new FootballerRepository(DBContext);
                return footballerRepository;
            }
        }

        public void Save()
        {
            DBContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    DBContext.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
