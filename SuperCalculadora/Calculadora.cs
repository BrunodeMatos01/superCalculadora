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
            Console.WriteLine(" BEM VINDO A SUPER CALCULADORA\n");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            string operacao = "";
            RecebeNumeros receba = new RecebeNumeros();

            do
            {
                operacao = receba.OperaNumeros(0, 0, "");
            } while (operacao.ToUpper() != "OK");

            System.Console.WriteLine("ENCERRANDO A SUPER CALCULADORA...");
            Thread.Sleep(2000);
        }
    }
}
