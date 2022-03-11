// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Promt(string massage)
{
    Console.Write(massage);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}

double x1 = Promt("Введите коордитнату х1 точки А => ");
double y1 = Promt("Введите коордитнату y1 точки А => ");
double z1 = Promt("Введите коордитнату z1 точки А => ");
double x2 = Promt("Введите коордитнату х2 точки B => ");
double y2 = Promt("Введите коордитнату y2 точки B => ");
double z2 = Promt("Введите коордитнату z2 точки B => ");

//Console.WriteLine("Введите коордитнату х1 точки А => ");
//String x1 = Console.ReadLine();
//int xa = int.Parse(x1);
//Console.WriteLine("Введите коордитнату y1 точки А => ");
//String y1 = Console.ReadLine();
//int ya = int.Parse(y1);
//Console.WriteLine("Введите коордитнату z1 точки А => ");
//String z1 = Console.ReadLine();
//int za = int.Parse(z1);
//Console.WriteLine("Введите коордитнату х2 точки B => ");
//String x2 = Console.ReadLine();
//int xb = int.Parse(x2);
//Console.WriteLine("Введите коордитнату y2 точки B => ");
//String y2 = Console.ReadLine();
//int yb = int.Parse(y2);
//Console.WriteLine("Введите коордитнату z2 точки B => ");
//String z2 = Console.ReadLine();
//int zb = int.Parse(z2);
double xab = (x2 - x1);
double yab = (y2 - y1);
double zab = (z2 - z1);
double D = Math.Sqrt(Math.Pow(xab,2) + Math.Pow(yab,2) + Math.Pow(zab,2));

Console.WriteLine("Расстояние между точками в 3D пространстве " + D);
