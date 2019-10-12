using Architecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Domain.Storage
{
    public class LocalStorage<T>: IStorage<T> where T : class
    {
        private SaleDBContext _context = null;
        private DbSet<T> table = null;

        public LocalStorage(SaleDBContext saleDB)
        {
            _context = saleDB;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T Get(Guid id)
        {
            return table.Find(id);
        }

        public void Add(T obj)
        {
            table.Add(obj);
        }

        public void Remove(Guid id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
