using DesafioContagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioContagem
{
    public static class Imc
    {

        public static void imc()
        {
            /**
             * Escreva um programa que calcula o IMC (Índice 
             * de massa corporal de uma pessoa) e exibe o
             * resultado.
             * 
             * Resultado esperado
             * 
             * Informe sua altura: 1,75
             * Informe seu peso: 85

             * > Seu IMC é 27.76
             * > Sobrepeso
             * > Obesidade Grau I
             * > Risco: Aumentado
             * 
             */

            float altura = 0;
            float peso = 0;
            string tipo = string.Empty;
            string risco = string.Empty;

            Console.WriteLine("Informe sua altura: ");
            altura = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            peso = Convert.ToSingle(Console.ReadLine());
            float imc = peso / (altura * altura);
            Console.WriteLine($"> Seu IMC é {imc}");



            if (imc < 16)
            {
                tipo = "> Magreza Grau III";
            }
            if (imc >= 16 && imc <= 16.9)
            {
                tipo = "> Magreza Grau II";
            }
            if (imc >= 17 && imc <= 18.4)
            {
                tipo = "> Magreza Grau I";
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                tipo = "> Eutrofilia";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                tipo = "> Sobrepeso";
                risco = "> Aumentado";
            }
            if (imc >= 30 && imc <= 34.9)
            {
                tipo = "> Obesidade Grau I";
                risco = "> Moderado";
            }
            if (imc >= 35 && imc <= 40)
            {
                tipo = "> Obesidade Grau II";
                risco = "> Grave";
            }
            if (imc > 40)
            {
                tipo = "> Obesidade Grau III";
                risco = "> Muito Grave";
            }

            Console.WriteLine($"{tipo}");

            if (imc >= 25)
            {
                Console.WriteLine($"{risco}");
            }
        }
    }
}
