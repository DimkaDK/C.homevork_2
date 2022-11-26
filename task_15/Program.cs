Console.Clear();

Console.Write ("Введите число соответствующее дню недели: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine ("Это день является выходным");
    }
    else
    {
        Console.WriteLine ("Это день не является выходным");
    }
}
else
{
    Console.WriteLine ("Число задано неверно");
}
