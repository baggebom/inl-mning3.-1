using System;

namespace uppgift
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hej, Hur gammal är du");

            int svar = int.Parse(Console.ReadLine());

            switch (svar)
            {

                case 16:
                    Console.WriteLine("Du är tillräckligt gammal för att delta i tävlingen");
                    break;

                case 17:
                    Console.WriteLine("Du är tillräckligt gammal för att delta i tävlingen");
                    break;

                case 18:
                    Console.WriteLine("Du är tillräckligt gammal för att delta i tävlingen");
                    break;
                default:
                    Console.WriteLine("Du får inte delta i tävlingen");

                    break;
            }
            Console.ReadKey();

        }
    }
}
