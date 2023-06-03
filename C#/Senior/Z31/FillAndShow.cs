int[]FillMass(int[] X)  //Метод заполнения массива
{
     for (int i = 0; i < 8; i++)
     {
          X[i]=new Random().Next(10,100);
     }
     return X;
}
void ShowMass(int[] Y)  //Метод вывода массива
{
     Console.Write("А массив у нас такой - ");
     for (int i = 0; i < 8; i++)
     {
          Console.Write(Y[i] + "  ");
     }
}

int []MyMass = new int[8];
FillMass (MyMass);
ShowMass (MyMass);