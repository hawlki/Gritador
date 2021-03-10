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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Por favor, digite alguma coisa:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            String algumaCoisa = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{algumaCoisa.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("para de gritar comigo!, vc pensa que eu sou só uma maquína?, eu sinto emoções também!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("sabe o que é teclado? Então...Aperta qualquer botão ai que vai limpar a sua tela :)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
