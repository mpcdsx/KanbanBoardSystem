using System;

namespace KanbanBoardSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string task, requested, doing, done, optionSelected;

            Console.WriteLine("To Do List: ");
            Console.WriteLine("Enter your task: ");
            requested = Console.ReadLine();
            Console.WriteLine("Click \'a\' if your task is WIP.");
            Console.WriteLine("Click \'b\' if your task is Done.");
            task = optionSelected = Console.ReadLine();
            {

                if (task.Equals("a"))
                    {
                        Console.WriteLine("Your task is now working in progress!");
                    }
                else if (task.Equals("b"))
                    {
                    Console.WriteLine("Your task is finally done!");
                    }
                else
                    {
                        Console.WriteLine("Invalid selection.");

                    }
                }
            }

        }

    }
