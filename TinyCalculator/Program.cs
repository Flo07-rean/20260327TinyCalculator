using System.Text;
using System.Globalization;

namespace TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("== Tiny Calculator ==");

            int a = ReadOperand("Operand 1");
            Console.ResetColor();

            int b = ReadOperand("Operand 2");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Rechnung: {a} + {b} = {a + b}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Rechnung: {a} - {b} = {a - b}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Rechnung: {a} * {b} = {a * b}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (b != 0)
            {
                Console.WriteLine($"Rechnung: {a} / {b} = {(double)a / b}");
                Console.WriteLine($"Rest: {a} % {b} = {a % b}");
            }
            else
            {
                Console.WriteLine("Division durch 0 nicht möglich!");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Rechnung: {a} ^ {b} = {Math.Pow(a, b)}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Fakultät: {a}! = {Factorial(a)}");
            Console.WriteLine($"Fakultät: {b}! = {Factorial(b)}");

            Console.ResetColor();
        }

        static int ReadOperand(string title)
        {
            Console.Write($"{title}: ");
            Console.ForegroundColor = ConsoleColor.Magenta;

            int operand;
            while (!TryParseInput(Console.ReadLine(), out operand))
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fehler: {title} ist keine gültige Zahl (Dezimal oder Hex wie 0xFF)");
                Console.ResetColor();
                Console.Write($"{title}: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            return operand;
        }

        static bool TryParseInput(string input, out int result)
        {
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                return int.TryParse(input.Substring(2),
                    NumberStyles.HexNumber,
                    CultureInfo.InvariantCulture,
                    out result);
            }

            return int.TryParse(input, out result);
        }

        static long Factorial(int n)
        {
            if (n < 0)
                return 0;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}