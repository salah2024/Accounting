using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Forms
{
    public class UserChangePasswordFrm
    {
        [Display(Name = "کلمه عبور قبلی")]
        [Required(ErrorMessage = "کلمه عبور قبلی نبایستی خالی باشد")]
        public string OldPassword { get; set; }

        [Display(Name = "کلمه عبور جدید")]
        [Required(ErrorMessage = "کلمه عبور جدید نبایستی خالی باشد")]
        public string Password { get; set; }
        [Display(Name = "تکرار کلمه عبور جدید")]
        [Required(ErrorMessage = "تکرار کلمه عبور جدید نبایستی خالی باشد")]
        [Compare("Password", ErrorMessage = "کلمه عبور جدید با تکرار آن برابر نیست")]
        public string ConfirmPassword { get; set; }
    }
}
