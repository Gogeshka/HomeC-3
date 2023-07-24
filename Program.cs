/* Task 1
int Polin (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int chislo = Polin("Введите 5значное число: ");
if(chislo < 10000 || chislo >= 100000)
{
    Console.WriteLine("Это не 5значное число, введите 5значное число");
    return;
}
if(chislo % 10 == chislo / 10000 || chislo / 10 % 10 == chislo / 1000 % 10)
{
Console.WriteLine("Это число палиндром.");
}
else
{
Console.WriteLine("Это число не палиндром.");
}
*/
/* Task 2

int Coordinata(string cordin, string point)
{
    Console.Write("Введите координату " + cordin + " точки " + point + ": ");
    return Convert.ToInt16(Console.ReadLine());
}
int x1 = Coordinata("x", "A");
int y1 = Coordinata("y", "A");
int z1 = Coordinata("z", "A");
int x2 = Coordinata("x", "B");
int y2 = Coordinata("y", "B");
int z2 = Coordinata("z", "B");

double Solut(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double Length =  Math.Round(Solut(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine("Длина отрезка " + Length);
*/
/* Task 3

int Polin (string mess)
{
    Console.Write(mess);
    string chis = Console.ReadLine();
    int result = Convert.ToInt32(chis);
    return result;
}
int chislo = Polin("Введите число ");
int chis = 1;
int kvadrat = 0;
while(chis <= chislo)
{
    kvadrat = chis * chis;
    Console.WriteLine(chis + "-" + kvadrat);
chis++;
}
*/