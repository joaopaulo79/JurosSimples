using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Juros Simples ===");
            Console.WriteLine();
            Console.Write("Digite o Capital: ");
            Console.ResetColor();
            string capitalDigitado = Console.ReadLine();
            double capital = Convert.ToDouble(capitalDigitado);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite a Taxa de Juros: ");
            Console.ResetColor();
            string taxaDigitado = Console.ReadLine();
            double taxa = Convert.ToDouble(taxaDigitado);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o Tempo em meses: ");
            Console.ResetColor();
            string tempoDigitado = Console.ReadLine();
            double tempo = Convert.ToDouble(tempoDigitado);
            double juros = capital * (taxa / 100) * tempo;
            double montante = capital + juros;
            Console.WriteLine();
            Console.WriteLine($"Capital........: {capital:C}");
            Console.WriteLine($"Taxa de juros..: {taxa}%");
            Console.WriteLine($"Tempo..........: {tempo} meses");
            Console.WriteLine();
            Console.WriteLine($"Juros..........: {juros:C}");
            Console.WriteLine($"Montante.......: {montante:C}");
            Console.WriteLine();
        }
    }
}
