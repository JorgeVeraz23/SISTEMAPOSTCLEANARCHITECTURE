using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Permission : CrudEntity
    {
        [Key]
        public long PermissionId { get; set; }
        public string PermissionName { get; set; } = "";
        public string Description { get; set; } = "";

        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
