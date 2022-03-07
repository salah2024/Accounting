using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.User.Commands;
using Accounting.Application.Services.User.Forms;
using Accounting.Common;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Commands.RegisterUser
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IDataBaseContext _context;
        public RegisterUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultWithValidationDto<ResultRegisterUserDto> RegisterUser(UserRegisterFrm userRegister)
        {
            ValidateUserRegister validateUserRegister = new ValidateUserRegister();
            List<ValidatorCheck> lstValidatorCheck = validateUserRegister.CheckUserFields(userRegister);
            if (lstValidatorCheck.Count != 0)
            {
                return new ResultWithValidationDto<ResultRegisterUserDto>
                {
                    IsSuccess = false,
                    Message = "",
                    Data = new ResultRegisterUserDto(),
                    Errors = lstValidatorCheck,
                };
            }
            else
            {
                clsUserInfo user = new clsUserInfo
                {
                    FirstName= userRegister.FirstName,
                    LastName= userRegister.LastName,
                    Email= userRegister.Email,
                    DisplayName= userRegister.DisplayName,
                    BirthDate= userRegister.BirthDate,
                    Mobile= userRegister.Mobile,
                    NationalCode= userRegister.NationalCode,
                };
                _context.UserInfos.Add(user);
                _context.SaveChanges();
                Guid UserId = user.ID;

                return new ResultWithValidationDto<ResultRegisterUserDto>
                {
                    IsSuccess = true,
                    Message = "ثبت نام کاربر با موفقیت انجام گرفت",
                    Data = new ResultRegisterUserDto
                    {
                        UserId = UserId
                    },
                    Errors = new List<ValidatorCheck>(),
                };
            }
        }
    }
}
