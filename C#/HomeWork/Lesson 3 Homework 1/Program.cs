bool Pal(int arg1) // Метод проверки условия на палиндромность
{
     return (((arg1-arg1%1000)/1000)==((arg1%100-arg1%10)/10+(arg1%10)*10));
}
void Out(int arg2)  // Метод вывода
{
     if (Pal(arg2))
     {
          Console.WriteLine("Это палиндром");
     }
     else
     {
          Console.WriteLine("Это не палиндром");
     }
}
Console.Write("Введите число - ");
int A = int.Parse(Console.ReadLine());
Out(A);