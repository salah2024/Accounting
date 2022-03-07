using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.LanguageKeyValue.Commands.InsertNewLanguageKeyValue;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.LanguageManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.LanguageKeyValue.Commands.InsertNewLanguageKeyValue
{
    public class InsertNewLanguageKeyValueService: Interface.LanguageKeyValue.Commands.InsertNewLanguageKeyValue.IInsertNewLanguageKeyValueService
    {
        private readonly IDataBaseContext _context;
        public InsertNewLanguageKeyValueService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultLanguageKeyValueDto> InsertNewLanguageKeyValue(RequestLanguageKeyValueDto request)
        {
            try
            {
                clsLanguageKeyValue LanguageKeyValue = new clsLanguageKeyValue()
                {
                    Name = request.Name,
                    Description = request.Description,

                };
                _context.LanguageKeyValues.Add(LanguageKeyValue);
                _context.SaveChanges();
                Guid LanguageKeyId = LanguageKeyValue.ID;
                return new ResultDto<ResultLanguageKeyValueDto>()
                {
                    IsSuccess = true,
                    Message = "ثبت بدرستی صورت گرفت",
                    Data = new ResultLanguageKeyValueDto
                    {
                        LanguageKeyId = LanguageKeyId,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultLanguageKeyValueDto>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new ResultLanguageKeyValueDto()
                };
            }
        }
    }
}
