////// Массив 2D с целыми числами
////// Поиск строки с наименьшей суммой

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

void MinSummString(int[,] X)        //Метод поиска (первой, если несколько) строки с минимальной суммой
{
     int summThisString = 0;
     int minSumm = 0;
     int minSummStringNumber=0;
     for (int i = 0; i < X.GetLength(0); i++)
          {
               for (int j = 0; j < X.GetLength(1); j++)
                    {
                         summThisString=summThisString+X[i,j];
                    }
               if ((i==0)|(minSumm > summThisString))
               {
                    minSumm=summThisString;
                    minSummStringNumber=i;
                    summThisString=0;
               }
               summThisString=0;
          }
     Console.WriteLine("Сумма минимальна в строке " + minSummStringNumber + ", она равна " + minSumm);
}

int xSize=new Random().Next(3,21);
int ySize=new Random().Next(3,21);
// Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
MinSummString (MyMass);