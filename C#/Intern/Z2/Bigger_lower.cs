int A = new Random().Next(1,100);
int B = new Random().Next(1,100);                                 // Загадаем два числа
Console.WriteLine("Есть два числа - " + A + " и " + B);          // Вывод полученных чисел
if (A>B)
{
     Console.WriteLine("Число " + A + " больше числа " + B);
}
else
     Console.WriteLine("Число " + A + " меньше числа " + B);