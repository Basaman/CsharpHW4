// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string userInput = Console.ReadLine () ?? "";

int number_N = int.Parse(userInput);
int count = 1;

while (count < number_N)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(" ");
        count = count + 1;
    }
    else
    {
        count = count + 1;
    }
}
Console.Write(number_N);