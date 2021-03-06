﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TODOList ListTasks = new TODOList();

            if (args.Length == 0)
            {
                Welcome();
                return;
            }
            if ("-l" == args[0])
            {
                ListTasks.ListWrite();
            }
            if ("-a" == args[0])
            {
                try
                {
                    ListTasks.AddTask(args[1]);
                }
                catch
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            if ("-r" == args[0])
            {
                ListTasks.RemoveTask(args[1]);
            }
        }

        static void Welcome()
        {
            Console.WriteLine("\nCommand Line Todo Application\n" + "=============================\n\n" + "Command line arguments:\n" + "-l   Lists all the tasks\n" +
                "-a   Adds a new task\n" + "-r   Removes a task\n" + "-c   Completes a task\n");
        }
    }
}
