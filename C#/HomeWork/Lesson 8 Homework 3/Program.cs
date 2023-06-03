////// Массив 2D с целыми числами
////// Перемножение матриц

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

void ShowMass(int[,] X)  //Метод вывода массива без координат с выравниванием 
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               if ((X[i,j]<10)&(X[i,j]>=0))
               {
                    Console.Write("  " + X[i,j]+" ");
               }
               if (((X[i,j]<0)&(X[i,j]>=-9))||((X[i,j]>9)))
               {
                    Console.Write(" " + X[i,j]+" ");
               }
               if ((X[i,j]<-9))
               {
                    Console.Write(X[i,j] + " ");
               }
          }
          Console.WriteLine();
     }
}

int[,]MatrMult(int[,]X,int[,]Y,int[,]Z)        //Метод перемножения матриц 
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < Y.GetLength(1); j++)
          {
               for (int k = 0; k < X.GetLength(1); k++)
               {
                    {
                        Z[i,j]=Z[i,j]+X[i,k]*Y[k,j];
                    }
               }
          }
     }
     return Z;
}

int xSize=new Random().Next(2,9);
int ySize=new Random().Next(2,9);
int zSize=new Random().Next(2,9);
Console.WriteLine("Умножаем матрицу " + xSize + " на " + ySize + " на матрицу " + ySize + " на " + zSize);
Console.WriteLine("Получаем матрицу " + xSize + " на " + zSize);
int [,]Matr1 = new int[xSize,ySize];
int [,]Matr2 = new int[ySize,zSize];
int [,]Matr3 = new int[xSize,zSize];
FillMass (Matr1);
FillMass (Matr2);
Console.WriteLine("Матрицы у нас такие - ");
ShowMass (Matr1);
Console.WriteLine("Вторая - ");
ShowMass (Matr2);
Console.WriteLine("Результат произведения - ");
MatrMult (Matr1,Matr2,Matr3);
ShowMass (Matr3);