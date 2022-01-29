using System;

namespace InstagramAgeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm kontrollib, kas kasutaja on vanem, kui 13;
            //Kui kasutaja on vanem, kui 13, siis võib kasutada instagrami;
            //Kui kasutaja on noorem, kui 13, siis ei või kasutaja kasutada;

            Console.WriteLine("Sisestage oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kasutada.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kasutada.");
            }
            else
            {
                Console.WriteLine("Oledki 13, saate kasutada Instagrami.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
