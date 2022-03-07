using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.User.Commands.RegisterUserAdmin;
using Accounting.Application.Services.User.Commands.RegisterUser;
using Accounting.Application.Services.User.Forms;
using Accounting.Common;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Commands.RegisterUserAdmin
{
    public class RegisterUserWithRolesService: IRegisterUserWithRolesService
    {
        private readonly IDataBaseContext _context;
        public RegisterUserWithRolesService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultWithValidationDto<ResultRegisterUserWithRolesDto> RegisterUserWithRoles(UserRegisterWithRolesFrm Request)
        {
            try
            {
            ValidateUserWithRolesRegister validateUserWithRolesRegister = new ValidateUserWithRolesRegister();
            List<ValidatorCheck> lstValidatorCheck = validateUserWithRolesRegister.CheckUserWithRolesFields(Request);
            if (lstValidatorCheck.Count != 0)
            {
                return new ResultWithValidationDto<ResultRegisterUserWithRolesDto>
                {
                    IsSuccess = false,
                    Message = "",
                    Data = new ResultRegisterUserWithRolesDto(),
                    Errors = lstValidatorCheck,
                };
            }
            else
            {
                clsUserInfo user = new clsUserInfo
                {
                    FirstName = Request.FirstName,
                    LastName = Request.LastName,
                    Email = Request.Email,
                    DisplayName = Request.DisplayName,
                    BirthDate = Request.BirthDate,
                    Mobile = Request.Mobile,
                    NationalCode = Request.NationalCode,
                };
                _context.UserInfos.Add(user);

                foreach (var item in Request.lstRoles)
                {
                    clsUserInRole userInRole = new clsUserInRole()
                    {
                        UserInfoId = user.ID,
                        RoleId = item.RoleId,
                        IsActive=true,
                    };
                    _context.UserInRoles.Add(userInRole);
                }
                _context.SaveChanges();
                Guid UserId = user.ID;

                return new ResultWithValidationDto<ResultRegisterUserWithRolesDto>
                {
                    IsSuccess = true,
                    Message = "ثبت نام کاربر با موفقیت انجام گرفت",
                    Data = new ResultRegisterUserWithRolesDto
                    {
                        UserId = UserId
                    },
                    Errors = new List<ValidatorCheck>(),
                };
            }
            }
            catch (Exception ex)
            {
                return new ResultWithValidationDto<ResultRegisterUserWithRolesDto>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = new ResultRegisterUserWithRolesDto(),
                    Errors = new List<ValidatorCheck>(),
                };
            }
        }


    }
}
