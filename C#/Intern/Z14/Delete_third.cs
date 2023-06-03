int A = new Random().Next(1,1000);
Console.Write("У нас есть число " + A + " и его третья цифра ");
if ((A/100)>0)
{
     Console.Write((A%10));
}
else
{
     Console.Write("отсутствует.");
}