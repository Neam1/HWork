// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите положительное целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
Console.Write($"Четные числа от 1 до {a}: ");
for (int i = b; i <= a; i++)
{
    if (i % 2 == 0)
{
        Console.Write(i + " ");
    }    
}
