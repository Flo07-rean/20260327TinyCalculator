using System.Text;

namespace TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Tiny Calculator ==");
            Console.OutputEncoding = Encoding.UTF8;
            int a = ReadOperand("Operand 1");

            Console.ResetColor();

            int b = ReadOperand("Operand 2"); ;
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Rechnung: {a} + {b} = {a + b}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Rechnung: {a} - {b} = {a - b}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Rechnung: {a} * {b} = {a * b}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Rechnung: {a} / {b} = {(double)a / b}");
            Console.ResetColor();
        }
        static int ReadOperand(string title)
        {
            Console.Write($"{title}:");
            int a;
            Console.ForegroundColor = ConsoleColor.Magenta;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fehler: {title} ist keine Zahl");
                Console.ResetColor();
                Console.Write($"{title}: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            return a;
        }
    }
}
