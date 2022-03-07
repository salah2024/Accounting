using Accounting.Application.Interface.Role.Queries.GetAllRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface IRoleFacad
    {
        IGetAllRolesService getAllRolesService { get; }
        IInsertNewRoleService insertNewRoleService { get; }
    }
}
