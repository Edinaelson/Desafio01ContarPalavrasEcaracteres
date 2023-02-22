using System;
namespace DesafioContagem
{
    public static class NomePorExtenso
    {
        public static void nomePorExtenso()
        {
            float valorCompra = 0.0f;
            float valorFinal = 0.0f;

            Console.Write("Valor final da compra: ");
            valorCompra = Convert.ToSingle(Console.ReadLine());
            valorFinal = valorCompra;

            if (valorCompra >= 100 && valorCompra < 200)
            {
                Console.Write("Cem");
                valorFinal =  valorFinal - 100;
            }
            if (valorCompra >= 200 && valorCompra < 300)
            {
                Console.Write("Duzentos");
                valorFinal = valorFinal - 200;
            }
            if (valorCompra >= 300 && valorCompra < 400)
            {
                Console.Write("Trezentos");
                valorFinal = valorFinal - 300;
            }
            if (valorCompra >= 400 && valorCompra < 500)
            {
                Console.Write("Quatrocentos");
                valorFinal = valorFinal - 400;
            }
            if (valorCompra >= 500 && valorCompra < 600)
            {
                Console.Write("Quinhentos");
                valorFinal = valorFinal - 500;
            }
            if (valorCompra >= 600 && valorCompra < 700)
            {
                Console.Write("Seiscentos");
                valorFinal = valorFinal - 600;
            }
            if (valorCompra >= 700 && valorCompra < 800)
            {
                Console.Write("Setecentos");
                valorFinal = valorFinal - 700;
            }
            if (valorCompra >= 800 && valorCompra < 900)
            {
                Console.Write("Oitocentos");
                valorFinal = valorFinal - 800;
            }
            if (valorCompra >= 900 && valorCompra < 1000)
            {
                Console.Write("Novecentos");
                valorFinal = valorFinal - 900;
            }
            if (valorCompra >= 1000 && valorCompra < 2000)
            {
                Console.Write("Mil reais");
                valorFinal = valorFinal - 1000;
            }
            if (valorFinal >= 10 && valorFinal < 20)
            {
                Console.Write(" Dez");
                valorFinal = valorFinal - 10;
            }
            if (valorFinal >= 20 && valorFinal < 30)
            {
                Console.Write(" Vinte");
                valorFinal = valorFinal - 20;
            }
            if (valorFinal >= 30 && valorFinal < 40)
            {
                Console.Write(" Trinta");
                valorFinal = valorFinal - 30;
            }
            if (valorFinal >= 40 && valorFinal < 50)
            {
                Console.Write(" Quarenta");
                valorFinal = valorFinal - 40;
            }
            if (valorFinal >= 50 && valorFinal < 60)
            {
                Console.Write(" Cinquenta");
                valorFinal = valorFinal - 50;
            }
            if (valorFinal >= 60 && valorFinal < 70)
            {
                Console.Write(" Sessenta");
                valorFinal = valorFinal - 60;
            }
            if (valorFinal >= 70 && valorFinal < 80)
            {
                Console.Write(" Setenta");
                valorFinal = valorFinal - 70;
            }
            if (valorFinal >= 80 && valorFinal < 90)
            {
                Console.Write(" Oitenta");
                valorFinal = valorFinal - 80;
            }
            if (valorFinal >= 90 && valorFinal < 100)
            {
                Console.Write(" Noventa");
                valorFinal = valorFinal - 90;
            }
            if (valorFinal >= 1 && valorFinal < 2)
            {
                Console.Write(" Um real");
                valorFinal = valorFinal - 1;
            }
            if (valorFinal >= 2 && valorFinal < 3)
            {
                Console.Write(" Dois reais");
                valorFinal = valorFinal - 2;
            }
            if (valorFinal >= 3 && valorFinal < 4)
            {
                Console.Write(" Tres reais");
                valorFinal = valorFinal - 3;
            }
            if (valorFinal >= 4 && valorFinal < 5)
            {
                Console.Write(" Quatro reais");
                valorFinal = valorFinal - 4;
            }
            if (valorFinal >= 5 && valorFinal < 6)
            {
                Console.Write(" Cinco reais");
                valorFinal = valorFinal - 5;
            }
            if (valorFinal >= 6 && valorFinal < 7)
            {
                Console.Write(" Seis reais");
                valorFinal = valorFinal - 6;
            }
            if (valorFinal >= 7 && valorFinal < 8)
            {
                Console.Write(" Sete reais");
                valorFinal = valorFinal - 7;
            }
            if (valorFinal >= 8 && valorFinal < 9)
            {
                Console.Write(" Oito reais");
                valorFinal = valorFinal - 8;
            }
            if (valorFinal >= 9 && valorFinal < 10)
            {
                Console.Write(" Nove reais");
                valorFinal = valorFinal - 9;
            }
            if (valorFinal >= 0.10f && valorFinal < 0.20f)
            {
                Console.Write(" Dez centavos");
                valorFinal = valorFinal - 0.10f;
            }

        }
    }
}
