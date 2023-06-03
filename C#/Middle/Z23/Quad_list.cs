void Quad_list (int N)                     // Метод листинга квадратов
{
     int i = 1;
     while (i<N)
     {
          Console.Write(Math.Pow(i,2)+" ");
          i++;
     }
}
int A = new Random().Next(2,35);             // Загадаем число
Console.Write (A + " => ");
Quad_list(A);