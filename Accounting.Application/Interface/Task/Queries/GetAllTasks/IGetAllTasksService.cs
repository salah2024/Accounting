using Accounting.Application.Services.Task.Queries.GetAllTasks;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.Task.Queries.GetAllTasks
{
    public interface IGetAllTasksService
    {
        ResultDto<List<ResultAllTasksDto>> fnGetAllTasks();
    }
}
