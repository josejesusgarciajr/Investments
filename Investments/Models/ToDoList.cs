using System;
using System.Collections.Generic;

namespace Investments.Models
{
    public class ToDoList
    {
        public List<ToDo> ListOfAssignments { get; set; }
        public static int ID { get; set; }

        public ToDoList()
        {
            ListOfAssignments = new List<ToDo>();
        }

        /*
         * Add a new item to the To Do List
         */
        public void AddAssignment(ToDo toDo)
        {
            /*
             * Generate ID
             * of Assignment
             */
            toDo.ID = ID++;

            /*
             * Stamp Assignment 
             * with today's Date/Time
             */
            DateTime dateTime = DateTime.Today;
            toDo.DateTime = dateTime;

            /*
             * Add Assignment to List
             */
            ListOfAssignments.Add(toDo);
        }

        public void DeleteAssignment(ToDo toDo)
        {
            ListOfAssignments.Remove(toDo);
        }
    }
}
