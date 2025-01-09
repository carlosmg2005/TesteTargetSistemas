using System;

namespace TesteTargetSistemas
{
    public class Teste4
    {
        public static void CalcularPercentualFaturamento()
        {
            // Valores de faturamento por estado
            decimal faturamentoSP = 67836.43m;
            decimal faturamentoRJ = 36678.66m;
            decimal faturamentoMG = 29229.88m;
            decimal faturamentoES = 27165.48m;
            decimal faturamentoOutros = 19849.53m;

            // Calcula o total
            decimal faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            // Verifica se o total é válido
            if (faturamentoTotal <= 0)
            {
                Console.WriteLine("Erro: Faturamento total inválido.");
                return;
            }

            // Calcula os percentuais
            decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
            decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
            decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
            decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
            decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

            // Exibe os resultados
            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine($"SP: {percentualSP:F2}%");
            Console.WriteLine($"RJ: {percentualRJ:F2}%");
            Console.WriteLine($"MG: {percentualMG:F2}%");
            Console.WriteLine($"ES: {percentualES:F2}%");
            Console.WriteLine($"Outros: {percentualOutros:F2}%");
        }
    }
}