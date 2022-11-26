Console.Clear();

Console.Write ("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
    int secondNumber = (number % 100 - number % 10) / 10;

    Console.WriteLine ($"Второй цифрой числа {number} является {secondNumber}");
}
else
{
    Console.WriteLine ("Число задано неверно");
}