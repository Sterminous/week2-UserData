using System;

namespace UserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //Programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Sisestage oma sünniaasta:");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofBirth;
            //Console.WriteLine("Oled " + userAge + "-aastane.");

            //string interpolation

            Console.WriteLine($"Oled {userAge}-aastane.");
        }
    }
}
