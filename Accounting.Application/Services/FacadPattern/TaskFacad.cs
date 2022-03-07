using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.FacadPattern;
using Accounting.Application.Interface.Task.Commands;
using Accounting.Application.Interface.Task.Queries.GetAllTasks;
using Accounting.Application.Services.Task.Commands;
using Accounting.Application.Services.Task.Queries.GetAllTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.FacadPattern
{
    public class TaskFacad:ITaskFacad
    {
        private readonly IDataBaseContext _context;
        public TaskFacad(IDataBaseContext context)
        {
            _context = context;
        }

        private IGetAllTasksService _getAllTasksService;
        public IGetAllTasksService getAllTaskService
        {
            get
            {
                return _getAllTasksService=_getAllTasksService??new GetAllTasksService(_context);
            }
        }

        private IAddNewTaskService _addNewTaskService;
        public IAddNewTaskService addNewTaskService
        {
            get
            {
                return _addNewTaskService = _addNewTaskService ?? new AddNewTaskService(_context);
            }
        }
    }
}
