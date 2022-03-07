using Accounting.Application.Interface.User.Commands;
using Accounting.Application.Interface.User.Commands.RegisterUserAdmin;
using Accounting.Application.Interface.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface IUserFacad
    {
        IRegisterUserService registerUserService { get; }
        IGetAllUserWithRolesService getAllUserWithRolesService { get; }
        IRegisterUserWithRolesService registerUserWithRolesService { get; }

    }
}
