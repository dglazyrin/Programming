double DigitSumm(int x)            // Метод вычисления количества разрядов
{
     int i=1;
     int Digits = 0;
     while (i<=x)
     {
          i=i*10;
          Digits++;                // Сохранили число разрядов в Digits
     }
     int y=0;
     double Summ=0;
     while (y<(Digits+1))
     {                             // Суммируем числа из разряда n по формуле ((A%10^(n+1))-A%(10^n))/10^n;
          Summ=Summ+(((x%Math.Pow(10,y+1))-(x%Math.Pow(10,y)))/(Math.Pow(10,y)));
          y++;
     }
     return Summ;
}
int A = new Random().Next(1,100000);
// int A = 175;                    // Заглушка для проверки
Console.WriteLine("У нас есть число " + A + ", и сумма цифр равна " + DigitSumm(A));