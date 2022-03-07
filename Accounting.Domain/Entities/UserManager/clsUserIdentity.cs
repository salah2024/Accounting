using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblUserIdentity")]
    public class clsUserIdentity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [ForeignKey("clsUserInfo")]
        public Guid UserInfoId { get; set; }
        public virtual clsUserInfo UserInfo { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "کلمه عبور نبایستی خالی باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
