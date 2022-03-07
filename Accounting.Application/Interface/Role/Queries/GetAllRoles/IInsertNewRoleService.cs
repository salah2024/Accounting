using Accounting.Application.Services.Role.Commands.InsertRole;
using Accounting.Application.Services.Role.Forms;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Role.Queries.GetAllRoles
{
    public interface IInsertNewRoleService
    {
        ResultDto<ResultAddNewRoleDto> InsertNewRole(NewRoleFrm request);
    }
}
