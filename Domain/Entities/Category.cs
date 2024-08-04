using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : CrudEntity
    {
        [Key]
        public long CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty; 
        public string? Descripcion { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
