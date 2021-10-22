using System;
namespace Investments.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Assignment { get; set; }
        public DateTime DateTime { get; set; }

        /*
         * Empty Constructor for View
         */
        public ToDo(){ }


        /*
         * Full Constructor for Code
         */
        public ToDo(string assignment, DateTime dateTime)
        {
            Assignment = assignment;
            DateTime = dateTime;
        }
    }
}
