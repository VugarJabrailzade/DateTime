using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Threading.Channels;

namespace Date_tas
{
   

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter datetime like this: dd_MM_yyyy: ");
            
          

            try
            {
               string s = Console.ReadLine();
               var dt =  DateTime.ParseExact(s, "dd_MM_yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(dt);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

    }

}
