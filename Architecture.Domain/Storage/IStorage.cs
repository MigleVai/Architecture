using Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Domain.Storage
{
    public interface IStorage
    {
        void Add(SaleModel sale);
        SaleModel Get(Guid id);
        List<SaleModel> GetAll();
        void Remove(Guid id);
    }
}
