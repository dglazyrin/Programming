int A = new Random().Next(10,100);
Console.Write("У нас есть число " + A);
int Digit1 = A%10;
int Digit2 = (A-Digit1)/10;
if (Digit1>Digit2)
{
     Console.Write(" И наибольшая цифра в нём - " + Digit1);
}
else
{
     Console.Write(" И наибольшая цифра в нём - " + Digit2);
}