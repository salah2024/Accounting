using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Task.Commands;
using Accounting.Application.Services.Task.Forms;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Task.Commands
{
    public class AddNewTaskService: IAddNewTaskService
    {
        private readonly IDataBaseContext _context;
        public AddNewTaskService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultAddNewTaskDto> AddNewTask(NewTaskFrm request)
        {
            try
            {
                clsTask Tasks = new clsTask()
                {
                    Name = request.Name,
                    Description = request.Description,
                };
                _context.Tasks.Add(Tasks);
                _context.SaveChanges();
                return new ResultDto<ResultAddNewTaskDto>()
                {
                    IsSuccess = true,
                    Message = "موفقیت",
                    Data = new ResultAddNewTaskDto
                    {
                        TaskId = Tasks.ID,
                    }
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<ResultAddNewTaskDto>()
                {
                    IsSuccess = false,
                    Message =ex.Message,
                    Data = new ResultAddNewTaskDto()
                };
            }

        }
    }
}
