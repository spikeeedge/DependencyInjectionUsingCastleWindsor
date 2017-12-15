namespace DependencyInjectionUsingCastleWindsor
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");

            IoC.Register();

            Console.WriteLine("IoC Registered");
        }
    }
}
