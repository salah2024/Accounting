using Accounting.Application.Services.User.Commands.RegisterUserAdmin;
using Accounting.Application.Services.User.Forms;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.User.Commands.RegisterUserAdmin
{
    public interface IRegisterUserWithRolesService
    {
        ResultWithValidationDto<ResultRegisterUserWithRolesDto> RegisterUserWithRoles(UserRegisterWithRolesFrm Request);
    }
}
