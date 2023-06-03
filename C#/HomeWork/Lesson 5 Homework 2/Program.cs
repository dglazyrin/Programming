int[]FillMass(int[] X)        //Метод заполнения массива
{
     for (int i = 0; i < 20; i++)
     {
          X[i]=new Random().Next(-100,100);  // Заполняем значениями от -100 до 100
     }
     return X;
}

int SummEvenPos(int[] X)  //Метод поиска чётных значений в списке
{
     int sum = 0;
     for (int i = 0; i < 20;)
     {
          sum = sum + X[i];
          i=i+2;
     }
     return sum;
}

void ShowMass(int[] Y)         //Метод вывода массива
{
     Console.WriteLine("Массив у нас такой - ");
     for (int i = 0; i < 20; i++)
     {
          Console.Write(Y[i] + " ");
     }
     Console.WriteLine("");
}
////////////////////////////////////////////////////////////////////////////////
int []MyMass = new int[20];
FillMass (MyMass);
ShowMass (MyMass);
//int A = Summ1099(MyMass);
Console.WriteLine("Сумма чисел на нечётных позициях равна " + SummEvenPos(MyMass)+" .");