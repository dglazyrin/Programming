////// Массив 2D с целыми числами
////// Выводим позицию введённого числа

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

void FindNumber(int[,] X, int num)  //Метод поиска в массиве
{
     bool flagNo=true;
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               if (X[i,j]==num)
               {
                    Console.WriteLine("Есть такое число, строка " + i + ", столбец " + j);
                    flagNo=false;
               }
          }
     }
     if (flagNo)
     {
          Console.WriteLine("Нет такого числа");
     }
}

int xSize=new Random().Next(2,11);
int ySize=new Random().Next(2,11);
int [,]MyMass = new int[xSize,ySize];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
FindNumber (MyMass,number);