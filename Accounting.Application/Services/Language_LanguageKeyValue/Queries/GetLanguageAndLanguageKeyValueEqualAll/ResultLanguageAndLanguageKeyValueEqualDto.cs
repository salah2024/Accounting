using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll
{
    public class ResultLanguageAndLanguageKeyValueEqualDto
    {
        public Guid LanguageId { get; set; }
        public string LanguageKeyValueName { get; set; }
        public string LanguageName { get; set; }
        public string Equal { get; set; }
    }
}
