////// Массив 2D с целыми числами
////// Транспонирование квадратной матрицы

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

void ShowMass(int[,] X)  //Метод вывода массива без координат
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               Console.Write(X[i,j] + "  ");
          }
          Console.WriteLine();
     }
}

void TransponMatr(int[,] X)        //Метод транспонирования матрицы
{     
     if (!(X.GetLength(0)==X.GetLength(1)))
     {
          Console.WriteLine("Транспонирование невозможно!");
          return;
     }
     Console.WriteLine("Транспонированию быть!");
     int buffer = X[0,0];
     for (int i = 0; i < X.GetLength(0)-1; i++)
     {
          for (int j = i+1; j < X.GetLength(0); j++)
          {
               buffer=X[i,j];
               X[i,j]=X[j,i];
               X[j,i]=buffer;
          }
     }
}

int xSize=new Random().Next(5,7);
int ySize=new Random().Next(5,7);
// Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
TransponMatr (MyMass);
Console.WriteLine("Массив обработан - ");
ShowMass (MyMass);