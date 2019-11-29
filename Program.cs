using System;
using System.Linq;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {            
            int resto = 1;
            var notas = new int[4];
            var quantNotas = new int[4];
            notas[0] = 100;
            notas[1] = 50;
            notas[2] = 20;
            notas[3] = 10;

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Bem vindo ao Caixa eletrônico!");
                    Console.WriteLine("Notas disponíveis para saque:");
                    Console.WriteLine("R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor que deseja sacar, deve ser um número inteiro:");
                    resto = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < notas.Count() && resto > 0; i++)
                    {
                        if (resto >= notas[i])
                        {
                            quantNotas[i] = Convert.ToInt32(resto / notas[i]);
                            resto = resto % notas[i];
                        }
                    }

                    Console.WriteLine();
                    if (resto > 0)
                    {
                        Console.WriteLine("Valor desejado para saque não é compatível com as notas disponíveis!");
                    }
                    else
                    {
                        Console.WriteLine("Você vai receber a quantidade de notas abaixo:");
                        for (int i = 0; i < quantNotas.Count(); i++)
                        {
                            if(quantNotas[i] == 0) continue;
                            Console.WriteLine($"R$ {notas[i]},00 => {quantNotas[i]}");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Deseja efetuar um novo saque:");
                    Console.WriteLine("1 => Sim");
                    Console.WriteLine("2 => Não");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Algo aconteceu de errado!");
                    Console.WriteLine("Deseja efetuar um novo saque:");
                    Console.WriteLine("1 => Sim");
                    Console.WriteLine("2 => Não");
                }

            } while (Console.ReadLine() == "1");
        }
    }
}
