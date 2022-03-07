using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Services.Task.Commands;
using Accounting.Application.Services.Task.Forms;
using Accounting.Application.Services.Task.Queries.GetAllTasks;
using Accounting.Common.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.UserManagement.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IDataBaseContext _context;
        private readonly ITaskFacad _taskFacad;
        public TaskController(IDataBaseContext context, ITaskFacad taskFacad)
        {
            _context = context;
            _taskFacad = taskFacad;
        }

        [HttpGet]
        public JsonResult GetAllTasks()
        {
            Guid d = new Guid();
            ResultDto<List<ResultAllTasksDto>> Result=
            _taskFacad.getAllTaskService.fnGetAllTasks();
            if (Result.IsSuccess)
            {
                List<ResultAllTasksDto> lstResultAllTasks = Result.Data;
                return new JsonResult(lstResultAllTasks);
            }
            else
                return new JsonResult(false);
        }
        [HttpPost]
        public ActionResult AddNewTask(NewTaskFrm request)
        {
            ResultDto<ResultAddNewTaskDto> Result=
            _taskFacad.addNewTaskService.AddNewTask(request);
            if (Result.IsSuccess)
            {
                ResultAddNewTaskDto ResultAddNewTask = Result.Data;
                return new JsonResult(true);
            }
            else
                return new JsonResult(false);
        }
    }
}
