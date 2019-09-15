using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Models
{
    public class SaleModel
    {
        public Guid Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string AssetName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartSale { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime EndSale { get; set; } = DateTime.Now + TimeSpan.FromDays(14);

        [EmailAddress]
        public string PublisherEmail { get; set; }
    }
}
