using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.User.Commands;
using Accounting.Application.Interface.User.Commands.RegisterUserAdmin;
using Accounting.Application.Interface.User.Queries;
using Accounting.Application.Services.User.Commands.RegisterUser;
using Accounting.Application.Services.User.Commands.RegisterUserAdmin;
using Accounting.Application.Services.User.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class UserFacad : IUserFacad
    {
        private readonly IDataBaseContext _context;
        public  UserFacad(IDataBaseContext context)
        {
            _context = context;
        }
        private IRegisterUserService _registerUserService;
        public IRegisterUserService registerUserService
        {
            get
            {
                return _registerUserService=_registerUserService??new RegisterUserService(_context);
            }
        }

        private IGetAllUserWithRolesService _getAllUserWithRolesService;
        public IGetAllUserWithRolesService getAllUserWithRolesService
        {
            get
            {
                return _getAllUserWithRolesService = _getAllUserWithRolesService ?? new GetAllUserWithRolesService(_context);
            }
        }
        private IRegisterUserWithRolesService _registerUserWithRolesService;
        public IRegisterUserWithRolesService registerUserWithRolesService
        {
            get
            {
                return _registerUserWithRolesService = _registerUserWithRolesService ?? new RegisterUserWithRolesService(_context);
            }
        }
    }
}
