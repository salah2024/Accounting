using Accounting.Application.Services.Language.Commands.InsertNewLanguage;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Language.Commands.InsertNewLanguage
{
    public interface IInsertNewLanguageService
    {
        ResultDto<ResultLanguageDto> InsertNewLanguage(RequestLanguageDto request);
    }
}
