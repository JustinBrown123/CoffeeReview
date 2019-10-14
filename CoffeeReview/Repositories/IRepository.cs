using System.Collections.Generic;
using CoffeeReview.Models;

namespace CoffeeReview.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(T obj);
        //void Update(T obj);
    }
}