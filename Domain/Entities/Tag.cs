using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tag : CrudEntity
    {
        [Key]
        public long TagId { get; set; }
        [Required]
        public string TagName { get; set; } = "";
        public string? Description { get; set; }

        public virtual ICollection<ProductTagRelation>? ProductTagRelations { get; set; }    
    }
}
