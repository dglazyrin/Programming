void N_between (int N1,int N2,int sum)
{
     sum=sum+N1;
     if (N1<N2)
     {
          N1++;
          N_between(N1,N2,sum);
     }
     else
     Console.WriteLine ("Сумма чисем между ними - "+ sum);     
}
int A = new Random().Next(1,9);            
int B = new Random().Next(10,99);
int sum=0;            
Console.WriteLine ($"У нас есть две переменные - {A} и {B}");
N_between(A,B,0);