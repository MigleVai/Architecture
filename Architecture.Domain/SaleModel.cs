using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Domain
{
    public class SaleModel: IValidatableObject
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartSale < DateTime.Now && EndSale < DateTime.Now)
            {
                yield return new ValidationResult("The start and end dates have to be greater than today.");
                
            }
            if (StartSale + TimeSpan.FromDays(15) <= EndSale)
            {
                yield return new ValidationResult("The sale duration must not be more than 2 weeks.");
                
            }
        }
    }
}
