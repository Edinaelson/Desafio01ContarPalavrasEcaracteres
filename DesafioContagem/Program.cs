﻿using System;

namespace DesafioContagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que conte a quantidade de
             * palavras e caracteres que um determinado texto,
             * escrito no Console, contém.
             * 
             * Resultado esperado
             * Digite um texto:
             * Este texto foi digitado no console
             *34 caracteres, 6 palavras
             */

            Console.WriteLine("Digite um texto: ");

            string texto = Console.ReadLine();
            int quant = texto.Length;
            string[] quantPalavras = texto.Trim().Split(new char[] {' '});

            Console.WriteLine("Este texto foi digitado no console");
            Console.WriteLine($"> {quant} caracteres {quantPalavras.Length} palavras");
            

        }
    }
}
