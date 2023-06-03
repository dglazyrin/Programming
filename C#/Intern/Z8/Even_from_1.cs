int A = new Random().Next(1,100);
Console.WriteLine("Между 1 " + " и " + A + " много чётных чисел:");
int i=2;
while (i < A)
{
     Console.Write(i + " "); 
     i = i + 2;
}