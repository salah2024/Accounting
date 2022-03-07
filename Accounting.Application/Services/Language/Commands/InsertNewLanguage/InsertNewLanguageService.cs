using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language.Commands.InsertNewLanguage;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.LanguageManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language.Commands.InsertNewLanguage
{
    public class InsertNewLanguageService : IInsertNewLanguageService
    {
        private readonly IDataBaseContext _context;

        public InsertNewLanguageService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultLanguageDto> InsertNewLanguage(RequestLanguageDto request)
        {
            try
            {
                clsLanguage Language = new clsLanguage
                {
                    Name = request.Name,
                    Description = request.Description,
                };
                _context.Languages.Add(Language);
                _context.SaveChanges();
                Guid LanguageId = Language.ID;
                return new ResultDto<ResultLanguageDto>
                {
                    IsSuccess = true,
                    Message = "ثبت بدرستی صورت گرفت",
                    Data = new ResultLanguageDto
                    {
                        LanguageId = LanguageId,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultLanguageDto>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new ResultLanguageDto(),
                };
            }
        }
    }
}
