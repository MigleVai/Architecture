using Architecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Storage
{
    public interface IStorage
    {
        void Add(SaleModel sale);
        SaleModel Get(Guid id);
        List<SaleModel> GetAll();
        void Remove(Guid id);
    }
}
