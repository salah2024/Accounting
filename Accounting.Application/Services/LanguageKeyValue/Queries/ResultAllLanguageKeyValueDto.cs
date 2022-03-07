using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.LanguageKeyValue.Queries
{
    public class ResultAllLanguageKeyValueDto
    {
        public Guid LanguageKeyValueId { get; set; }
        public string LanguageKeyValueName { get; set; }
        public string LanguageKeyValueDescription { get; set; }
    }
}
