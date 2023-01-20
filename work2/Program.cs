//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три целых числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (a != max || b != max || c != max) // неуверен что так верно.
    Console.WriteLine($"Максимальное число: {max}");
else
    Console.WriteLine("Все введённые числа одинаковы!"); 
// не смог разобраться как вернуть пользователя обратно ко вводу
// так же не смог корректно выводить сообщение о двух max числах
