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