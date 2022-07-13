Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine($"Число {number1} нацело делится на число {number2}");
}
else
{
     Console.WriteLine($"Остаток от деления числа {number1} на число {number2} = {result}");
}