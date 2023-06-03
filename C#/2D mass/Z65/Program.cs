////// Массив 2D с целыми числами
////// Спиральное заполнение квадратных массивов от 4 до 9

int [,] FillMassSpirStep(int[,] X, int step)  //Метод заполнения кольца массива
{
     int counter=1;
     if (step>0)
          {
               counter=X[step,step-1]+1;
          }
     int down=X.GetLength(0)-step-1;
     for (int i = step; i < (down+1); i++)      // Заполнили вправо
     {
          X[step,i]=counter;
          counter=counter+1;
     }
     for (int i = step+1; i < (down+1); i++)      // Заполнили вниз
     {
          X[i,down]=counter;
          counter=counter+1;
     }
     for (int i = down; i > step; i--)      // Заполнили влево
     {
          X[down,i-1]=counter;
          counter=counter+1;
     }
     for (int i = down; i > (step+1); i--)      // Заполнили вверх
     {
          X[i-1,step]=counter;
          counter=counter+1;
     }
     return X;
}

void FillMass(int[,] X)
{
     int steps=X.GetLength(0)-2;
     for (int i=0; i<steps; i++)
     {
          FillMassSpirStep(X,i);
     }
}

void ShowMass(int[,] X)  //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < X.GetLength(0); i++)
     {
          for (int j = 0; j < X.GetLength(1); j++)
          {
               if (X[i,j]<10)
               {
                    Console.Write("0" + X[i,j]+" ");
               }
               else
               {
                    Console.Write(X[i,j]+" ");
               }
          }
          Console.WriteLine();
     }
}
int size=new Random().Next(4,10);
int [,]Mass = new int[size,size];
FillMass (Mass);
Console.WriteLine("Заполним массив "+size+"x"+size);
ShowMass (Mass);