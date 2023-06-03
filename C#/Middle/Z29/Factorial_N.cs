double Fact(int x)             // Метод вычисления факториала
{
     int i=1;
     double res = 1;
     while (i<=x)
     {
          res=res*i;
          i++;
     }
     return res;
}
int A = new Random().Next(1,18); // Ограничил диапазон, дальше итоги зашкаливают и не наглядны
// int A = 10;                   // Заглушка для проверки
Console.WriteLine("У нас есть число " + A + " и его факториал равен " + Fact(A));