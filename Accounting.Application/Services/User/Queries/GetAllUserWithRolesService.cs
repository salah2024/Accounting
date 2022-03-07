using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.User.Queries;
using Accounting.Common.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Queries
{
    public class GetAllUserWithRolesService: IGetAllUserWithRolesService
    {
        private readonly IDataBaseContext _context;
        public GetAllUserWithRolesService(IDataBaseContext context)
        {
            _context=context;
        }

        public ResultDto<List<ResultAllUsersDto>> GetAllUserWithRoles()
        {
            try
            {
             List<ResultAllUsersDto> lstResultAllUsers = _context.UserInfos.Include(p => p.UserIdentity)
                .Include(p => p.userInRoles).Select(p => new ResultAllUsersDto()
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    BirthDate = p.BirthDate,
                    Email = p.Email,
                    Mobile = p.Mobile,
                    DisplayName = p.DisplayName,
                    UserName=p.UserIdentity.UserName,
                    lstUserRoles = _context.UserInRoles.Include(x => x.Role)
                  .Where(x => x.UserInfoId == p.ID)
                  .Select(x => new AllUserRolesDto
                  {
                      RoleName = x.Role.Name,
                      RoleDescription = x.Role.Description,
                  }).ToList(),
                }).ToList();

                return new ResultDto<List<ResultAllUsersDto>>
                {
                    IsSuccess = true,
                    Message = "",
                    Data = lstResultAllUsers,
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<List<ResultAllUsersDto>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new List<ResultAllUsersDto>(),
                };
            }
        }
    }
}
