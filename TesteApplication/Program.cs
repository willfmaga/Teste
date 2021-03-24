using Newtonsoft.Json;
using System;
using Teste;

namespace TesteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IClienteService _clienteService = new ClienteServiceInMemory();

            Console.WriteLine("Bem vindo ao teste");
            string escolha = string.Empty;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                MenuPrincipal();
                escolha = LeituraLinha();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Digite o documento(sem pontuação)");
                        string documento = LeituraLinha();

                        var cliente = _clienteService.Buscar(documento, 55);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(JsonConvert.SerializeObject(cliente));

                        break;
                    case "2":
                        Console.WriteLine("Digite o nome ou parte dele");
                        string nome = LeituraLinha();

                        var clientes = _clienteService.Buscar(nome);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(JsonConvert.SerializeObject(clientes));

                        break;
                    case "3":
                        escolha = "3";
                        break;
                    default:
                        Console.WriteLine("Voce deve escolher dentre as opções fornecidas.");
                        MenuPrincipal();
                        escolha = LeituraLinha();
                        continue;

                }


            } while (!escolha.Equals("3"));

            Console.WriteLine("Obrigado por usar o Teste.");

        }

        private static string LeituraLinha()
        {
            return Console.ReadLine();
        }

        private static void MenuPrincipal()
        {
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Pesquisa por Documento");
            Console.WriteLine("2 - Pesquisa por nome");
            Console.WriteLine("3 - Sair");
        }
    }
}
