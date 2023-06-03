void ConvertStringToMass(string InputString, int[]Mass)  // Метод преобразования строки в массив
{
     int xStart = 0;
     int xEnd = 0;
     int yStart = 0;
     int yEnd = 0;
     string coordX = "";
     string coordY = "";
     int i=0;
     do
     {
          xStart = 1;                                  // Разбираю входящую строку на 4 пары координат
          xEnd = InputString.IndexOf(",") - 1;         
          yStart = InputString.IndexOf(",") + 1;;
          yEnd = InputString.IndexOf(")") - 1;
          coordX = InputString.Substring(xStart,xEnd-xStart+1);
          coordY = InputString.Substring(yStart,yEnd-yStart+1);
          Mass[i] = int.Parse(coordX);                 // и парсингом преобразую данные в цифры
          Mass[i+1] = int.Parse(coordY);
          if (i<5)
          {
               InputString = InputString.Substring(yEnd+3,InputString.Length - yEnd-3);
          }
          i=i+2;
     }
     while (i<7);
}    
void MassOut(int[]Mass,double koef) // Метод вывода результата
{
     int y=0;
     do
     {
          Console.Write("("+Mass[y]*koef + ", " + Mass[y+1]*koef + ") ");
          y=y+2;
     }
     while (y<7);
}

int []Coords = new int[8];
Console.Write("Введите данные - "); // (0,0) (2,0) (2,2) (0,2)
string inputLine = Console.ReadLine();
double kMas = 0.5;                  // Коэффициент масштабирования
Console.Write("С коэффициентом масштабирования равным " + kMas + " результат будет ");
ConvertStringToMass(inputLine,Coords);
MassOut(Coords,kMas);