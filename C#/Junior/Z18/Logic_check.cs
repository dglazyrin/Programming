bool Pars(int arg5)                     // Парсер bool
     {                                  
          if(arg5==0)
          {
               return false;            // Преобразует 0 на входе в ЛОЖЬ 
          }                             // а 1 в ИСТИНА
          else
          {
               return true;
          }
     }
bool Log(bool arg1,bool arg2)           // Метод проверки условия
     {
     return (!(arg1|arg2)==(!arg1&!arg2));
     }
void Out(bool arg3,bool arg4)           // Метод вывода
     {
     if (Log(arg3,arg4))
     {
          Console.WriteLine("Истинно так!");
     }
     else
     {
          Console.WriteLine("А вот и нет!");
     }
     }

int C = new Random().Next(0,2);
int D = new Random().Next(0,2);
Console.WriteLine("Есть два значения - " + C + " и " + D);
bool A = Pars(C);
bool B = Pars(D);
Out(A,B);