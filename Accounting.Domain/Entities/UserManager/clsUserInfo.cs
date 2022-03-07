using Accounting.Domain.Entities.Commons;
using Accounting.Domain.Entities.LanguageManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.UserManager
{
    [Table("tblUserInfo")]
    public class clsUserInfo:clsBaseEntity
    {
        [Display(Name ="ایمیل")]
        [EmailAddress(ErrorMessage ="آدرس ایمیل وارد شده نامعتبر میباشد")]
        public string Email { get; set; }
        [Display(Name ="نام")]
        [Required(ErrorMessage ="نام نبایستی خالی باشد")]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Display(Name ="نام خانوادگی")]
        [Required(ErrorMessage ="نام خانوادگی نبایستی خالی باشد")]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Display(Name ="نام نمایشی")]
        [MaxLength(60)]
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        [Display(Name="شماره موبایل")]
        [MaxLength(11)]
        [Required(ErrorMessage ="شماره موبایل نبایستی خالی باشد")]
        [RegularExpression("[0]{1}[9]{1}[0-9]{9}", ErrorMessage = "شماره تلفن وارد شده معتبر نمی باشد!!!")]
        public string Mobile { get; set; }
        [MaxLength(10)]
        [Display(Name ="کد ملی")]
        [Required(ErrorMessage ="کد ملی نبایستی خالی باشد")]
        public string NationalCode { get; set; }
        public bool IsLoadedImage { get; set; } = false;
        [ForeignKey("clsLanguage")]
        public Guid LanguageId { get; set; }
        public clsLanguage Language { get; set; }
        public virtual clsUserIdentity UserIdentity { get; set; }
        public virtual ICollection<clsUserInRole> userInRoles { get; set; }
        public virtual ICollection<clsUserLogin> UserLogins { get; set; }

    }
}
