using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Task.Forms
{
    public class NewTaskFrm
    {
        [Display(Name = "عنوان وظیفه")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "لاتین")]
        [MaxLength(50)]
        [Required]
        public string LatinName { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
