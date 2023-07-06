using System;
using System.Threading.Channels;

namespace Date_tas
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please add Day: ");
            var dateDay = Console.ReadLine();
            int dateDayInt = int.Parse(dateDay);

            Console.WriteLine("Please add Month: ");
            var dateMonth = Console.ReadLine();
            var dateMonthInt = Convert.ToInt32(dateMonth);

            Console.WriteLine("Please add Year: ");
            var dateYear = Console.ReadLine();
            var dateYearInt = Convert.ToInt32(dateYear);

            DateTime myDate = new DateTime(dateYearInt, dateMonthInt, dateDayInt,00,00,00).AddDays(30).AddHours(6).AddMinutes(17);
           
            Console.WriteLine(myDate.ToString("dd/MM/yyyy HH:mm"));

        }



    }
















}
