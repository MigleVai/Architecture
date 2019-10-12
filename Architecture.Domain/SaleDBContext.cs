using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain
{
    public class SaleDBContext: DbContext
    {
        public SaleDBContext(DbContextOptions<SaleDBContext> options) : base(options) { }

        public DbSet<SaleModel> SaleModels { get; set; }
    }
}
