﻿System.Console.WriteLine("Введите число ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
return result;

}
int sumNumber = SumNumber(numberN);
System.Console.WriteLine("Сумма цифр в числе - " + sumNumber);