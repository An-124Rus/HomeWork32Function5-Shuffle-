internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 100;
        bool isWorking = true;

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

        Console.Write("\n\nНажмите Enter для перемешивания массива или любую клавишу для выхода\n\n");

        while (isWorking)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (Console.KeyAvailable || key.Key == ConsoleKey.Enter)
            {
                Shuffle(array);

                for (int i = 0; i < arrayLength; i++)
                    Console.Write(" " + array[i]);
            }
            else
            {
                isWorking = false;
            }
        }
    }

    static void Shuffle(int[] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            int randomIndex = random.Next(array.Length);

            int temporaryValue = array[randomIndex];
            array[randomIndex] = array[i];
            array[i] = temporaryValue;
        }
    }
}