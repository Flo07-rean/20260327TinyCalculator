namespace TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("== Tiny Calculator ==");

            Console.Write("Gib ersten Operand ein: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Gib zweiten Operand ein: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int b = int.Parse(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Rechnung: {a} + {b} = {a + b}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Rechnung: {a} - {b} = {a - b}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Rechnung: {a} * {b} = {a * b}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (b == 0) Console.WriteLine($"Rechnung: {a} / {b} = undefiniert/unendlich");
            else Console.WriteLine($"Rechnung: {a} / {b} = {a / b}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
