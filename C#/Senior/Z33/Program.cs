int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 12; i++)
     {
          X[i]=new Random().Next(-9,10);
     }
     return X;
}
int CountPlus(int[] X)        //Метод подсчёта положительных чисел в массиве
{
     int count = 0;
     for (int i = 0; i < 12; i++)
     {
          if (X[i]>=0)
          {
               count++;
          }
     }
     return count;
}
void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < 12; i++)
     {
          Console.Write(Y[i] + " ");
     }
}
int []MyMass = new int[12];
FillMass (MyMass);
ShowMass (MyMass);
int Plus = CountPlus(MyMass);
Console.WriteLine();
Console.Write("Положительных значений в нём " + Plus + ", а отрицательных - " + (12-Plus) + ".");