using Accounting.Application.Interface.RoleTask.Commands.InsertRoleTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface IRoleTaskFacad
    {
        IInsertRoleTaskService insertRoleTaskService{get;}
    }
}
