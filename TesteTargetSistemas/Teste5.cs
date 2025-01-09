using System;

namespace TesteTargetSistemas
{
    public class Teste5
    {
        public static void InverterString()
        {
            // Solicita a entrada do usuário
            Console.WriteLine("Digite uma string para inverter:");
            string? input = Console.ReadLine();

            // Verifica se a entrada é nula ou vazia
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String inválida. Tente novamente.");
                return;
            }

            // Cria um array de caracteres da string
            char[] caracteres = input.ToCharArray();

            // Inverte a string manualmente
            for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
            {
                // Troca os caracteres nas posições opostas
                char temp = caracteres[i];
                caracteres[i] = caracteres[j];
                caracteres[j] = temp;
            }

            // Converte o array de volta para uma string
            string stringInvertida = new string(caracteres);

            // Exibe o resultado
            Console.WriteLine($"String invertida: {stringInvertida}");
        }
    }
}