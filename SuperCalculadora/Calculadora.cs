﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculadora
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" BEM VINDO A SUPER CALCULADORA\n");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Voce pode informar 2 numeros");
            Console.WriteLine(" + para somar.");
            Console.WriteLine(" - para subtrair.");
            Console.WriteLine(" * para mutiplicar.");
            Console.WriteLine(" / para dividir.");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            Console.WriteLine("Informe o primeiro numero :");
            double nmr1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada :");
            string operacao = Console.ReadLine();

            Console.WriteLine("Informe o segundo numero : ");
            double nmr2 = double.Parse(Console.ReadLine());

            double somaTotal = 0;

            switch (operacao)
            {
                case "+":
                    {
                        Soma soma = new Soma();
                        somaTotal = soma.Somar(nmr1, nmr2);
                        Console.WriteLine($"A soma de {nmr1} por {nmr2} = {somaTotal}");

                        break;
                    }
                case "-":
                    {
                        Subtracao subtracao = new Subtracao();
                        somaTotal = subtracao.Subtrair(nmr1, nmr2);
                        Console.WriteLine($"A subtração de {nmr1} por {nmr2} = {somaTotal}");

                        break;
                    }
                case "*":
                    {
                        Multiplicacao multiplicacao = new Multiplicacao();
                        somaTotal = multiplicacao.Multiplicar(nmr1, nmr2);
                        Console.WriteLine($"A mutiplicação entre {nmr1} e {nmr2} = {somaTotal}");

                        break;
                    }
                case "/":
                    {
                        Divisao divisao = new Divisao();
                        somaTotal = divisao.Dividir(nmr1, nmr2);
                        Console.WriteLine($"A divisão de {nmr1} por {nmr2} = {somaTotal}");

                        break;
                    }
                default:
                    Console.WriteLine("Está operação não existe. (+|-|*|/)");
                    break;
            }
        }
    }
}
