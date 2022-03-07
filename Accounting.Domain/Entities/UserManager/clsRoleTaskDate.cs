using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblRoleTaskDate")]
    public class clsRoleTaskDate:clsBaseEntity
    {
        public virtual clsRoleTask RoleTask { get; set; }
        public string DaysNum { get;set; }
        public DateTime FromDate { get;set; }
        public DateTime ToDate { get;set; } 
    }
}
