using System;
using System.IO;

class q8
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de veículos:");
        int veiculos = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor do aluguel por veículo:");
        double valorAluguel = double.Parse(Console.ReadLine());
        
        double faturamentoMensal = (veiculos * valorAluguel) / 3;
        double faturamentoAnual = faturamentoMensal * 12;
        
        double multaMensal = (faturamentoMensal / 10) * 0.2;
        
        double manutencaoAnual = (veiculos * 0.02) * 600;
        
        using (StreamWriter sw = new StreamWriter("resultado.txt"))
        {
            sw.WriteLine("Faturamento mensal: " + faturamentoMensal);
            sw.WriteLine("Faturamento anual: " + faturamentoAnual);
            sw.WriteLine("Valor ganho com multas no mês: " + multaMensal);
            sw.WriteLine("Valor gasto com manutenção anual: " + manutencaoAnual);
        }
        
        Console.WriteLine("Resultados salvos em 'resultado.txt'");
    }
}
