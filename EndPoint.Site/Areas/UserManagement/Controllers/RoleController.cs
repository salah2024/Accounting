using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Services.Role.Commands.InsertRole;
using Accounting.Application.Services.Role.Forms;
using Accounting.Application.Services.Role.Queries.GetAllRoles;
using Accounting.Common.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.UserManagement.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IDataBaseContext _context;
        private readonly IRoleFacad _roleFacad;
        public RoleController(IDataBaseContext context, IRoleFacad roleFacad)
        {
            _context=context;
            _roleFacad=roleFacad;
        }

        [HttpGet]
        public ActionResult GetAllRoles()
        {
            ResultDto<List<ResultAllRolesDto>> Result=
            _roleFacad.getAllRolesService.fnGetAllRoles();
            if (Result.IsSuccess)
            {
                List<ResultAllRolesDto> lstResultAllRoles = Result.Data;
                return new JsonResult(lstResultAllRoles);
            }
            else
                return new JsonResult(false);
        }
        [HttpPost]
        public ActionResult AddNewRole(NewRoleFrm Request)
        {
            ResultDto<ResultAddNewRoleDto> Result= _roleFacad.insertNewRoleService.InsertNewRole(Request);
            if (Result.IsSuccess)
            {
                ResultAddNewRoleDto ResultAddNewRole = Result.Data;
                return new JsonResult(true);
            }
            else
                return new JsonResult(false);
        }
    }
}
