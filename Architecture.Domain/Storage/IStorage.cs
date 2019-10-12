using Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Domain.Storage
{
    public interface IStorage<T> where T: class
    {
        void Add(T sale);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        void Remove(Guid id);
        void Save();
    }
}
