using System;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var gusser = new DayGuesser();
            gusser.ItroduceTheApplication();
            gusser.AskUsetForTheirDataofBirth();
            gusser.CalculateTheDateofWeek();
            gusser.PrintDayofTheWeek();
        }
    }
}
