using System;

namespace TesteTargetSistemas
{
    public class Teste2
    {
        public static void CalcularFibonacci()
        {
            int? numero = null;

            // Recebendo o número que o usuário deseja verificar com validação
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
            string input = Console.ReadLine();

            // Verificando se a entrada é um número válido
            while (!int.TryParse(input, out int tempNumero) || tempNumero < 0)
            {
                Console.Write("Entrada inválida. Digite um número válido: ");
                input = Console.ReadLine();
            }

            // Atribuindo o número validado à variável 'numero'
            numero = int.Parse(input);

            int a = 0, b = 1, proximoTermo;

            // Exibindo a sequência de Fibonacci até o número informado
            Console.Write("Sequência de Fibonacci: 0, 1");

            while (b <= numero)
            {
                proximoTermo = a + b;
                Console.Write($", {proximoTermo}");
                a = b;
                b = proximoTermo;
            }

            Console.WriteLine();

            // Verificando se o número informado pertence à sequência
            if (numero == 0 || numero == 1 || b == numero)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }
        }
    }
}
