byte Digit2Number(int X)             // Метод определения разрядности двоичного числа
{
     byte res=1;
     while ((Math.Pow(2,res)<=X))
     {
          res++;
     }
     return res;
}
double Number10To2(int X, byte Y)        // Метод перевода числа 10 -> 2
{
     byte myCount=0;
     double res=0;//Math.Pow(10,Y);
     while (X>0)
     {
          if ((X%2)==1)
          {
               res = res + Math.Pow(10,myCount);     
          }
          X=X/2;
          myCount++;
     }
     return res;
}

int myNumber10 = new Random().Next(1,10000);   //Заглушка для проверки
byte digitNumber = Digit2Number(myNumber10);
double myNumber2 = Number10To2(myNumber10,digitNumber);
Console.WriteLine("У нас есть число - " + myNumber10 + " у него " + digitNumber + " бит.");
Console.WriteLine("В двоичной системе это - " + myNumber2 + " .");
Console.Write("А через парсинг преобразования в стринг это тоже ");
myNumber2 = double.Parse(Convert.ToString(myNumber10,2));
Console.WriteLine(myNumber2 + ".");