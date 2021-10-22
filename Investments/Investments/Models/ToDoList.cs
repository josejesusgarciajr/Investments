using System;
using System.Collections.Generic;

namespace Investments.Models
{
    public class ToDoList
    {
        public List<ToDo> ListOfAssignments { get; set; }

        public ToDoList()
        {
            ListOfAssignments = new List<ToDo>();
        }

        /*
         * Add a new item to the To Do List
         */
        public void AddAssignment(ToDo toDo)
        {
            ListOfAssignments.Add(toDo);
        }

        public void DeleteAssignment(ToDo toDo)
        {
            ListOfAssignments.Remove(toDo);
        }
    }
}
