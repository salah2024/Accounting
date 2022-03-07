using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Forms
{
    public class UserRegisterOnlyUserNameAndPassWordFrm
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "نام کاربری نبایستی خالی باشد")]
        public string UserName { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "کلمه عبور نبایستی خالی باشد")]
        public string Password { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "تکرار کلمه عبور نبایستی خالی باشد")]
        [Compare("Password", ErrorMessage = "کلمه عبور با تکرار آن برابر نیست")]
        public string ConfirmPassword { get; set; }

    }
}
