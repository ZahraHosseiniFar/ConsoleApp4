using System;
class Project
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        double x = Convert.ToDouble(a);
        Console.WriteLine(Cal(x));
        Console.ReadKey();
    }
    private static double Cal(double x)
    {
    double a1 = Math.Pow(x, 2);
    double a2 = Math.Pow(2, x);
    double a3 = Math.Sqrt(x);
    double v = a1 - a2 + a3;
        return v;
    }
}//برنامه ای بنویسید ک عملیات ریاضی را حل کند
