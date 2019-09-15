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
        public string AssetName { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartSale { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndSale { get; set; }
        [EmailAddress]
        public string PublisherEmail { get; set; }
    }
}
