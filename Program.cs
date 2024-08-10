using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EquaCub
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Raizes da equação de 3º grau");

            //Coletando os dados da equação
            Console.Write("Informe o A da equação: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Informe o B da equação: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Informe o C da equação: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Informe o D da equação: ");
            int d = int.Parse(Console.ReadLine());

            int fator = d / a; //Dividimos D por A, usamos Fator mais a frente
            List<int> div = new List<int>();
            int x1 = 0;

            //Obtendo os divisores positivos e negativos da variável fator
            for (int i = 1; i <= fator / 2; i++)
            {
                if (fator % i == 0)
                {
                    div.Add(i);
                    div.Add(i * -1);
                }
            }

            //Substituindo os X da equação pelos divisores de fator até dar 0
            foreach(var x in div)
            {
                double a1 = a * Math.Pow(x, 3);
                double b1 = b * Math.Pow(x, 2);
                double c1 = c * x;
                if (a1 + b1 + c1 + d == 0)
                {
                    x1 = x;
                    break;
                }
            }

            //Briot Ruffini, convertendo a equação de 3º para 2º
            int r = x1;
            int a2 = r * a;
            int b2 = b + a2;
            int temp = r * b2;
            int c2 = c + temp;
            temp = r * c2;
            temp = d + temp;

            //Realizando Delta e Baskara após a converçãp
            double delta = (Math.Pow(b2, 2)) + (-4 * a* c2);

            double x2 = (-b2 + Math.Sqrt(delta)) / (2 * a);
            double x3 = (-b2 - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"As raizes da equação são: {x1}, {x2} e {x3}");
        }
    }
}
