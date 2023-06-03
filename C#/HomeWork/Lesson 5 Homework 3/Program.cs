int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 20; i++)
     {
          X[i]=new Random().Next(-100,100);  // Заполняем значениями от -100 до 100
     }
     return X;
}

int FindPosMax(int[] X)  //Метод поиска позиции максимума массива
{
     int max = 1;
     for (int i = 0; i < 20;i++)
     {
          if (X[i]>X[max])
          {
               max=i;
          }
     }
     return max;
}

int FindPosMin(int[] X)  //Метод поиска позиции минимума массива
{
     int min = 1;
     for (int i = 0; i < 20;i++)
     {
          if (X[i]<X[min])
          {
               min=i;
          }
     }
     return min;
}

void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("Массив у нас такой - ");
     for (int i = 0; i < 20; i++)
     {
          Console.Write(Y[i] + " ");
     }
     Console.WriteLine("");
}
////////////////////////////////////////////////////////////////////////////////
int []MyMass = new int[20];
FillMass (MyMass);
ShowMass (MyMass);
int MaxPos = FindPosMax(MyMass);
int MinPos = FindPosMin(MyMass);
Console.WriteLine("Максимум - " + MyMass[MaxPos]+ ", минимум - "+ MyMass[MinPos] + ". Их разность равна " + (MyMass[MaxPos]-MyMass[MinPos]) + ".");