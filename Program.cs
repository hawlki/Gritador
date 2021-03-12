using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Por favor, digite alguma coisa:");
            String algumaCoisa = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{algumaCoisa.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("para de gritar comigo!, vc pensa que eu sou so uma maquina?, eu sinto emocoes tambem!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("clique em uma tecla para limpar a tela");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
