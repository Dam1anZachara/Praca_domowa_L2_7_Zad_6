using System;

namespace _2_7_Zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten program przypisze twój wzrost do danej kategorii");
            Console.Write("Podaj swój wzrost w [cm]: ");
            ushort.TryParse(Console.ReadLine(), out ushort userHeight);

            if (userHeight > 0 && userHeight <= 45)
            {
                Console.WriteLine("Jesteś...Kim ty jesteś?");
            }
            else if (userHeight > 45 && userHeight <= 55)
            {
                Console.WriteLine("Jesteś noworodkiem.");
            }
            else if (userHeight > 55 && userHeight <= 80)
            {
                Console.WriteLine("Jesteś skrzatem.");
            }
            else if (userHeight > 80 && userHeight <= 110)
            {
                Console.WriteLine("Jesteś gnomem.");
            }
            else if (userHeight > 110 && userHeight <= 140)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (userHeight > 140 && userHeight <= 159)
            {
                Console.WriteLine("Jesteś hobbitem.");
            }
            else if (userHeight > 159 && userHeight <= 180)
            {
                Console.WriteLine("Jesteś człowiekiem.");
            }
            else if (userHeight > 180 && userHeight <= 200)
            {
                Console.WriteLine("Jesteś elfem.");
            }
            else if (userHeight > 200 && userHeight <= 220)
            {
                Console.WriteLine("Jesteś koszykarzem.");
            }
            else if (userHeight > 220 && userHeight <= 275)
            {
                Console.WriteLine("Jesteś gigantem.");
            }
            else
            {
                Console.WriteLine("Jesteś z innej planety.");
            }
        }
    }
}
