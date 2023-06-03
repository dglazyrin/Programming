int A = new Random().Next(1,100);
int B = new Random().Next(1,100);
string Square_flag = " не";
Console.WriteLine("Есть два числа - " + A + " и " + B);
if (B/A == A)
{
   Square_flag = "";
}
Console.WriteLine("Число " + A + Square_flag + " является квадратом числа " + B);