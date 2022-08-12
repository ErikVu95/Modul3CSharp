using System.Diagnostics.CodeAnalysis;

namespace ifElseOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var num1 = random.Next(1, 4);
            var num2 = random.Next(1, 4);


            bool b = NumberCheck(num1, num2);
            
            if (b)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("not yes");
            }

        }

        public static bool NumberCheck(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}