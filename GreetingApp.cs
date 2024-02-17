using System;
namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter the number of enrolled courses: ");
            int numberOfCourses = int.Parse(Console.ReadLine());

            Console.Write("Please enter the price of your favorite book: ");
            double bookPrice = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number of enrolled courses: " + numberOfCourses);
            Console.WriteLine("Price of my favorite book: " + bookPrice);
        }
    }
}
