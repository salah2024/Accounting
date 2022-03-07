using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.RoleTask.Commands.InsertRoleTasks;
using Accounting.Common.Dto;
using Accounting.Domain.Entities.UserManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.RoleTask.Commands.InsertRoleTasks
{
    public class InsertRoleTaskService : IInsertRoleTaskService
    {
        private readonly IDataBaseContext _context;
        public InsertRoleTaskService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto InserRoleTask(RequestRoleTaskDto request)
        {
            try
            {
                foreach (var item in request.lstTaskId)
                {
                    clsRoleTask roleTask = new clsRoleTask()
                    {
                        TaskId = item,
                        RoleId = request.RoleId,
                    };
                    _context.RoleTasks.Add(roleTask);
                }
                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "ثبت بدرستی صورت گرفت",
                };
            }
            catch (Exception ex)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
