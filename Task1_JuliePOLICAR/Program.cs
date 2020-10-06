using System;

namespace Task1_JuliePOLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Myage();
            Myage1();

        }

        private static void Myage()
        {
            Console.WriteLine("How old are you ?");
            string age = Console.ReadLine();

            try
            {
                int age1 = int.Parse(age);

                int age10 = age1 + 10;
                Console.Write("Your age in 10 years will be " + age10);
            }

            catch
            {
                Console.WriteLine("Error");
            }
        }

        private static void Myage1()
        {
            Console.Write("How old are you ?");
            string age = Console.ReadLine();
       bool parseresult = int.TryParse(age, out int age1);
            if (parseresult)
            {
                int age10 = age1 + 10;
                Console.WriteLine("Your age in 10 years will be" + age10);
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
