using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language.Queries.GetAllLanguage;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.LanguageManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language.Queries.GetAllLanguage
{
    public class GetAllLanguageService : IGetAllLanguageService
    {
        private readonly IDataBaseContext _context;

        public GetAllLanguageService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<ResultGetAllLanguageDto>> GetAllLanguage()
        {
            try
            {
                List<ResultGetAllLanguageDto> lstResultGetAllLanguageDto =
                    _context.Languages.Select(p => new ResultGetAllLanguageDto
                    {
                        Description = p.Description,
                        LanguageName = p.Name,
                        LanguageId = p.ID,
                    }).ToList();

                return new ResultDto<List<ResultGetAllLanguageDto>>()
                {
                    IsSuccess = true,
                    Message = "لیست بدرستی گرفته شد",
                    Data = lstResultGetAllLanguageDto,
                };

            }
            catch (Exception)
            {
                return new ResultDto<List<ResultGetAllLanguageDto>>()
                {
                    IsSuccess = false,
                    Message = "مشکل در گرفتن لیست",
                    Data = new List<ResultGetAllLanguageDto>(),
                };
            }
        }
    }
}
