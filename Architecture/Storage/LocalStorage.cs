using Architecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Storage
{
    public class LocalStorage : IStorage
    {
        public static List<SaleModel> SaleList = new List<SaleModel>();

        public void Add(SaleModel sale)
        {
            SaleList.Add(sale);
        }

        public SaleModel Get(Guid id)
        {
            return SaleList.FirstOrDefault(a => a.Id == id);
        }

        public List<SaleModel> GetAll()
        {
            return SaleList;
        }

        public void Remove(Guid id)
        {
            SaleList.RemoveAll(a => a.Id == id);
        }
    }
}
