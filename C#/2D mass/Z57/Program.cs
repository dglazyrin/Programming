////// Массив 2D с целыми числами
////// упорядочивания по убыванию элементы каждой строки

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

void LineMinorSort(int[,] X)        //Метод построчной сортировки по убыванию
{     
     int buffer = X[0,0];
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 1; j < X.GetLength(1); j++)
          {
               for (int k=0; k<X.GetLength(1)-1; k++)
               {
                    if (X[i,k]>X[i,k+1])
                    {
                         buffer=X[i,k];
                         X[i,k]=X[i,k+1];
                         X[i,k+1]=buffer;
                    }
               }
          }
     }    
}

int xSize=new Random().Next(1,10);
int ySize=new Random().Next(1,10);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
LineMinorSort (MyMass);
Console.WriteLine("Массив обработан - ");
ShowMass (MyMass);