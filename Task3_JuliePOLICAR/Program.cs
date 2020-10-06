using System;

namespace Task3_JuliePOLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentDate();
            CurrentTime();
            Datein10y();
            DateinXy();
        }

        private static void CurrentDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToShortDateString());
        }

        private static void CurrentTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToShortTimeString());
        }

        private static void Datein10y()
        {
            DateTime datein10y = DateTime.Now.AddYears(10);
            Console.WriteLine(datein10y);
        }

        private static void DateinXy()
        {
            Console.WriteLine("Please enter the number of years :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddYears(x));
        }
    }
}
