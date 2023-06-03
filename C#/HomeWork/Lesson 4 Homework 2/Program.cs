int HowMany(int x)             // Метод вычисления количества разрядов
{
     int i=1;
     int res = 0;
     while (i<=x)
     {
          i=i*10;
          res++;
     }
     return res;
}
int A = new Random().Next(1,1000000000);
// int A = 1000;                // Заглушка для проверки
Console.WriteLine("У нас есть число " + A + " и цифр в нём " + HowMany(A));