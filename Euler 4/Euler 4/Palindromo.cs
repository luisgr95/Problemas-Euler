using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    class Palindromo
    {
        public static int cPalindromo(int medio)
        {
            char[] reverso = medio.ToString().Reverse().ToArray();
            return Convert.ToInt32(medio + new string(reverso));
        }
    }
}
