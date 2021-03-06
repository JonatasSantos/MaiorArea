// See https://aka.ms/new-console-template for more information
using System.Globalization;

double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triangulo X:");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com as medidas do triangulo Y:");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

string maiorArea = (areaX > areaY) ? "X" : "Y";

Console.WriteLine("Area de X igual a: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y igual a: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Maior area: " + maiorArea);
