using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.RoleTask.Commands.InsertRoleTasks
{
    public class RequestRoleTaskDto
    {
        public Guid RoleId { get; set; }
        public List<Guid> lstTaskId { get; set; }
    }
}
