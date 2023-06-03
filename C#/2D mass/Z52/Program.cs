////// Массив 2D с целыми числами
////// Меняем знак у двух чётных индексов на их квадраты

int[,]FillMass(int[,] X)  //Метод заполнения массива
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
          X[i,j]=new Random().Next(-99,100);
          }
     }
     return X;
}

void ShowMass(int[,] X)  //Метод вывода массива
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               Console.Write("("+(i)+","+(j)+")"+X[i,j]+" ");
          }
          Console.WriteLine();
     }
}

void ChangeSquare(int[,] X)  //Метод обработки массива
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          if (i%2==0)
          {
               for (int j = 0; j < X.GetLength(1); j++)
               {
                    if (j%2==0)
                    {
                         X[i,j]=(X[i,j]*X[i,j]);
                    }
               }
          }
     }
}

int xSize=new Random().Next(2,11);
int ySize=new Random().Next(2,11);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас был такой - ");
ShowMass (MyMass);
ChangeSquare (MyMass);
Console.WriteLine("После обработки массив стал такой - ");
ShowMass (MyMass);