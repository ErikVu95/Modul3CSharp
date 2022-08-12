namespace IfElseOppgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            //var num1 = random.Next(1, 4);
            //var num2 = random.Next(1, 4);
            var num1 = 30;
            var num2 = 1;
            //int total = 0;


            bool b = NumberPlusOrMultiply(num1, num2);

            Console.WriteLine($"{num1}");
            Console.WriteLine($"{num2}");
            Console.WriteLine($"{b}");

        }

        public static bool NumberPlusOrMultiply(int num1, int num2)
        {
            if (num1 + num2 == 30)
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