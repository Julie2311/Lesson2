using System;

namespace Task4_JuliePOLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            FutureBirthday();
        }

        private static void FutureBirthday()
        {
            Console.WriteLine("How old are you ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your future age ?");
            int futureage = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthday month ?");
            int bdmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birthday day of month ?");
            int bdday = int.Parse(Console.ReadLine());

            int difference = age + futureage;
            int futureyear = DateTime.Now.Year + difference;
            var futurebdday = new DateTime(futureyear, bdmonth, bdday);

        }
    }
}
