using System;
namespace LabWork4
{
    class Task
    {
        static void Main()
        {
            GetUserPreference();
        }


        static void GetUserPreference()
        {
            Console.Write("\n Enter number of block (from 1 - to 4) to run: ");

            int choice = GetEnteredChoice();
            if (choice == 0) { HandleWrongUserChoice(); }
            else { RunBlockOf(choice); }
        }

        static void RunBlockOf(int choice)
        {
            switch (choice)
            {
                case 1:
                    DoBlock1();
                    break;
                case 2:
                    DoBlock2();
                    break;
                case 3:
                    DoBlock3();
                    break;
                case 4:
                    DoBlock4();
                    break;
                default:
                    HandleWrongUserChoice();
                    break;
            }
        }

        static void HandleWrongUserChoice()
        {
            Console.WriteLine("Your choice is not valid, enter any key to exit to start from begin");
            Console.ReadKey();
            GetUserPreference();
        }



        static void DoBlock1()
        {
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock1();

        }
        static void DoBlock2()
        {
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock2();
        }
        static void DoBlock3()
        {
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock3();
        }
        static void DoBlock4()
        {
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock4();
        }

        static dynamic DefineStudentSolutionLoad()
        {
            Console.WriteLine("Enter 1 - to load 'Vasilchenko.cs");
            Console.WriteLine("Enter 2 - to load 'Shpotak.cs");

            int choice = GetEnteredChoice();
            if (choice != 1 && choice != 2)
            {
                HandleWrongUserChoice();
            }

            switch (choice)
            {
                case 1:
                    return new Vasilchenko();
                default:
                    return new Shpotak();
            }
        }

        static int GetEnteredChoice()
        {
            string? input = Console.ReadLine();
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int intValue) ? int.Parse(input) : 0;
        }

    }
}