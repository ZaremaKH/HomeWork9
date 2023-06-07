// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите натуральное положительное число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное положительное число: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0) numM = numM * (-1);
if (numN < 0) numN = numN * (-1);


int AkkermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else
    {
        if (numN == 0) return AkkermanFunction(numM - 1, 1);
        else
        {
            return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN - 1));
        }
    }
}

Console.WriteLine($"{AkkermanFunction(numM, numN)}");
