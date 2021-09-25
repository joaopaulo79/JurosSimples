using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, tj, t, j, m;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n====== Juros Simples ======\n");
            Console.ResetColor();

            Console.WriteLine("Insira o capital inicial, a\ntaxa de juros e o tempo da");
            Console.WriteLine("aplicação em meses, para\ncalcular Juros Simples\n");

            Console.Write("Capital.........: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de Juros...: ");
            tj = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo em meses..: ");
            t = Convert.ToDouble(Console.ReadLine());

            j = c * (tj / 100) * t;

            m = c + j;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Juros e Montante ===\n");
            Console.ResetColor();

            Console.WriteLine($"Juros...........: {j:C}\nMontante........: {m:C}\n");
        }
    }
}
