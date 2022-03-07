using Accounting.Application.Services.LanguageKeyValue.Commands.InsertNewLanguageKeyValue;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.LanguageKeyValue.Commands.InsertNewLanguageKeyValue
{
    public interface IInsertNewLanguageKeyValueService
    {
        ResultDto<ResultLanguageKeyValueDto> InsertNewLanguageKeyValue(RequestLanguageKeyValueDto request);
    }
}
