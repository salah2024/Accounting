using Accounting.Application.Services.User.Queries;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.User.Queries
{
    public interface IGetAllUserWithRolesService
    {
        ResultDto<List<ResultAllUsersDto>> GetAllUserWithRoles();
    }
}
