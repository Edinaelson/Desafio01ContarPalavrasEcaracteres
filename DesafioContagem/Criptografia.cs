using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioContagem
{
    public static class Criptografia
    {
        public static void criptografia()
        {
            Console.Write("Input: ");
            string cript = Console.ReadLine();
            string criptogrado = cript.Replace("a", "K").Replace("d","A").Replace("n","J").Replace("r","T").Replace("e","L");
            Console.Write($"Output: {criptogrado}");
        }
    }
}
