int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
Console.Write(A+", "+B+", "+C+" -> max=");
if (A>B&&A>C)
{
   Console.WriteLine(A);
}
else if (B>A&&B>C)
{
   Console.WriteLine(B);
}
else
{
   Console.WriteLine(C);
}