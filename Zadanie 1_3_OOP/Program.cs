using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    double a;
    double b;
    double c;
    public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
    public Triangle(double z) { a = z; b = z; c = z; }
    public void Write() { Console.WriteLine("Сторони треугольника равны a={0} и b={1} и c={2}", a, b, c); }
    public double Perimetr() { return (a + b + c); }
    public double Area() { double p = (a + b + c) / 2; return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); }
}


class Program
{
    static void Main()
    {
        Triangle ABC_1 = new Triangle(3,4,5);
        Triangle ABC_2 = new Triangle(3);
        double Perimetr, Area;

        Console.WriteLine("Данные по 1 треугольнику");
        ABC_1.Write();
        Perimetr = ABC_1.Perimetr();
        Console.WriteLine("Периметр равняется - " + Perimetr);
        Area = ABC_1.Area();
        Console.WriteLine ("Площадь равняется - " + Area + "\n");

        Console.WriteLine("Данные по 2 треугольнику");
        ABC_2.Write();
        Perimetr = ABC_2.Perimetr();
        Console.WriteLine("Периметр равняется - " + Perimetr);
        Area = ABC_2.Area();
        Console.WriteLine("Площадь равняется - " + Area);
    }
}

