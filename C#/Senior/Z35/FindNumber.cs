int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 100; i++)
     {
          X[i]=new Random().Next(0,100);
     }
     return X;
}

bool NumberInclude(int[] X,int y)  //Метод поиска значения в массиве
{
     bool flag = false;
     for (int i = 0; i < 100; i++)
     {
          if (X[i]==y)
          {
               flag=true;
               break;
          }
     }
     return flag;
}

void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < 100; i++)
     {
          Console.Write(Y[i] + " ");
     }
     Console.WriteLine("");
}


int []MyMass = new int[100];
FillMass (MyMass);
ShowMass (MyMass);
Console.WriteLine("Какое число (0-99) ищем? - ");
int Z = int.Parse(Console.ReadLine());
if (NumberInclude(MyMass,Z))
{
     Console.WriteLine("Есть такое число в массиве");
}
else
{
     Console.WriteLine("Нет такого числа в массиве");
}