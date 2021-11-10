using DayOfTheWeek.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayOfTheWeek
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }
        public DateTimeOffset UserDateOfBirth { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void ItroduceTheApplication()
        {
            Console.WriteLine("Hej jestem botem, który potrafi wyliczac dzien tyodnia na podstawie Twojej daty urodzenia.");

            Calculator = new DayCalculator();
        }

        public void AskUsetForTheirDataofBirth()
        {
            Console.WriteLine("Proszę podaj swoją datę urodzenia: ");

            var userDate = Console.ReadLine();
            
           var succesed =  DateTimeOffset.TryParse(userDate,out var date);
            if (succesed)
            { 
            UserDateOfBirth = date;
                return;
            } 
            else
            {
            Console.WriteLine("Format daty był zły prosze go podać w mm/dd/yyyy ");
            AskUsetForTheirDataofBirth();
            }
        }

        public void CalculateTheDateofWeek()
        {
            if (UserDateOfBirth == null)
            {
                Console.WriteLine("Probowana obliczyć dzień tygodnia bez podania daty urodzenia");
                return;
            }

            UserDayOfTheWeek =  Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }

        public void PrintDayofTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to : " + UserDayOfTheWeek.ToPolishString());
            Console.ReadLine();
        }
    }
}
