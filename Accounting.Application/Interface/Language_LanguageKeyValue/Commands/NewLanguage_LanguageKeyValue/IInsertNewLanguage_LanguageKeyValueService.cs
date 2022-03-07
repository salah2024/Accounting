using Accounting.Application.Services.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue
{
    public interface IInsertNewLanguage_LanguageKeyValueService
    {
        ResultDto<ResultNewLanguage_LanguageKeyValueDto> InsertNewLanguage_LanguageKeyValue(RequestNewLanguage_LanguageKeyValueDto request);
    }
}
