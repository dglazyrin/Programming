////// Массив 2D с целыми числами

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
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               Console.Write("("+(i)+","+(j)+")"+X[i,j]+" ");
          }
          Console.WriteLine();
     }
}

int xSize=new Random().Next(2,11);
int ySize=new Random().Next(2,11);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
ShowMass (MyMass);