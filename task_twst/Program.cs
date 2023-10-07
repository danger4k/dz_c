using System;

public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже



        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.Write(i + "  ");
            }

        }






    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 7;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}