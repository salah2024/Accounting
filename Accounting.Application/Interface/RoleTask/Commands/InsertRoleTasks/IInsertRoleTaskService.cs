using Accounting.Application.Services.RoleTask.Commands.InsertRoleTasks;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.RoleTask.Commands.InsertRoleTasks
{
    public interface IInsertRoleTaskService
    {
        ResultDto InserRoleTask(RequestRoleTaskDto request);
    }
}
