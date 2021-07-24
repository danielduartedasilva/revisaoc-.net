using System;
using System.Collections.Generic;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            do
            {
                Console.Clear();
                Console.WriteLine("-- Cadastrar Cliente --");
                Console.WriteLine("1 - Digite o nome do Cliente");
                Console.WriteLine("2 - Digite o cpf do Cliente");
                Console.WriteLine("3 - Listar Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1 - Cadastrar Cliente");
                        Console.WriteLine("2 - Digite o nome do Cliente");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("2 - Digite o cpf do Cliente");
                        c.Cpf = Console.ReadLine();
                        //Mensagem de sucesso
                        Console.WriteLine($"Nome: {c.Nome} e Cpf: {c.Cpf}");
                        break;
                    case 2:
                        Console.WriteLine("\nListar Cliente");
                        //Laço de repetição para mostrar todos os clientes
                        break;
                    case 0:
                        Console.WriteLine("\nSair");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar:");
                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}
