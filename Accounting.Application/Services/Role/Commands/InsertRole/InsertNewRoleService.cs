using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Role.Queries.GetAllRoles;
using Accounting.Application.Services.Role.Forms;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Role.Commands.InsertRole
{
    public class InsertNewRoleService : IInsertNewRoleService
    {
        private readonly IDataBaseContext _context;
        public InsertNewRoleService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultAddNewRoleDto> InsertNewRole(NewRoleFrm request)
        {
            try
            {
                clsRole Role = new clsRole()
                {
                    Name = request.Name,
                    Description = request.Description,
                };
                _context.Roles.Add(Role);
                _context.SaveChanges();
                return new ResultDto<ResultAddNewRoleDto>()
                {
                    IsSuccess = true,
                    Message = "ثبت بدرستی صورت گرفت",
                    Data =new ResultAddNewRoleDto(){
                        RoleId= Role.ID,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultAddNewRoleDto>()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data=new ResultAddNewRoleDto(),
                };
            }
        }
    }
}
