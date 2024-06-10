using E_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DAL._GenericRepository
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly ECommerceContext _ecommerceContext;

        public GenericRepository(ECommerceContext ecommerceContext)
        {
            _ecommerceContext = ecommerceContext;
            _dbSet = _ecommerceContext.Set<T>();
        }
        public T Add(T t)
        {
            var result = _dbSet.Add(t);
            _ecommerceContext.SaveChanges();
            return t;

        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public T Update(T t)
        {
            _dbSet.Update(t);
            try
            {
                _ecommerceContext.SaveChanges();

            }
            catch
            {

            }
            return t;
        }
        public bool Delete(T t)
        {
            _dbSet.Remove(t);
            try
            {
                _ecommerceContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            var entity = GetById(id);

            return Delete(entity);

        }

    }
}
