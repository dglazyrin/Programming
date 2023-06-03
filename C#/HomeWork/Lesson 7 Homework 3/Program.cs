////// Массив 2D с целыми числами
////// Выводим среднее арифметическое по столбцам

int[,]FillMass(int[,] X)  //Метод заполнения массива
{
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
          X[i,j]=new Random().Next(10,100);
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

void CountSA(int[,] X)        //Метод подсчёта CA столбца
{
     int size = X.GetLength(1);
     double []Mass=new double[size];
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j <X.GetLength(1) ; j++)
          {
               Mass[j] = Mass[j] + X[i,j];
          }
     }
     for (int i = 0; i < X.GetLength(1); i++)
     {
          Console.WriteLine("Сумма столбца " + i + " = " + Mass[i] + ", СА в столбце = " + Math.Round(Mass[i]/X.GetLength(0),2));
     }
}

int xSize=new Random().Next(2,10);
int ySize=new Random().Next(2,10);
Console.WriteLine("Массив " + xSize + " на " + ySize);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
CountSA (MyMass);