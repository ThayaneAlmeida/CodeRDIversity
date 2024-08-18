using System;
using System.Collections.Generic;

// Thayane Gonçalo de Almeida
public class Aula05Ex
{
    public static void Main(string[] args)
    {
       try
        {
            // Estrutura da Geladeira
            var geladeira = new Dictionary<int, Dictionary<int, List<string>>>()
            {
                
            { 0, new Dictionary<int, List<string>>() // Andar 0 - Hortifruti
                {
                    { 0, new List<string> { "banana", "manga", "cenoura", "abobrinha" } },
                    { 1, new List<string> { "espinafre", "tomate", "pepino", "mandioca" } }
                }
            },
            { 1, new Dictionary<int, List<string>>() // Andar 1 - Laticínios e Enlatados
                {
                    { 0, new List<string> { "iogurte", "leite", "queijo", "manteiga" } },
                    { 1, new List<string> { "milho", "sardinha", "ervilha", "atum" } }
                }
            },
            { 2, new Dictionary<int, List<string>>() // Andar 2 - Charcutaria, Carnes e Ovos
                {
                    { 0, new List<string> { "bacon", "ovos", "carne", "salame" } },
                    { 1, new List<string> { "presunto", "salsicha", "hamburguer", "linguiça" } }
                }
            }
        };

            
            ImprimirProdutos(geladeira);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao inserir os dados da geladeira:");
            Console.WriteLine(ex.Message);
        }
    }

   
    static void ImprimirProdutos(Dictionary<int, Dictionary<int, List<string>>> geladeira)
    {
        try
        {
            foreach (var andar in geladeira)
            {
                Console.WriteLine($"Andar {andar.Key}:");
                foreach (var container in andar.Value)
                {
                    Console.WriteLine($"  Container {container.Key}: {string.Join(", ", container.Value)}");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro para imprimir os produtos da geladeira:");
            Console.WriteLine(ex.Message);
        }
    }
}