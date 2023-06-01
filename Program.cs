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
            Console.Write("\n Enter number of block (from 1 - to 3) to run: ");

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

            int[][] array = GetFilledArrayForTasks();
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock2(array);
        }


        static int[][] GetFilledArrayForTasks()
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
                    return GetManualyFilledArrayForTasks();
                default:
                    return GetRandomFilledArrayForTasks();
            }

        }


        static int[][] GetManualyFilledArrayForTasks()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the number of elements in row {i + 1}: ");
                int columns = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[columns];

                Console.WriteLine($"Enter {columns} elements for row {i + 1}:");
                string[] elements = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    jaggedArray[i][j] = int.Parse(elements[j]);
                }
            }

            return jaggedArray;
        }


        static int[][] GetRandomFilledArrayForTasks()
        {
            Console.Write("Enter number of row: ");
            int rowCount = int.Parse(Console.ReadLine());
            Console.Write("Enter number of minColumn: ");
            int minColumnCount = int.Parse(Console.ReadLine());
            Console.Write("Enter number of maxColumn: ");
            int maxColumnCount = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowCount][];

            Random random = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                int columnCount = random.Next(minColumnCount, maxColumnCount + 1);
                jaggedArray[i] = new int[columnCount];

                for (int j = 0; j < columnCount; j++)
                {
                    jaggedArray[i][j] = random.Next(-10, 20);
                }
            }
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            return jaggedArray;
        }
        static void DoBlock3()
        {
            int[][] arraytask3 = GetFilledArrayForTask3();
            dynamic instanceRef = DefineStudentSolutionLoad();
            instanceRef.DoBlock3(arraytask3);
        }
        static int[][] GetFilledArrayForTask3()
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
                    return GetManualyFilledArrayForTask3();
                default:
                    return GetRandomFilledArrayForTask3();
            }

        }


        static int[][] GetManualyFilledArrayForTask3()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the number of elements in row {i}: ");
                int columns = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[columns];

                Console.WriteLine($"Enter {columns} elements for row {i}:");
                string[] elements = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    jaggedArray[i][j] = int.Parse(elements[j]);
                }
            }
            return jaggedArray;
        }


        static int[][] GetRandomFilledArrayForTask3()
        {
            Console.Write("Enter number of row: ");
            int rowCount = int.Parse(Console.ReadLine());
            Console.Write("Enter number of minColumn: ");
            int minColumnCount = int.Parse(Console.ReadLine());
            Console.Write("Enter number of maxColumn: ");
            int maxColumnCount = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowCount][];

            Random random = new Random();

            for (int i = 0; i < rowCount; i++)
            {
                int columnCount = random.Next(minColumnCount, maxColumnCount + 1);
                jaggedArray[i] = new int[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    jaggedArray[i][j] = random.Next(-10, 20);
                }
            }
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            return jaggedArray;
        }

        static dynamic DefineStudentSolutionLoad()
        {

            Console.WriteLine("Enter 1 to Vasilchenko");
            Console.WriteLine("Enter 1 to Shpotak");

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
