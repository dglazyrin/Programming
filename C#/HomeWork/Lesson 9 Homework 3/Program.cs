int Akker (int N1, int N2)
{
  if (N1 == 0)
    return N2 + 1;
  else
    if ((N1!=0) && (N2==0))
      return Akker(N1-1,1);
    else
      return Akker(N1-1,Akker(N1,N2-1));
}

int A = new Random().Next(1,4);            
int B = new Random().Next(1,4);            
Console.WriteLine ($"У нас есть две переменные - {A} и {B}. Вычислим значение функции Аккермана для них.");
Console.WriteLine(Akker(A,B));