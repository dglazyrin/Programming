int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 20; i++)
     {
          X[i]=new Random().Next(100,1000);
     }
     return X;
}

int Divide2(int[] X)  //Метод поиска чётных значений в списке
{
     int res = 0;
     for (int i = 0; i < 20; i++)
     {
          if (X[i]%2==0)
          {
               res++;
          }
     }
     return res;
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
///////////////////////////////////////
int []MyMass = new int[20];
FillMass (MyMass);
ShowMass (MyMass);
int A = Divide2(MyMass);
Console.WriteLine("В нём " + A + " чётных чисел");