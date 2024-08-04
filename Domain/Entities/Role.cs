using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role : CrudEntity
    {
        [Key]
        public long IdRole { get; set; }
        public string RolName { get; set; } = "";
        public string Description { get; set; } = "";

        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
