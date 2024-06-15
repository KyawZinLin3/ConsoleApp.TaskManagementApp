using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TaskManagementApp
{
    internal class Program
    {
   
        public Program()
        {
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            MenuPrint();
            int input = program.GetInput();
            program.CheckInput(input);
        }

        static void MenuPrint()
        {
            Console.WriteLine("***** Task Management *****");
            Console.WriteLine("1. Add Task");
            Console.Write("Your Input : ");
        
        }

        public int GetInput()
        {
            int input = Convert.ToInt16(Console.ReadLine());
            return input;
        }

        public void CheckInput(int input)
        {
            if(input == 1) 
            {
                AddTask();
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Add your Task.");
            Console.Write(">>> ");
            string task = Console.ReadLine();
            Console.WriteLine(task);
        }

        static void DeleteTask(string task)
        {
            Console.WriteLine("Delete Your Task");
        }

        static void UpdateTask()
        {
            Console.WriteLine("Update Your Task");

        }
        
        static void MarkCompletetask(string task)
        {
            Console.WriteLine("Completed");
        }
        
    }
}
