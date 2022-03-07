using Accounting.Application.Services.Language.Queries.GetAllLanguage;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Language.Queries.GetAllLanguage
{
    public interface IGetAllLanguageWithLanguageIdService
    {
        ResultDto<List<ResultGetAllLanguageDto>> GetAllLanguageWithLanguageId(RequestGetAllLanguageDto request);
    }
}
