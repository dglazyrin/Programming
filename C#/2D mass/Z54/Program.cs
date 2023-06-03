////// Массив 2D с целыми числами
////// Выводим сумму элементов главной диагонали

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

void MainDia(int[,] X)  // Метод нахождения суммы ГД в матрице
{
     int mainD = 0;
     int sumMD = 0;
     if (X.GetLength(0)<X.GetLength(1))
     {
          mainD=X.GetLength(0);
     }
     else
     {
          mainD=X.GetLength(1);
     }
     Console.Write("Главная диагональ ");
     for (int i = 0; i < mainD; i++)
     {
          sumMD = sumMD + (X[i,i]);
          Console.Write(" (" + X[i,i] + ") ");
     }
     Console.WriteLine(" Сумма равна " + sumMD + ".");
}

int xSize=new Random().Next(2,11);
int ySize=new Random().Next(2,11);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
MainDia(MyMass);