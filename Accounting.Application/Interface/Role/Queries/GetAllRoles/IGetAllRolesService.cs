using Accounting.Application.Services.Role.Queries.GetAllRoles;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Role.Queries.GetAllRoles
{
    public interface IGetAllRolesService
    {
       ResultDto<List<ResultAllRolesDto>> fnGetAllRoles();
    }
}
