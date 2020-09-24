using System;

namespace TechnicalAssignment3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name below: ");

            try
            {
                string name = Console.ReadLine();

                Greeting_Statement(name);

                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter a name...");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }

        private static void Greeting_Statement(string name)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + name + "!");
        }
    }
}
