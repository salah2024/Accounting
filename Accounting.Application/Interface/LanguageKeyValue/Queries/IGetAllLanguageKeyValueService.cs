using Accounting.Application.Services.LanguageKeyValue.Queries;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.LanguageKeyValue.Queries
{
    public interface IGetAllLanguageKeyValueService
    {
        ResultDto<List<ResultAllLanguageKeyValueDto>> GetAllLanguageKeyValue();
    }
}
