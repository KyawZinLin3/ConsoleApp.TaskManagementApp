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
            MenuPrint();
            Console.ReadLine();
        }

        static void MenuPrint()
        {
            Console.WriteLine("***** Task Management *****");
            Console.WriteLine("1. Add Task");
        }

        
    }
}
