using Accounting.Domain.Entities.Commons;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblUserInRole")]
    public class clsUserInRole:clsBaseEntity
    {
        [ForeignKey("clsUserInfo")]
        public Guid UserInfoId { get; set; }
        public virtual clsUserInfo UserInfo { get; set; }
        [ForeignKey("clsRole")]
        public Guid RoleId { get; set; }
        public virtual clsRole Role { get; set; }
        public bool IsActive { get; set; }
    }
}
