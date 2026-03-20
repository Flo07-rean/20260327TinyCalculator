namespace TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Tiny Calculator ==");

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
            if (b == 0) Console.WriteLine($"Rechnung: {a} / {b} = undefiniert/unendlich");
            else Console.WriteLine($"Rechnung: {a} / {b} = {a / b}");
            Console.ResetColor();
        }
        static int ReadOperand(string title)
        {
            Console.Write($"{title}:");
            int operand;
            while (!int.TryParse(Console.ReadLine(), out operand))
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fehler: {title} ist keine Zahl");
                Console.ResetColor();
                Console.Write($"{title}: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            return operand;
        }
    }
}
