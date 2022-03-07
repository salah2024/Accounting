using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue
{
    public class RequestNewLanguage_LanguageKeyValueDto
    {
        public Guid LanguageKeyValueId { get; set; }
        public Guid LanguageId { get; set; }
        public string Equal { get; set; }
    }
}
