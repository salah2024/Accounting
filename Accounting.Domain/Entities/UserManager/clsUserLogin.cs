using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    public class clsUserLogin:clsBaseEntity
    {
        [ForeignKey("clsUserIdentity")]
        public Guid UserInfoId { get; set; }
        public DateTime dateTime { get; set; }
        public bool Type { get; set; }
        public string IPAddress { get; set; }
        public virtual clsUserInfo UserInfo { get; set; }
    }
}
