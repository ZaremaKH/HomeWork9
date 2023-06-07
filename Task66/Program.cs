// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    (num1, num2) = (num2, num1);
}


int SumofNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    else
    {
        return num1 + SumofNumbers(num1 + 1, num2);
    }
}

Console.WriteLine($"Сумма от {num1} до {num2} = {SumofNumbers(num1, num2)}");