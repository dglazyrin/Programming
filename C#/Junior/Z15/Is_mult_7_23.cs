bool Mult(int arg1,int arg2) // Метод проверки кратности
     {
     return (arg1%arg2==0);
     }
void Out(int arg3,int arg4)  // Метод вывода
     {
     if (Mult(arg3,arg4))
     {
          Console.WriteLine("Оно кратно " + arg4);
     }
     else
     {
          Console.WriteLine("Оно не кратно " + arg4);
     }
     }
int A=new Random().Next(1,100);
Console.WriteLine("Есть число - " + A);
Out(A,7);
Out(A,23);