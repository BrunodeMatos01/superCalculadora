using System;
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
            Console.WriteLine("Bem vindo a Super Calculadora");
            Console.WriteLine(" + para somar.");
            Console.WriteLine(" - para subtrair.");
            Console.WriteLine(" * para mutiplicar.");
            Console.WriteLine(" / para dividir.");
            Console.WriteLine("(ENTER para sair)");

            Console.WriteLine("Informe o primeiro numero");
            double nmr1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada");
            string operacao = Console.ReadLine();

            Console.WriteLine("Informe o segundo numero");
            double nmr2 = double.Parse(Console.ReadLine());

            double somaTotal = 0;

            switch (operacao)
            {
                case "+" :
                    {
                        Soma soma = new Soma();
                        somaTotal = soma.Somar(nmr1, nmr2);
                        break;
                    }
                case "-":
                    {

                        break;
                    }
                case "*":
                    {

                        break;
                    }
                case "/":
                    {
                        Divisao divisao = new Divisao();
                        somaTotal = divisao.Dividir(nmr1, nmr2);
                        break;
                    }
            }


        }


    }
}
