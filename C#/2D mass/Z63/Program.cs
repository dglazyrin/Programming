////// Массив 3D с целыми уникальными числами


void FillMass(int[,,] X)  //Метод заполнения массива
{
     int digit = 0;
     for (int x=0; x<X.GetLength(0); x++)
     {
          for (int y=0; y<X.GetLength(1); y++)
          {
               for (int z=0; z<X.GetLength(2); z++)
               {
                    do
                    {
                         digit = new Random().Next(10,99);
                    }
                    while (DigitNotUnic(X,digit));
                    X[x,y,z]=digit;
               }
          }
     }
}

bool DigitNotUnic (int [,,]X, int dig)   // Метод проверки уникальности числа в массиве
{
     bool check=false;
     foreach (int x in X)
     {
          if (dig==x)
          {
               check=true;
          }
     }
     return check;
}

void ShowMass(int[,,] X)  //Метод вывода массива
{
     for (int x = 0; x < X.GetLength(0); x++)
     {
          for (int y = 0; y < X.GetLength(1); y++)
          {
               for (int z = 0; z < X.GetLength(2); z++)
               {
                    Console.Write("("+(x)+","+(y)+","+(z)+")"+X[x,y,z]+" ");
               }
          Console.WriteLine();
          }
     }
}

int [,,]MyMass = new int[2,2,2];
FillMass (MyMass);
Console.WriteLine("Массив у нас такой - ");
ShowMass (MyMass);
