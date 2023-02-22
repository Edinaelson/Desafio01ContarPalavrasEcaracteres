using System;

namespace DesafioContagem
{
    public static class Troco
    {
        public static void troco()
        {
            float valorCompra;
            float pagamento;

            Console.WriteLine("- Valor da compra: ");
            valorCompra = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("- Pagamento: :");
            pagamento = Convert.ToSingle(Console.ReadLine());

            float valor = pagamento - valorCompra;
          
            int cont100 = 0;
            while (valor >= 100)
            {
                 cont100++;
                 valor = valor - 100;
            }
            int cont50 = 0;
            while (valor >= 50)
            {
                cont50++;
                valor = valor - 50;  
            }
            int cont10 = 0;
            while (valor >= 10)
            {
                cont10++;
                valor = valor - 10;
            }
            int cont2 = 0;
            while (valor >= 2)
            {
                cont2++;
                valor = valor - 2;
            }

            if (cont100 > 0)
            {
                Console.WriteLine($"- {cont100} nota de 100 reais");
            }
            if (cont50 > 0 )
            {
                Console.WriteLine($"- {cont50} nota de 50 reais");
            }
            if (cont10 > 0)
            {
                Console.WriteLine($"- {cont10} nota de 10 reais");
            }
            if (cont2 > 0)
            {
                Console.WriteLine($"- {cont2} nota de 2 reais");
            }
        }
    }
}
