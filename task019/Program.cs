/*
19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет
23432 -> да
12821 -> да
*/

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = (reversedNumber * 10) + remainder;
            number /= 10;
        }

        if (originalNumber == reversedNumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для проверки кода
            number = 64546;
        }

        bool result = IsPalindrome(number);
        Console.WriteLine($"{result}");
    }
}
