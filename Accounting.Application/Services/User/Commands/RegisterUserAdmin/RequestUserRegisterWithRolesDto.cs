using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.User.Commands.RegisterUserAdmin
{
    public class RequestUserRegisterWithRolesDto
    {
        public Guid RoleId { get; set; }
    }
}
