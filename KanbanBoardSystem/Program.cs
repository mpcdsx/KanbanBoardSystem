using System;

namespace KanbanBoardSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userDay, optionSelected;

            Console.WriteLine("Training Sessions: \n");
            Console.WriteLine("Monday: \n");
            Console.WriteLine("Wednesday: \n");
            Console.WriteLine("Friday: \n");
            Console.WriteLine("Completed Session: ");

            Console.WriteLine("Input your training session:");
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Enter \'m\' for Monday, \'w\' for Wednesday and \'f\' for Friday: ");
            userDay = optionSelected = Console.ReadLine();

            {
                if (optionSelected.Equals("m"))
                {
                    Console.WriteLine("Your session is Monday. \n");
                }
                else if (optionSelected.Equals("w"))
                {
                    Console.WriteLine("Your session is Wednesday. \n");
                }
                else if (optionSelected.Equals("f"))
                {
                    Console.WriteLine("Your session is Friday. \n");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");

                }

                Console.WriteLine("Training Sessions:");
                if (userDay.Equals("m"))
                {
                    Console.WriteLine("Monday");
                }
                else if (userDay.Equals("w"))
                {
                    Console.WriteLine("Wednesday");
                }
                else if (userDay.Equals("f"))
                {
                    Console.WriteLine("Friday");
                }


                {
                    Console.WriteLine("Trainer Name: " + userName);
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 2; i++)

            {
                Console.WriteLine("Input your training session:");
                Console.WriteLine("Enter your name:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter \'m\' for Monday, \'w\' for Wednesday and \'f\' for Friday: ");
                userDay = optionSelected = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {

                if (optionSelected.Equals("m"))
                {
                    Console.WriteLine("Your session is Monday. \n");
                }
                else if (optionSelected.Equals("w"))
                {
                    Console.WriteLine("Your session is Wednesday. \n");
                }
                else if (optionSelected.Equals("f"))
                {
                    Console.WriteLine("Your session is Friday. \n");
                }
                else
                {
                    Console.WriteLine("Invalid selection.");

                }

                Console.WriteLine("Training Sessions:");
                if (userDay.Equals("m"))
                {
                    Console.WriteLine("Monday");
                }
                else if (userDay.Equals("w"))
                {
                    Console.WriteLine("Wednesday");
                }
                else if (userDay.Equals("f"))
                {
                    Console.WriteLine("Friday");
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }


                {
                    Console.WriteLine("Trainer Name: " + userName);

                }

            }
        }
    }
}
