using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblRoleTask")]
    public class clsRoleTask:clsBaseEntity
    {
        [ForeignKey("clsRole")]
        public Guid RoleId { get; set; }
        public virtual clsRole Role { get; set; }
        [ForeignKey("clsTask")]
        public Guid TaskId { get; set; }
        public virtual clsTask Task { get; set; }
        public ICollection<clsRoleTaskDate> RoleTaskDates { get; set;}
    }
}
