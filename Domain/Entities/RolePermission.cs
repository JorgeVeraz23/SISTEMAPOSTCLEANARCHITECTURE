using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RolePermission : CrudEntity
    {
        [Key]
        public long RolePermissionID { get; set; }
        [ForeignKey("Role")]
        public long RoleId { get; set; }
        [ForeignKey("Permission")]
        public long PermissionID { get; set; }
        public Role? Role { get; set; }
        public Permission? Permission { get; set; }
    }
}
