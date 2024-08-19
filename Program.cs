using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o grau da equação: ");
        Console.WriteLine("1- Segundo Grau");
        Console.WriteLine("2- Terceiro Grau");
        Console.WriteLine("3- Quarto Grau");
        Console.Write("\nOpção: ");

        int opc = int.Parse(Console.ReadLine());
        double a, b, c, d, e, x1, a2, b2, c2, d2, temp;
        double a1, b1, c1, d1, r;
        double x2, x3, delta;
        List<Double> Raizes = new List<Double>();

        switch (opc)
        {
            case 1:
                Console.Write("Informe o A da equação: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Informe o B da equação: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Informe o C da equação: ");
                c = int.Parse(Console.ReadLine());

                delta = (Math.Pow(b, 2)) + (-4 * a * c);

                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                x3 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"As raizes da equação são: {x2} e {x3}");
                break;

            case 2:
                Console.Write("Informe o A da equação: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Informe o B da equação: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Informe o C da equação: ");
                c = int.Parse(Console.ReadLine());

                Console.Write("Informe o D da equação: ");
                d = int.Parse(Console.ReadLine());

                if (a + b + c + d == 0)
                {
                    x1 = 1;
                }

                else
                {
                    double fator = d / a;
                    
                    List<int> div = new List<int>();
                    x1 = 0;

                    for (int i = 1; i <= Math.Abs(fator); i++)
                    {
                        if (fator % i == 0)
                        {
                            div.Add(i);
                            div.Add(i * -1);
                        }
                    }

                    foreach (var x in div)
                    {
                        a1 = a * Math.Pow(x, 3);
                        b1 = b * Math.Pow(x, 2);
                        c1 = c * x;

                        if (a1 + b1 + c1 + d == 0)
                        {
                            x1 = x;
                            break;
                        }
                    }
                }

                r = x1;
                a2 = r * a;
                b2 = b + a2;
                temp = r * b2;
                c2 = c + temp;
                temp = r * c2;
                temp = d + temp;

                delta = (Math.Pow(b2, 2)) + (-4 * a * c2);

                x2 = (-b2 + Math.Sqrt(delta)) / (2 * a);
                x3 = (-b2 - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"As raizes da equação são: {x1}, {x2} e {x3}");
                break;

            case 3:
                Console.Write("Informe o A da equação: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Informe o B da equação: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Informe o C da equação: ");
                c = int.Parse(Console.ReadLine());

                Console.Write("Informe o D da equação: ");
                d = int.Parse(Console.ReadLine());

                Console.Write("Informe o E da equação: ");
                e = int.Parse(Console.ReadLine());

                if (a + b + c + d + e == 0)
                {
                    x1 = 1;
                    Raizes.Add(1);
                }

                else
                {
                    double fator = e / a;
                    Math.Abs(fator);
                    List<int> div = new List<int>();
                    x1 = 0;

                    for (int i = 1; i <= fator; i++)
                    {
                        if (fator % i == 0)
                        {
                            div.Add(i);
                            div.Add(i * -1);
                        }
                    }

                    foreach (var x in div)
                    {
                        a1 = a * Math.Pow(x, 4);
                        b1 = b * Math.Pow(x, 3);
                        c1 = c * Math.Pow(x, 2);
                        d1 = d * x;

                        if (a1 + b1 + c1 + d1 + e == 0)
                        {
                            Raizes.Add(x);
                            break;
                        }
                    }
                }

                r = x1;
                a2 = a;
                temp = r * a2;
                b2 = b + temp;
                temp = r * b2;
                c2 = c + temp;
                temp = r * c2;
                d2 = d + temp;
                temp = r * d2;
                temp = e + temp;

                double fatora = d2 / a2;

                List<int> diva = new List<int>();
                x2 = 0;

                for (int i = 1; i <= Math.Abs(fatora); i++)
                {
                    if (fatora % i == 0)
                    {
                        diva.Add(i);
                        diva.Add(i * -1);
                    }
                }

                foreach (var x in diva)
                {
                    a1 = a2 * Math.Pow(x, 3);
                    b1 = b2 * Math.Pow(x, 2);
                    c1 = c2 * x;

                    if (a1 + b1 + c1 + d2 == 0)
                    {
                        Raizes.Add(x);
                    }
                }

                Console.Write("Raizes da equação: ");

                foreach(var x in Raizes)
                {
                    Console.Write($"{x} ");
                }


                break;
        }
    }
}
