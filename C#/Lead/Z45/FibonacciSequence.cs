double digit1 = 0;
double digit2 = 1;
for (int i=1;i<43;i++) // Число Фибоначчи № 84 - 99194853094755490 - видимо максимальное
{                      // правильно отображаемое в VS.
     Console.Write(digit1 + " " + digit2 + " ");
     digit1=digit1+digit2;
     digit2=digit2+digit1;
}