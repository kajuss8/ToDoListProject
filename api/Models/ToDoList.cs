using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class ToDoList
    {
        public int ID { get; set; }
        public string? Task { get; set; }
        public string? UserName { get; set; }
        //public int? AppUserId { get; set; }
        // public AppUser AppUser { get; set; }
    }
}