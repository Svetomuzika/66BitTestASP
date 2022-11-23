using System;
using _66BitTest.Models.Entites;

namespace _66BitTest.Models.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Footballer> Footballers { get; }
        void Save();
    }
}
