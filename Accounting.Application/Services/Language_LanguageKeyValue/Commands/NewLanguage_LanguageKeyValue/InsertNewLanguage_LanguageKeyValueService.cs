using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.LanguageManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Language_LanguageKeyValue.Commands.NewLanguage_LanguageKeyValue
{
    public class InsertNewLanguage_LanguageKeyValueService: IInsertNewLanguage_LanguageKeyValueService
    {
        private readonly IDataBaseContext _context;
        public InsertNewLanguage_LanguageKeyValueService(IDataBaseContext context)
        {
            _context=context;
        }

        public ResultDto<ResultNewLanguage_LanguageKeyValueDto> InsertNewLanguage_LanguageKeyValue(RequestNewLanguage_LanguageKeyValueDto request)
        {
            try
            {
                clsLanguage_LanguageKeyValue Language_LanguageKeyValue = new clsLanguage_LanguageKeyValue()
                {
                    LanguageKeyValueId = request.LanguageKeyValueId,
                    LanguageId = request.LanguageId,
                    Equal = request.Equal,
                };
                Guid LangId = Language_LanguageKeyValue.ID;
                _context.Language_LanguageKeyValues.Add(Language_LanguageKeyValue);
                _context.SaveChanges();
                return new ResultDto<ResultNewLanguage_LanguageKeyValueDto>() {
                    IsSuccess = true,
                    Message = "ثبت بدرستی انجام شد",
                    Data = new ResultNewLanguage_LanguageKeyValueDto
                    {
                        Language_LanguageKeyValueId = LangId,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultNewLanguage_LanguageKeyValueDto>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new ResultNewLanguage_LanguageKeyValueDto()
                };
            }
        }
    }
}
