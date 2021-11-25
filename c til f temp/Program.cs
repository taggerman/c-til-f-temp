using System;

namespace c_til_f_temp
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("velkommen til temp udregning");
            Console.WriteLine("vi du konvertere f til c eller omvendt");
            Console.WriteLine("tast f for faranheit, tadt c for celcius");

            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "f":
                case "F":
                    Console.WriteLine("du valgte faranheit");
                    Faranheit();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("du valgte celcius");
                    Celcius();
                    break;
                default:
                    Console.Clear();
                    goto start;

            }
        nytemp:
            Console.WriteLine("vil du udregne en ny temp?");
            Console.WriteLine("tast j for ja, tast n for nej");
            string jaNej = Console.ReadLine();
            switch (jaNej)
            {
                case "j":
                case "J":
                    Console.Clear();
                    goto start;
                case "n":
                case "N":
                    break;
                default:
                    Console.Clear();
                    goto nytemp;
            }
        }

        static void Faranheit()
        {
        faranheit:
            Console.WriteLine("indtast faranheit værdi");

            if (float.TryParse(Console.ReadLine().Replace(".", ","), out float faranheit))
            {
                Console.WriteLine(faranheit + " faranheit er " + ((faranheit - 32) * 5 / 9).ToString("#.#") + " grader i celcius");
            }

            else
            {
                Console.WriteLine("prøv igen");
                Console.ReadKey();
                Console.Clear();
                goto faranheit;
            }


        }

        static void Celcius()
        {
        celcius:
            Console.WriteLine("indtast celcius værdi");

            if (float.TryParse(Console.ReadLine().Replace(".", ","), out float celcius))
            {
                Console.WriteLine(celcius + " celcius er " + ((celcius * 1.8f) + 32).ToString("#.#") + " grader i faranheit");
            }

            else
            {
                Console.WriteLine("prøv igen");
                Console.ReadKey();
                Console.Clear();
                goto celcius;
            }

        }
    }
}
