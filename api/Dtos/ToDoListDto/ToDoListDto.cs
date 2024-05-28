using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.ToDoListDto
{
    public class ToDoListDto
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public string UserName { get; set; }
    }
}