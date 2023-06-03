int Deg(int x, int y)                     // Метод возведения х в степень у
{
     int i = 0;
     int res = 1;
     while (i<y)
     {
          res = (res * x);
          i++;
     }
     return res;
}
int A = new Random().Next(1,10);   // Загадаем число
int B = new Random().Next(1,10);     // Загадаем степень
Console.WriteLine ("У нас есть число " + A + " и в степени " + B + " оно = " + Deg(A,B));