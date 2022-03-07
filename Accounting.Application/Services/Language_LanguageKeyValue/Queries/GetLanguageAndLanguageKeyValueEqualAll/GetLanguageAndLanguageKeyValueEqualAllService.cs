using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.LanguageManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language_LanguageKeyValue.Queries.GetLanguageAndLanguageKeyValueEqualAll
{
    public class GetLanguageAndLanguageKeyValueEqualAllService : IGetLanguageAndLanguageKeyValueEqualAllService
    {
        private readonly IDataBaseContext _context;
        public GetLanguageAndLanguageKeyValueEqualAllService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>> GetLanguageAndLanguageKeyValueEqualAll()
        {
            try
            {
                List<ResultLanguageAndLanguageKeyValueEqualDto> lstLanguageAndLanguageKeyValueEqual =
                    _context.Language_LanguageKeyValues.Include(p => p.languageKeyValue).Include(p => p.language)
                    .Select(p => new ResultLanguageAndLanguageKeyValueEqualDto
                    {
                        LanguageKeyValueName = p.languageKeyValue.Name,
                        LanguageName = p.language.Name,
                        Equal = p.Equal,
                    }).ToList();
                return new ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>>
                {
                    IsSuccess = true,
                    Message = "لیست بدرستی گرفته شد",
                    Data = lstLanguageAndLanguageKeyValueEqual,
                };

            }
            catch (Exception)
            {
                return new ResultDto<List<ResultLanguageAndLanguageKeyValueEqualDto>>
                {
                    IsSuccess = false,
                    Message = "مشکل در گرفتن لیست",
                    Data = new List<ResultLanguageAndLanguageKeyValueEqualDto>(),
                };
            }
        }
    }
}
