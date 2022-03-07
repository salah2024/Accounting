using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll
{
    public class GetLanguageAndLanguageKeyValueEqualWithLanguageNameService : IGetLanguageAndLanguageKeyValueEqualWithLanguageNameService
    {
        private readonly IDataBaseContext _context;
        public GetLanguageAndLanguageKeyValueEqualWithLanguageNameService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>> GetLanguageAndLanguageKeyValueEqualWithLanguageName(RequestLanguageAndLanguageKeyValueLanguageNameDto Request)
        {
            try
            {
                List<ResultLanguageAndLanguageKeyValueEqualDto> lstLanguageAndLanguageKeyValueEqual =
                    _context.Language_LanguageKeyValues.Include(p => p.languageKeyValue).Include(p => p.language)
                    .Select(p => new ResultLanguageAndLanguageKeyValueEqualDto
                    {
                        LanguageId=p.LanguageId,
                        LanguageKeyValueName = p.languageKeyValue.Name,
                        LanguageName = p.language.Name,
                        Equal = p.Equal,
                    }).Where(p=>p.LanguageName==Request.LanguageName).ToList();
                return new ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>>
                {
                    IsSuccess = true,
                    Message = "لیست بدرستی گرفته شد",
                    Data = lstLanguageAndLanguageKeyValueEqual,
                };

            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new List<ResultLanguageAndLanguageKeyValueEqualDto>(),
                };
            }
        }
    }
}
