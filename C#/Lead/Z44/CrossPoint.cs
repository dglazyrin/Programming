int k1 = new Random().Next(-10,11);
int k2 = new Random().Next(-10,11);                                 
int b1 = new Random().Next(-10,11);
int b2 = new Random().Next(-10,11);   // Загадаем четыре числа
Console.WriteLine("У нас есть две прямые:");
Console.WriteLine("y1 = " + k1 + ("x + (" + b1 + ")"));
Console.WriteLine("y2 = " + k2 + ("x + (" + b2 + ")"));
if (k2==k1)
{
     Console.WriteLine("Они параллельны, точек пересечения нет.");     
}
else
{     
     double x01 = b2-b1;
     double x02 = k1-k2;
     double x = Math.Round(x01/x02,2);
     double y = Math.Round(k1*x+b1,2);
     Console.WriteLine("Они пересекаются в точке (" + x + ", " + y + ").");     
}