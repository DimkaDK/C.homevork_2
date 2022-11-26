Console.Clear();

Console.Write ("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 || number < -99)
{
    int thirdNumber = number;

    while (thirdNumber > 999)
    {
         thirdNumber = thirdNumber / 10;
    }

    thirdNumber = Math.Abs(thirdNumber % 10);   

    Console.WriteLine ($"Третьей цифрой числа {number} является {thirdNumber}");
}
else
{
    Console.WriteLine ($"Третьей цифры у числа {number} нет");
}