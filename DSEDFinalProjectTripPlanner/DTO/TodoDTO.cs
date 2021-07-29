using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSEDFinalProjectTripPlanner.Models;

namespace DSEDFinalProjectTripPlanner.DTO
{
    public class TodoDTO
    {
        // tells the items to do there
        public MyTodo MyTodos { get; set; }//Todo
        public List<Item> AllItems { get; set; }//List
    }
}
