using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.LanguageManager
{
    [Table("tblLanguageKeyValue")]
    public class clsLanguageKeyValue:clsBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<clsLanguage_LanguageKeyValue> Language_LanguageKeyValues { get; set; }

    }
}
