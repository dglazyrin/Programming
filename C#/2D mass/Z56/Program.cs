////// Массив 2D с целыми числами
////// Выводим местами крайние строки

int[,]FillMass(int[,] X)  //Метод заполнения массива
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
          X[i,j]=new Random().Next(-100,100);
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

void ChangeBorderLines(int[,] X)        //Метод замены строк
{     
     int buffer=0;
     for (int i = 0; i < X.GetLength(1); i++)
     {
          buffer = X[0,i];
          X[0,i]=X[X.GetLength(0)-1,i];
          X[X.GetLength(0)-1,i]=buffer;
     }
}

int xSize=new Random().Next(1,10);
int ySize=new Random().Next(1,10);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
ChangeBorderLines (MyMass);
Console.WriteLine("Массив обработан - ");
ShowMass (MyMass);