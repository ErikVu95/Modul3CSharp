using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace IfElseOppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var num1 = random.Next(1, 4);
            var num2 = random.Next(1, 4);
            int total = 0;


            var b = NumberPlusOrMultiply(num1, num2);

            Console.WriteLine($"{num1}");
            Console.WriteLine($"{num2}");
            Console.WriteLine($"{b}");

        }

        public static int NumberPlusOrMultiply(int num1, int num2)
        {
            if (num1 == num2)
            {
                int total = num1 * num2;  
                return total;
            }
            else
            {
                int total = num1 + num2;
                return total;
            }

        }
    }
}