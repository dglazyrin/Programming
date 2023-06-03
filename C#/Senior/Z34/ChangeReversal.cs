int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 12; i++)
     {
          X[i]=new Random().Next(-99,100);
     }
     return X;
}

int[]ChangeMass(int[] X)        //Метод изменения знаков значений массива
{
     for (int i = 0; i < 12; i++)
     {
          X[i]=0-X[i];
     }
     return X;
}

void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("А массив у нас такой - ");
     for (int i = 0; i < 12; i++)
     {
          Console.Write(Y[i] + " ");
     }
     Console.WriteLine("");
}
int []MyMass = new int[12];
FillMass (MyMass);
ShowMass (MyMass);
Console.WriteLine("Меняем знаки на противоположные - ");
ChangeMass (MyMass);
ShowMass (MyMass);