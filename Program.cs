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
            int[] array = GetFilledArray();
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock1(array);

        }
        static int[] GetFilledArray()
        {
            Console.WriteLine("Enter 1 - to fill array manually");
            Console.WriteLine("Enter 2 - to fill array randomy");

            int choice = GetEnteredChoice();
            if (choice != 1 && choice != 2)
            {
                HandleWrongUserChoice();
            }


            switch (choice)
            {
                case 1:
                    return GetManualyFilledArray();
                default:
                    return GetRandomFilledArray();
            }

        }


        static int[] GetManualyFilledArray()
        {
            Console.Write("Enter the number of elements: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }


        static int[] GetRandomFilledArray()
        {


            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine("Random Array: ");
            Console.WriteLine(string.Join(" ", array));
            return array;
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