using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.Role.Queries.GetAllRoles;
using Accounting.Application.Services.Role.Commands.InsertRole;
using Accounting.Application.Services.Role.Queries.GetAllRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class RoleFacad : IRoleFacad
    {
        private readonly IDataBaseContext _context;
        public RoleFacad(IDataBaseContext context)
        {
            _context = context; 
        }
        private IGetAllRolesService _getAllRolesService;
        public IGetAllRolesService getAllRolesService 
        {
            get
            {
                return _getAllRolesService=_getAllRolesService??new GetAllRolesService(_context);
            }
        }
        private IInsertNewRoleService _insertNewRoleService;
        public IInsertNewRoleService insertNewRoleService
        {
            get
            {
                return _insertNewRoleService = _insertNewRoleService ?? new InsertNewRoleService(_context);
            }
        }
    }
}
