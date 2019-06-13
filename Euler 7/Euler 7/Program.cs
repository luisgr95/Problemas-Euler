using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPrimos = 1;
            int numm = 1;
            int pasos = 10001;
            while (numPrimos < pasos)
            {
                numm = numm + 2;
                if (Divisiontrial.primo(numm))
                {
                    numPrimos++;
                }
            }
            Console.WriteLine("El numero de {0}st su primo es {1}", pasos, numm); 
            Console.ReadKey();
        } 
    }
}
