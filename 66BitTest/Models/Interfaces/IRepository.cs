using System;
using System.Collections.Generic;

namespace _66BitTest.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        void Create(T item);

        void Update(T item);

        void Delete(int id);
    }
}
