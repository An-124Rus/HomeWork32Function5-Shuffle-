internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 100;
        bool isWorking = true;
        string userKey = "Enter";

        Console.Write("Введите длину массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Random random = new Random();

        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);

            Console.Write(" " + array[i]);
        }

        Console.Write("\n\nНажмите " + userKey + " для перемешивания массива или любую клавишу для выхода\n\n");

        while (isWorking)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                GetKey(key, ref isWorking);

                if(isWorking == true)
                {
                    Shuffle(ref array);

                    for (int i = 0; i < arrayLength; i++)
                        Console.Write(" " + array[i]);
                }
            }
        }
    }

    static void Shuffle(ref int[] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            int j = random.Next(array.Length);

            int temporaryValue = array[j];
            array[j] = array[i];
            array[i] = temporaryValue;
        }
    }

    static void GetKey(ConsoleKeyInfo key, ref bool isWorking)
    {
        switch (key.Key)
        {
            case ConsoleKey.Enter:
                isWorking = true;
                break;
            default:
                isWorking = false;
                break;
        }
    }
}