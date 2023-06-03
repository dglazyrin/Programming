Console.WriteLine("Итак, у нас есть числа:");          // Вывод полученных чисел
int Max = 0;
int i=1;
while (i < 4)
{
     int A = new Random().Next(1,100);
     if (A>Max)
     {
     Max=A;
     }
     Console.WriteLine(A);         
     ++i;
}
     Console.WriteLine("И наибольшее из них - это число " + Max);