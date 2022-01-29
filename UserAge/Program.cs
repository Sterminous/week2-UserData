using System;

namespace UserAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaastat;
            //Programm kuvab kasutaja sünniaastat konsoolis;

            Console.WriteLine("Sisestage oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearofBirth = 2022 - userAge;
            Console.WriteLine($"Olete sündinud aastal {yearofBirth}.");

        }
    }
}
