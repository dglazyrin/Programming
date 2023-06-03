////// Массив 2D с вещественными числами

double[,]FillMass(double[,] X)  //Метод заполнения массива
{
     Random x=new Random();
     int n=0;
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
          n = x.Next(1,7);
          X[i,j]=Convert.ToDouble(x.Next(-100000000,100000000))/(Math.Pow(10,n));
          }
     }
     return X;
}

void ShowMass(double[,] X)  //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               Console.Write("("+(i+1)+","+(j+1)+")"+X[i,j]+"  ");
          }
          Console.WriteLine();
     }
}

int xSize=new Random().Next(2,8);
int ySize=new Random().Next(2,8);
double [,]MyMass = new double[xSize,ySize];
FillMass (MyMass);
ShowMass (MyMass);