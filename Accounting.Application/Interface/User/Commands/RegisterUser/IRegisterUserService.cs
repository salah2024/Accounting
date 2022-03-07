using Accounting.Application.Services.User.Commands.RegisterUser;
using Accounting.Application.Services.User.Forms;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.User.Commands
{
    public interface IRegisterUserService
    {
        ResultWithValidationDto<ResultRegisterUserDto> RegisterUser(UserRegisterFrm userRegister);
    }
}
