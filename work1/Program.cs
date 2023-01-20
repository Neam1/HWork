//Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число >, а какое <.
//Заранее извиняюсь, за то что чуть более нагрузил программу. Но мне кажется так выглядит приятнее.
Console.Clear();
Console.WriteLine("Введите два целых числа чтобы сравнить эти числа: ");
Console.Write("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"Первое число больше и это число {a}");
else if (a == b)
    Console.WriteLine("Вы указали одинаковые числа"); 
else 
    Console.WriteLine($"Второе число больше и это число {b}");

