void Cube_list (int N)                     // Метод листинга кубов
{
     int i = 1;
     while (i<N)
     {
          Console.Write(Math.Pow(i,3)+" ");
          i++;
     }
}
int A = new Random().Next(2,30);             // Загадаем число
Console.Write (A + " => ");
Cube_list(A);