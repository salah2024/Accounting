using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Role.Queries.GetAllRoles;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Role.Queries.GetAllRoles
{
    public class GetAllRolesService : IGetAllRolesService
    {
        private readonly IDataBaseContext _context;
        public GetAllRolesService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<ResultAllRolesDto>> fnGetAllRoles()
        {
            try
            {
                var qryAllRole = _context.Roles.Select(p => new ResultAllRolesDto()
                {
                    Id = p.ID,
                    Name = p.Name,
                    Description = p.Description,
                }).AsQueryable();

                if (qryAllRole != null)
                {
                    List<ResultAllRolesDto> lstAllRoles = qryAllRole.ToList();
                    return new ResultDto<List<ResultAllRolesDto>>()
                    {
                        Data = lstAllRoles,
                        IsSuccess = true,
                        Message = "",
                    };
                }
                else
                {
                    return new ResultDto<List<ResultAllRolesDto>>()
                    {
                        Data = new List<ResultAllRolesDto>(),
                        IsSuccess = false,
                        Message = "خطا در یافتن لیست",
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResultAllRolesDto>>()
                {
                    Data = new List<ResultAllRolesDto>(),
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
