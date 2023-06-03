string [] day = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"}; // Массив с днями недели
Console.WriteLine("День-то сегодня какой?");                                                   // Спрашиваем номер дня
int day_number = int.Parse(Console.ReadLine())-1;                                              // Расшифруем
Console.Write("Значит сегодня - " + day[day_number]);
if((day_number+1)<6)
{
     Console.WriteLine(", идите работать!");
}
else
{
     Console.WriteLine(", отдыхайте!");
}