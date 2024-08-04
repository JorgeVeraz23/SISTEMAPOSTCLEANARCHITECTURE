using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : CrudEntity
    {
        [Key]
        public long ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = "";
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int Stock { get; set; }
        [ForeignKey("Category")]
        public long CategoryID { get; set; }

        public Category? Category { get; set; } 

        public ICollection<ProductTagRelation>? ProductTagRelations { get; set; }    


    }
}
