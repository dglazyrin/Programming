void CubeEven(int x)             // Метод вычисления куба
{
     int i=2;
     while (i<=x)
     {
          Console.Write((Math.Pow(i,3)) + " ");
          i=i+2;
     }
}
int A = new Random().Next(1,18); // Ограничил диапазон, дальше итоги зашкаливают и не наглядны
// int A = 10;                   // Заглушка для проверки
Console.Write("У нас есть число " + A + " и кубы чётных чисел меньше него - ");
CubeEven(A);