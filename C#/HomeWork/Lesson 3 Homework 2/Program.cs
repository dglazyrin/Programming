double Dist(int[]coords1, int[]coords2)                     // Вычисляем расстояние между точками
{
     double result = 0;                                     
     int index = 0;
     while (index < 3)
     {
          result=result + Math.Pow(coords1[index]-coords2[index], 2);
          index++;
     }
     result = Math.Round(Math.Sqrt(result),2);              // в 3D пространстве, округляем до 2х знаков после ,
     return result;
}
void DotDemo (int[] coords)                                 // Вывод координат двух точек
{
     Console.Write("Точка c координатами: ");
     int index = 0;
     while (index < 3)
     {
          Console.Write(coords[index] + " ");
          index++;
     }
     Console.WriteLine("");
}
void FillArray(int[] coords)                                // Точка - это массив с её координатами
{
     int index = 0;                               
     while (index < 3)                                      // Создаём массив с координатами
     {                                                      // в диапазоне (-1000, 1000)
          coords[index] = new Random().Next(-1000,1000);    // и заполняем его.
          index++;
     }
}
int[] coordA = new int[3];
int[] coordB = new int[3];
FillArray (coordA);
FillArray (coordB);
DotDemo (coordA);
DotDemo (coordB);
Console.Write("Расстояние между ними: " + Dist(coordA, coordB));