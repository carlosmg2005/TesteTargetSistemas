using System;

namespace TesteTargetSistemas
{
    public class Teste1
    {
        public static void ExibirResultado()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            // Calculando a soma de 1 até INDICE
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
                Console.WriteLine($"K = {K}, SOMA = {SOMA}");
            }

            // Exibindo o resultado final
            Console.WriteLine($"Resultado Final: SOMA = {SOMA}");
        }
    }
}
