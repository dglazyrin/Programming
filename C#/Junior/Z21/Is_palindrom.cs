bool Pal(int arg1) // Метод проверки условия
{
     return (((arg1-arg1%1000)/1000)==((arg1%100-arg1%10)/10+(arg1%10)*10));
}
void Out(int arg2)  // Метод вывода
{
     if (Pal(arg2))
     {
          Console.WriteLine(" палиндром");
     }
     else
     {
          Console.WriteLine(" точно не палиндром");
     }
}
int A = new Random().Next(10000,100000);
// A = 12321;                                   // Заглушка для проверки
Console.WriteLine(A);
Out(A);