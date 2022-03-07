using Accounting.Application.Services.Task.Commands;
using Accounting.Application.Services.Task.Forms;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Task.Commands
{
    public interface IAddNewTaskService
    {
        ResultDto<ResultAddNewTaskDto> AddNewTask(NewTaskFrm request);
    }
}
