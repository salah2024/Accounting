using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Role.Forms
{
    public class NewRoleFrm
    {
        [Required]
        [Display(Name = "Title")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
