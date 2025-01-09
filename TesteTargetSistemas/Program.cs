using System;

namespace TesteTargetSistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== MENU - TESTES TARGET SISTEMAS ===");
                Console.WriteLine("1 - Teste 1: Cálculo do valor de SOMA");
                Console.WriteLine("2 - Teste 2: Verificar número na sequência de Fibonacci");
                Console.WriteLine("3 - Teste 3: Análise de faturamento mensal");
                Console.WriteLine("4 - Teste 4: Percentual de faturamento por estado");
                Console.WriteLine("5 - Teste 5: Inverter uma string");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Teste1.ExibirResultado();
                        Pausar();
                        break;
                    case "2":
                        Console.Clear();
                        Teste2.CalcularFibonacci();
                        Pausar();
                        break;
                    case "3":
                        Console.Clear();
                        Teste3.CalcularFaturamento();
                        Pausar();
                        break;
                    case "4":
                        Console.Clear();
                        Teste4.CalcularPercentualFaturamento();
                        Pausar();
                        break;
                    case "5":
                        Console.Clear();
                        Teste5.InverterString();
                        Pausar();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Pausar();
                        break;
                }
            }
        }

        // Método para pausar a execução e aguardar entrada do usuário
        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}