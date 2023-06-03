int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 123; i++)
     {
          X[i]=new Random().Next(0,120);  // Заполняем значениями от 0 до 119
     }
     return X;
}

int Summ1099(int[] X)  //Метод поиска значений 10to99 в списке
{
     int res = 0;
     for (int i = 0; i < 123; i++)
     {
          if ((X[i]>10)&(X[i]<99))
          {
               res++;
          }
     }
     return res;
}

void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("Массив у нас такой - ");
     for (int i = 0; i < 123; i++)
     {
          Console.Write(Y[i] + " ");
     }
     Console.WriteLine("");
}
////////////////////////////////////////////////////////////////////////////////
int []MyMass = new int[123];
FillMass (MyMass);
ShowMass (MyMass);
int A = Summ1099(MyMass);
Console.WriteLine("В нём " + A + " чисел от 10 до 99");