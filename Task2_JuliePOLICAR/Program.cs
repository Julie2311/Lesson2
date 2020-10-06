using System;

namespace Task2_JuliePOLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle();
            Triangle();
            cercle();
        }

        private static void Rectangle()
        {
            Console.WriteLine("Please enter the length of side 1 : ");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of side 2 : ");
            int side2 = int.Parse(Console.ReadLine());


            int area = side1 * side2;
            int perimeter = 2 * side1 + 2 * side2;
        }

        private static void Triangle()
        {
            Console.WriteLine("Please enter side1 :");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side2 :");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side3 :");
            int side3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height :");
            int height = int.Parse(Console.ReadLine());



            int perimeter = side1 + side2 + side3;
            int area = side1 * height / 2;

        }

        private static void cercle()
        {
            Console.WriteLine("Please enter the radius of the cercle :");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the cercle is" + (radius^2) * Math.PI);
            Console.WriteLine("The perimeter of the cercle is " + 2 * radius * Math.PI);

        }
    }
}
