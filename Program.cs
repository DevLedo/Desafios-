

using System.Formats.Asn1;
using System.Globalization;

double Xa, Xb, Xc, Ya, Yb, Yc;

Console.WriteLine("Entre com as medidas do trinângulo X: ");
Xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com as medidas do triangulo Y: ");
Ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//
double p = (Xa + Xb + Xc)/ 2.0; 
double areaX = Math.Sqrt(p * (p-Xa) * (p-Xb) * (p-Xc));

p = (Ya + Yb + Yc) / 2.0;
double areaY = Math.Sqrt(p * (p - Ya) * (p - Yb) * (p - Yc));

Console.WriteLine("Area de X: "+areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y: "+areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine(" Maior Area: X");
}
else
{
    Console.WriteLine("maior Area: Y");
}
