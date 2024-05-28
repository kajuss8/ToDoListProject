using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.ToDoListDto;
using api.Models;

namespace api.Mappers
{
    public static class ToDoListMappers
    {
        public static ToDoListDto ToToDoListDto(this ToDoList ToDoListModel)
        {
            return new ToDoListDto
            {
                ID = ToDoListModel.ID,
                Task = ToDoListModel.Task,
                UserName = ToDoListModel.UserName
            };
        }
    }
}