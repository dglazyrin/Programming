void N_1 (int N)                     
{
     if (N>1)
     {
          N--;
          Console.Write(N + " ");
          N_1(N);
     }
}
int A = new Random().Next(2,30);            
Console.Write (A + " => ");
N_1(A);