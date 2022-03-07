using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Services.User.Commands.RegisterUserAdmin;
using Accounting.Application.Services.User.Forms;
using Accounting.Application.Services.User.Queries;
using Accounting.Common.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.UserManagement.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataBaseContext _context;
        private readonly IUserFacad _userFacad;
        public UserController(IDataBaseContext context, IUserFacad userFacad)
        {
            _context=context;
            _userFacad = userFacad;
        }
        public ActionResult GetAllUsers()
        {
            ResultDto<List<ResultAllUsersDto>> Result =
                _userFacad.getAllUserWithRolesService.GetAllUserWithRoles();
            if (Result.IsSuccess)
            {
                List<ResultAllUsersDto> lstGetAllUserWithRoles = Result.Data;
                return new JsonResult(lstGetAllUserWithRoles);
            }
            else
                return new JsonResult(false);
        }


        public ActionResult AddNewUser(UserRegisterWithRolesFrm Request)
        {
            ResultWithValidationDto<ResultRegisterUserWithRolesDto>
              Result = _userFacad.registerUserWithRolesService.RegisterUserWithRoles(Request);
            if (Result.IsSuccess)
            {
                return new JsonResult(true);
            }
            else
                return new JsonResult(false);
        }
    }
}
