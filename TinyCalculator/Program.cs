namespace TinyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Tiny Calculator ==");

            Console.Write("Gib ersten Operand ein: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Gib zweiten Operand ein: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Rechnung: {a} + {b} = {a + b}");
            Console.WriteLine($"Rechnung: {a} - {b} = {a - b}");
            Console.WriteLine($"Rechnung: {a} * {b} = {a * b}");
            Console.WriteLine($"Rechnung: {a} / {b} = {a / b}");
        }
    }
}
