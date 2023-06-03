int A = new Random().Next(1,100);
Console.WriteLine("Между " + -A + " и " + A + " очень много чисел:");
int i=1-A;
while (i < A)
{
     Console.Write(i + " "); 
     ++i;
}