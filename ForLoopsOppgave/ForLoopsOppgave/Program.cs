namespace ForLoopsOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var roundNumber = 1;

            while (roundNumber < 10)
            {
                Console.WriteLine($"Round number {roundNumber}");
                roundNumber++;
            }
        }
    }
}


//namespace ForLoopsOppgave
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string word = "Academy";

//            foreach (char oneLetter in word)
//            {
//                Console.WriteLine(oneLetter);
//            }

//            //(int i = 0; i < word.Length; i++)
//            //{
//            //    Console.WriteLine(word[i]);
//            //}

//        }
//    }
//}



/*Syntax for å lage array i C#.
namespace ForLoopsOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "hei", "på", "deg" };

            foreach (string oneLetter in array1)
            {
                Console.WriteLine(oneLetter);
            }

            //(int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine(word[i]);
            //}

        }
    }
}*/
