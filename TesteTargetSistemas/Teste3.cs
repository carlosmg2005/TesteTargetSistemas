using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TesteTargetSistemas
{
    public class Teste3
    {
        public static void CalcularFaturamento()
        {
            try
            {
                // Lê o arquivo JSON contendo os dados de faturamento
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.json");
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Erro: O arquivo 'dados.json' não foi encontrado.");
                    return;
                }

                string json = File.ReadAllText(caminhoArquivo);
                var faturamentoMensal = JsonSerializer.Deserialize<FaturamentoDiario[]>(json);

                if (faturamentoMensal == null || faturamentoMensal.Length == 0)
                {
                    Console.WriteLine("Erro: O arquivo 'dados.json' está vazio ou inválido.");
                    return;
                }

                // Inicializa as variáveis para o cálculo
                decimal menorFaturamento = decimal.MaxValue;
                decimal maiorFaturamento = decimal.MinValue;
                decimal somaFaturamento = 0;
                int diasComFaturamento = 0;

                foreach (var dia in faturamentoMensal)
                {
                    if (dia.Valor > 0)
                    {
                        somaFaturamento += dia.Valor;
                        diasComFaturamento++;

                        if (dia.Valor < menorFaturamento)
                            menorFaturamento = dia.Valor;

                        if (dia.Valor > maiorFaturamento)
                            maiorFaturamento = dia.Valor;
                    }
                }

                if (diasComFaturamento == 0)
                {
                    Console.WriteLine("Nenhum dia com faturamento registrado.");
                    return;
                }

                // Calcula a média mensal de faturamento (ignorando dias com faturamento zero)
                decimal mediaMensal = somaFaturamento / diasComFaturamento;

                // Conta os dias com faturamento acima da média
                int diasAcimaDaMedia = 0;
                foreach (var dia in faturamentoMensal)
                {
                    if (dia.Valor > mediaMensal)
                        diasAcimaDaMedia++;
                }

                // Exibe os resultados
                Console.WriteLine($"Menor faturamento: R${menorFaturamento:F2}");
                Console.WriteLine($"Maior faturamento: R${maiorFaturamento:F2}");
                Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar os dados: {ex.Message}");
            }
        }

        // Classe auxiliar para deserializar o JSON
        public class FaturamentoDiario
        {
            [JsonPropertyName("dia")]
            public int Dia { get; set; }
            [JsonPropertyName("valor")]
            public decimal Valor { get; set; }
        }
    }
}
