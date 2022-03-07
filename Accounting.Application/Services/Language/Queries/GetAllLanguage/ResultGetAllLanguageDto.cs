using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language.Queries.GetAllLanguage
{
    public class ResultGetAllLanguageDto
    {
        public Guid LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string Description { get; set; }
    }
}
