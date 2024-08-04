using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductTagRelation : CrudEntity
    {
        [Key]
        public long ProductTagRelationID { get; set; }  
        public long ProductID { get; set; }
        public long TagID {  get; set; }
        

        public Product? Product { get; set; }
        public Tag? Tag { get; set; }
    }
}
