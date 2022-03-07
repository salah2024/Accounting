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
    [Table("tblTask")]
    public class clsTask:clsBaseEntity
    {
        public Guid ParentId { get;set; }
        [Display(Name="عنوان وظیفه")]
        [MaxLength(50)]
        [Required]
        public string Name { get;set; }
        [Display(Name = "لاتین")]
        [MaxLength(50)]
        [Required]
        public string LatinName { get;set; }
        [Display(Name = "توضیحات")]
        [MaxLength(200)]
        public string Description { get;set; }
        public ICollection<clsRoleTask> RoleTasks { get;set; }
    }
}
