using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int medio = 998, palin = 0;
            int[] factors = new int[2];

            while (!found)
            {
                medio--;
                palin = Palindromo.cPalindromo(medio);
                for (int i = 999; i > 99; i--)
                {
                    if ((palin / i) > 999 || i * i < palin)
                    {
                        break;
                    }

                    if ((palin % i == 0))
                    {
                        found = true;
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }

            Console.WriteLine("El palindromo mas largo {0}, El cual esta formado por {1}*{2}", palin, factors[0], factors[1]);
            Console.ReadKey();
        }
    }
}
