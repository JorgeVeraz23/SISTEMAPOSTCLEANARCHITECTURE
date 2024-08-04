using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMethod : CrudEntity
    {
        [Key]
        public long PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; } = "";
        public string Description { get; set; } = "";

        public ICollection<Payment>? Payments { get; set; }




    }
}
