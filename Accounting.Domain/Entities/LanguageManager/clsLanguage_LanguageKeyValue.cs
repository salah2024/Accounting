using Accounting.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.LanguageManager
{
    [Table("tblLanguage_LanguageKeyValue")]
    public class clsLanguage_LanguageKeyValue:clsBaseEntity
    {
        [ForeignKey("clsLanguage")]
        public Guid LanguageId { get; set; }
        public virtual clsLanguage language { get; set; }
        [ForeignKey("clsLanguageKeyValue")]
        public Guid LanguageKeyValueId { get; set; }
        public virtual clsLanguageKeyValue languageKeyValue { get; set; }
        public string Equal { get; set; }
    }
}
