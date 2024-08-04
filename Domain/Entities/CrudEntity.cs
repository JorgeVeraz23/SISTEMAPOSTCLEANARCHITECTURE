using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class CrudEntity
    {
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool CreatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public string? UpdateBy { get; set; }
       
    }
}
