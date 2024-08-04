using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payment : CrudEntity
    {
        [Key]
        public long PaymentID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        [ForeignKey("PaymentMethod")]
        public long PaymentMethodID { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
    }
}
