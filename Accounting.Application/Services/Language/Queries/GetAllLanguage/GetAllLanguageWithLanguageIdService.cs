using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language.Queries.GetAllLanguage;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language.Queries.GetAllLanguage
{
    public class GetAllLanguageWithLanguageIdService: IGetAllLanguageWithLanguageIdService
    {
        private readonly IDataBaseContext _context;
        public GetAllLanguageWithLanguageIdService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<ResultGetAllLanguageDto>> GetAllLanguageWithLanguageId(RequestGetAllLanguageDto request)
        {
            try
            {
                List<ResultGetAllLanguageDto> lstResultGetAllLanguageDto =
                    _context.Languages.Select(p => new ResultGetAllLanguageDto
                    {
                        Description = p.Description,
                        LanguageName = p.Name,
                        LanguageId = p.ID,
                    }).Where(p=>p.LanguageId==request.LanguageId).ToList();
                return new ResultDto<List<ResultGetAllLanguageDto>>()
                {
                    IsSuccess = true,
                    Message = "لیست بدرستی گرفته شد",
                    Data = lstResultGetAllLanguageDto,
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResultGetAllLanguageDto>>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new List<ResultGetAllLanguageDto>(),
                };
            }
        }

    }
}
