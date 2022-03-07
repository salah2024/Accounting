using Accounting.Application.Interface.Context;
using Accounting.Application.Interface.Task.Queries.GetAllTasks;
using Accounting.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Services.Task.Queries.GetAllTasks
{
    public class GetAllTasksService : IGetAllTasksService
    {
        private readonly IDataBaseContext _context;
        public GetAllTasksService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<ResultAllTasksDto>> fnGetAllTasks()
        {
        //    try
        //    {
                var AllTasksQry = _context.Tasks.Select(p => new ResultAllTasksDto()
                {
                    Id = p.ID,
                    ParentId = p.ParentId,
                    Name = p.Name,
                    Description = p.Description,
                });

                if (AllTasksQry != null)
                {
                    List<ResultAllTasksDto> lstResultAllTasks = AllTasksQry.ToList();
                    return new ResultDto<List<ResultAllTasksDto>>()
                    {
                        Data = lstResultAllTasks,
                        Message = "",
                        IsSuccess = true,
                    };
                }
                else
                {
                    return new ResultDto<List<ResultAllTasksDto>>()
                    {
                        IsSuccess = false,
                        Message = "مشکل در تهیه لیست",
                        Data = new List<ResultAllTasksDto>(),
                    };
                }
            //}
            //catch (Exception ex)
            //{
            //    return new ResultDto<List<ResultAllTasksDto>>()
            //    {
            //        IsSuccess = false,
            //        Message = ex.Message,
            //        Data = new List<ResultAllTasksDto>(),
            //    };

            //}
        }
    }
}
