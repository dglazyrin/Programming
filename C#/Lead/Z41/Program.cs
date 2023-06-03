Console.WriteLine("Сколько чисел?");
int quant = int.Parse(Console.ReadLine());
Console.WriteLine("Ок, вводим " + quant + " чисел - ");
int count = 0;
//int digit = 0;
for (int i=1;i<=quant; i++)
{
     int digit = int.Parse(Console.ReadLine());
     if (digit>0)
     {
          count++;
     }
}
Console.WriteLine("Ну чтож, из " + quant + " чисел положительными были " + count);