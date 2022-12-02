
// Решаем все задачи через рекурсию!
// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.

//N = 5 -> "4, 2"
//N = 8 -> "8, 6, 4, 2"

Console.Clear();

Console.WriteLine("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ReverseOrderNaturalNumber(int n)
{
    if(n == 0) return;
    Console.Write($"{n}, ");
    ReverseOrderNaturalNumber(n - 1);
}

ReverseOrderNaturalNumber(number);