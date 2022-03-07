using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.RoleTask.Commands.InsertRoleTasks;
using Accounting.Application.Services.RoleTask.Commands.InsertRoleTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class RoleTaskFacad:IRoleTaskFacad
    {
        private readonly IDataBaseContext _context;
        public RoleTaskFacad(IDataBaseContext context)
        {
            _context = context;
        }

        IInsertRoleTaskService _insertRoleTaskService;
        public IInsertRoleTaskService insertRoleTaskService
        {
            get
            {
                return _insertRoleTaskService=_insertRoleTaskService ?? new InsertRoleTaskService(_context);
            }
        }
    }
}
