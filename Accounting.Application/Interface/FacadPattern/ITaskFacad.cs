using Accounting.Application.Interface.Task.Commands;
using Accounting.Application.Interface.Task.Queries.GetAllTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interface.FacadPattern
{
    public interface ITaskFacad
    {
        IGetAllTasksService getAllTaskService { get;}
        IAddNewTaskService addNewTaskService { get; }
    }
}
