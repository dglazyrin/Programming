bool Square(int arg1,int arg2) // Метод проверки условия
     {
     return (((arg1/arg2)-arg2)==0);
     }
void Out(int arg3,int arg4)  // Метод вывода
     {
     if (Square(arg3,arg4))
     {
          Console.WriteLine("Число " + arg3 + " является квадратом " + arg4);
     }
     else
     {
          Console.WriteLine("Число " + arg3 + " не является квадратом " + arg4);
     }
     }

int A = new Random().Next(1,100);
int B = new Random().Next(1,100);
Console.WriteLine("Есть два числа - " + A + " и " + B);
Out(A,B);
Out(B,A);