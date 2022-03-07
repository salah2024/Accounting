using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.LanguageKeyValue.Queries;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.LanguageKeyValue.Queries
{
    public class GetAllLanguageKeyValueService: IGetAllLanguageKeyValueService
    {
        private readonly IDataBaseContext _context;
        public GetAllLanguageKeyValueService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ResultAllLanguageKeyValueDto>> GetAllLanguageKeyValue()
        {
            try
            {
                List<ResultAllLanguageKeyValueDto> lstAllLanguageKeyValue =
                    _context.LanguageKeyValues.Select(p => new ResultAllLanguageKeyValueDto
                    {
                        LanguageKeyValueName = p.Name,
                        LanguageKeyValueDescription = p.Description,
                        LanguageKeyValueId = p.ID,
                    }).ToList();
                return new ResultDto<List<ResultAllLanguageKeyValueDto>>
                {
                    Data = lstAllLanguageKeyValue,
                    IsSuccess = true,
                    Message = "لیست بدرستی گرفته شد",
                };

            }
            catch (Exception)
            {
                return new ResultDto<List<ResultAllLanguageKeyValueDto>>
                {
                    Data = new List<ResultAllLanguageKeyValueDto>(),
                    IsSuccess = false,
                    Message = "مشکل در دریافت لیست",
                };
            }
        }
    }
}
