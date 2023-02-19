using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioContagem
{
    public static class Combustivel
    {
        public static void combustivel()
        {
            float alcool = 1;
            float gasolina = 1;

            Console.WriteLine("Informe valor do alcool: ");
            alcool = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe valor da gasolina: ");
            gasolina = Convert.ToSingle(Console.ReadLine());

            float correlacao = (alcool / gasolina);
            Console.WriteLine($"{correlacao}");

            if( correlacao > 0.65 ) 
            {
                Console.WriteLine("Alcool é a melhor opção");
            }
            if(correlacao > 0.72)
            {
                Console.WriteLine("Economizará abastecendo com alcool");
            }

        }
    }
}
