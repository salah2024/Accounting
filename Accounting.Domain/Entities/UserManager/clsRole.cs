using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblRole")]
    public class clsRole:clsBaseEntity
    {
        [Required]
        [Display(Name = "عنوان نقش")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(200)]
        public string Description { get; set; }
        public virtual ICollection<clsUserInRole> UserInRoles { get; set;}
        public virtual ICollection<clsRoleTask> RoleTasks { get; set; }
    }
}
