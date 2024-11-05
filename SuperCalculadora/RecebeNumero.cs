namespace SuperCalculadora
{
    public class RecebeNumeros
    {
        public string OperaNumeros(double nmr1, double nmr2, string operacao)
        {
            Console.WriteLine("Voce pode informar 2 numeros");
            Console.WriteLine(" + para somar.");
            Console.WriteLine(" - para subtrair.");
            Console.WriteLine(" * para mutiplicar.");
            Console.WriteLine(" / para dividir.");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            Console.WriteLine("Informe o primeiro numero :");
            nmr1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada :");
            operacao = Console.ReadLine();

            Console.WriteLine("Informe o segundo numero : ");
            nmr2 = double.Parse(Console.ReadLine());

            double somaTotal = 0;

            switch (operacao)
            {
                case "+":
                    {
                        Soma soma = new Soma();
                        somaTotal = soma.Somar(nmr1, nmr2);
                        Console.WriteLine($"A soma de {nmr1} por {nmr2} = {somaTotal}.");

                        break;
                    }
                case "-":
                    {
                        Subtracao subtracao = new Subtracao();
                        somaTotal = subtracao.Subtrair(nmr1, nmr2);
                        Console.WriteLine($"A subtração de {nmr1} por {nmr2} = {somaTotal}.");

                        break;
                    }
                case "*":
                    {
                        Multiplicacao multiplicacao = new Multiplicacao();
                        somaTotal = multiplicacao.Multiplicar(nmr1, nmr2);
                        Console.WriteLine($"A mutiplicação entre {nmr1} e {nmr2} = {somaTotal}.");

                        break;
                    }
                case "/":
                    {
                        Divisao divisao = new Divisao();
                        if (nmr2 == 0)
                        {
                            Console.WriteLine("*ERRO* Divisão por 0 não é possivel!");
                            break;
                        }
                        else
                        {
                            somaTotal = divisao.Dividir(nmr1, nmr2);
                            Console.WriteLine($"A divisão de {nmr1} por {nmr2} = {somaTotal}.");

                            break;
                        }
                    }
                default:
                    Console.WriteLine("Esta operação não existe. Escolha entre (+|-|*|/).");
                    break;

            }
            Thread.Sleep(1000);
            Console.WriteLine("\nDigite OK para sair ou tecle ENTER para fazer outro cálculo: \n");
            operacao = Console.ReadLine();

            Console.Clear();
            return operacao;
        }

    }
}
