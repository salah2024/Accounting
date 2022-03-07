using Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll
{
    public interface IGetLanguageAndLanguageKeyValueEqualWithLanguageNameService
    {
        ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>> GetLanguageAndLanguageKeyValueEqualWithLanguageName(RequestLanguageAndLanguageKeyValueLanguageNameDto Request);
    }
}
