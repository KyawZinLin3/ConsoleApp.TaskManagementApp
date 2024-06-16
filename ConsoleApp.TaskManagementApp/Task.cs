using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TaskManagementApp
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public Task(string title,string description)
        {
            Title = title;
            Description = description;
            IsComplete = false;
        }

        public string ToFileFormat()
        {
            return $"{Title}|{Description}|{IsComplete}";
        }
    }
}
