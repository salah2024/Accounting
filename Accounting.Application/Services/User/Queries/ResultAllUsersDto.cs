using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Queries
{
    public class ResultAllUsersDto
    {
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "نام نمایشی")]
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string ImagePath { get; set; }
        public List<AllUserRolesDto> lstUserRoles { get; set; }
    }
}
